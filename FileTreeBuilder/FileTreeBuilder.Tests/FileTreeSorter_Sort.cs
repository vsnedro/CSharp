using System;
using FileTreeBuilderLib;
using NUnit.Framework;

namespace FileTreeBuilder.Tests.FileTreeSorter
{
    public class FileTreeSorter_Sort
    {
        private FileTreeBuilderLib.FileTreeSorter _fileTreeSorter;
        private FileTree _tree;

        [SetUp]
        public void Setup()
        {
            _fileTreeSorter = new FileTreeBuilderLib.FileTreeSorter();
            _tree = new FileTree();
        }

        [Test]
        public void Sort_TreeWith2Directories_Returns1stDirectoryName()
        {
            _tree.Root.Directories.Add(new FileTree.DirectoryNode("B"));
            _tree.Root.Directories.Add(new FileTree.DirectoryNode("A"));
            _fileTreeSorter.Sort(_tree);
            var actual = _tree.Root.Directories[0].Name;

            Assert.AreEqual("A", actual);
        }

        [Test]
        public void Sort_TreeWith2Directories_Returns2ndDirectoryName()
        {
            _tree.Root.Directories.Add(new FileTree.DirectoryNode("B"));
            _tree.Root.Directories.Add(new FileTree.DirectoryNode("A"));
            _fileTreeSorter.Sort(_tree);
            var actual = _tree.Root.Directories[1].Name;

            Assert.AreEqual("B", actual);
        }

        [Test]
        public void Sort_TreeWith2Files_Returns1stFileName()
        {
            _tree.Root.Files.Add(new FileTree.FileNode("A", 1));
            _tree.Root.Files.Add(new FileTree.FileNode("B", 2));
            _fileTreeSorter.Sort(_tree);
            var actual = _tree.Root.Files[0].Name;

            Assert.AreEqual("B", actual);
        }

        [Test]
        public void Sort_TreeWith2Files_Returns2ndFileName()
        {
            _tree.Root.Files.Add(new FileTree.FileNode("A", 1));
            _tree.Root.Files.Add(new FileTree.FileNode("B", 2));
            _fileTreeSorter.Sort(_tree);
            var actual = _tree.Root.Files[1].Name;

            Assert.AreEqual("A", actual);
        }
    }
}
