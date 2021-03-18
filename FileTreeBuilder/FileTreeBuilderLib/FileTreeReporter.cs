using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileTreeBuilderLib
{
    public class FileTreeReporter
    {
        public void ExportToFile(FileTree tree, string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (var writer = new StreamWriter(fileName))
            {
                ExportToFileInternal(tree.Root, writer);
            }
        }

        private void ExportToFileInternal(FileTree.DirectoryNode node, TextWriter writer, string indent = "")
        {
            // 1. Output directory nodes
            foreach (var directory in node.Directories)
            {
                writer.WriteLine(indent + $"{directory.Name}\\");
                // 2. Output recursively all child directory nodes
                ExportToFileInternal(directory, writer, indent + "\t");
            }
            
            // 3. Output file nodes
            foreach (var file in node.Files)
            {
                writer.WriteLine(indent + $"{file.Name} {file.Size}");
            }
        }
    }
}
