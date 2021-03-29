using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileTreeBuilderLib
{
    public class FileTreeParser
    {
        public FileTree Parse(string fileName, bool sort = true)
        {
            var lines = File.ReadAllLines(fileName);

            return Parse(lines, sort);
        }

        public FileTree Parse(IEnumerable<string> strings, bool sort = true)
        {
            var tree = new FileTree();

            var lines = strings.ToArray();
            if (sort)
            {
                Array.Sort(lines, StringComparer.OrdinalIgnoreCase);
            }

            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line)) continue;

                var node = tree.Root;
                var dirNames = line.Split('\\', StringSplitOptions.RemoveEmptyEntries);
                foreach (var dirName in dirNames)
                {
                    if (TryGetFileInfo(dirName, out string name, out int size))
                    {
                        var file = new FileTree.FileNode(name, size);
                        node.Files.Add(file);
                    }
                    else
                    {
                        var directory = node.Directories.Find(x => x.Name.Equals(dirName));
                        if (directory == null)
                        {
                            directory = new FileTree.DirectoryNode(dirName);
                            node.Directories.Add(directory);
                        }
                        node = directory;
                    }
                }
            }

            return tree;
        }

        private static bool TryGetFileInfo(string s, out string name, out int size)
        {
            const char fileInfoSeparator = ' ';
            const int fileInfoLength = 2;
            const int fileInfoNameElem = 0;
            const int fileInfoSizeElem = 1;

            name = "";
            size = 0;

            if (s.Contains(fileInfoSeparator))
            {
                var elems = s.Split(fileInfoSeparator, StringSplitOptions.RemoveEmptyEntries);
                if ((elems.Length == fileInfoLength) && (int.TryParse(elems[fileInfoSizeElem], out size)))
                {
                    name = elems[fileInfoNameElem];
                    return true;
                }
            }
            return false;
        }
    }
}
