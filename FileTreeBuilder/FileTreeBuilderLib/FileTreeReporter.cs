using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTreeBuilderLib
{
    public class FileTreeReporter
    {
        public async Task ExportToFileAsync(FileTree tree, string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            await using (var writer = new StreamWriter(fileName))
            {
                await ExportToFileInternalAsync(tree.Root, writer);
            }
        }

        private async Task ExportToFileInternalAsync(FileTree.DirectoryNode node, TextWriter writer, string indent = "")
        {
            // 1. Output directory nodes
            foreach (var directory in node.Directories)
            {
                await writer.WriteLineAsync(indent + $"{directory.Name}\\");
                // 2. Output recursively all child directory nodes
                await ExportToFileInternalAsync(directory, writer, indent + "\t");
            }
            
            // 3. Output file nodes
            foreach (var file in node.Files)
            {
                await writer.WriteLineAsync(indent + $"{file.Name} {file.Size}");
            }
        }
    }
}
