using System;
using System.Collections.Generic;

namespace FileTreeBuilderLib
{
    public class FileTreeSorter
    {
        private readonly DirectoryComparerByName _directoryComparer = new();
        private readonly FileComparerBySizeAndName _fileComparer = new();

        public void Sort(FileTree tree)
        {
            InternalSort(tree.Root);
        }

        private void InternalSort(FileTree.DirectoryNode node)
        {
            if (node == null)
                throw new ArgumentNullException(nameof(node));

            // 1. Sort directory nodes
            node.Directories.Sort(_directoryComparer);

            // 2. Sort file nodes
            node.Files.Sort(_fileComparer);

            // 3. Sort recursively for all child directory nodes
            foreach (var directory in node.Directories)
            {
                InternalSort(directory);
            }
        }

        private class DirectoryComparerByName : IComparer<FileTree.DirectoryNode>
        {
            public int Compare(FileTree.DirectoryNode x, FileTree.DirectoryNode y)
            {
                if (x == null)
                {
                    return y == null ? 0 : -1;
                }
                else
                {
                    return y == null ? 1 : string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
                }
            }
        }

        private class FileComparerBySizeAndName : IComparer<FileTree.FileNode>
        {
            public int Compare(FileTree.FileNode x, FileTree.FileNode y)
            {
                if (x == null)
                {
                    return y == null ? 0 : -1;
                }
                else
                {
                    if (y == null)
                    {
                        return 1;
                    }
                    else
                    {
                        return x.Size == y.Size ?
                            string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase) :
                            y.Size.CompareTo(x.Size);
                    }
                }
            }
        }
    }
}
