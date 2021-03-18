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

        public FileTree Parse(string[] lines, bool sort = true)
        {
            var tree = new FileTree();

            if (sort)
            {
                Array.Sort(lines);
            }

            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line)) continue;

                var node = tree.Root;
                var elems = line.Split('\\', StringSplitOptions.RemoveEmptyEntries);
                foreach (var elem in elems)
                {
                    if (TryGetFileInfo(elem, out string name, out int size))
                    {
                        var file = new FileTree.FileNode(name, size);
                        node.Files.Add(file);
                    }
                    else
                    {
                        var directory = node.Directories.Find(x => x.Name.Equals(elem));
                        if (directory == null)
                        {
                            directory = new FileTree.DirectoryNode(elem);
                            node.Directories.Add(directory);
                        }
                        node = directory;
                    }
                }
            }

            return tree;
        }

        private bool TryGetFileInfo(string s, out string name, out int size)
        {
            const int fileInfoLength = 2;
            name = "";
            size = 0;

            if (s.Contains(' '))
            {
                var elems = s.Split(' ');
                if ((elems.Length == fileInfoLength) && (int.TryParse(elems[1], out size)))
                {
                    name = elems[0];
                    return true;
                }
            }
            return false;
        }
    }
}
