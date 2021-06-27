using System;
using System.IO;

namespace FileTreeBuilderLib
{
    public class FileTreeReporter
    {
        public void ExportToFile(FileTree tree, string fileName)
        {
            if (tree == null)
                throw new ArgumentNullException(nameof(tree));

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (var writer = new StreamWriter(fileName))
            {
                InternalExportToFile(tree.Root, writer);
            }
        }

        private void InternalExportToFile(FileTree.DirectoryNode node, TextWriter writer, string indent = "")
        {
            if (node == null)
                throw new ArgumentNullException(nameof(node));
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));

            // 1. Output directory nodes
            foreach (var directory in node.Directories)
            {
                writer.WriteLine(indent + $"{directory.Name}\\");
                // 2. Output recursively all child directory nodes
                InternalExportToFile(directory, writer, indent + "\t");
            }
            
            // 3. Output file nodes
            foreach (var file in node.Files)
            {
                writer.WriteLine(indent + $"{file.Name} {file.Size}");
            }
        }
    }
}
