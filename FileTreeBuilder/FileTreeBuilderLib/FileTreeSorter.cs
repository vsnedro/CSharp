using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTreeBuilderLib
{
    public class FileTreeSorter
    {
        private readonly DirectoryComparer _directoryComparer = new DirectoryComparer();
        private readonly FileComparer _fileComparer = new FileComparer();

        public void Sort(FileTree tree)
        {
            SortInternal(tree.Root);
        }

        private void SortInternal(FileTree.DirectoryNode node)
        {
            // 1. Sort directory nodes
            node.Directories.Sort(_directoryComparer);

            // 2. Sort file nodes
            node.Files.Sort(_fileComparer);

            // 3. Sort recursively for all child directory nodes
            foreach (var directory in node.Directories)
            {
                SortInternal(directory);
            }
        }

        private class DirectoryComparer : IComparer<FileTree.DirectoryNode>
        {
            public int Compare(FileTree.DirectoryNode x, FileTree.DirectoryNode y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }

        private class FileComparer : IComparer<FileTree.FileNode>
        {
            public int Compare(FileTree.FileNode x, FileTree.FileNode y)
            {
                return y.Size.CompareTo(x.Size);
            }
        }
    }
}
