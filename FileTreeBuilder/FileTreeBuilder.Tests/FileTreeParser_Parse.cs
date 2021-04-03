using System;
using FileTreeBuilderLib;
using NUnit.Framework;

namespace FileTreeBuilder.Tests.FileTreeParser
{
    public class FileTreeParser_Parse
    {
        private FileTreeBuilderLib.FileTreeParser _fileTreeParser;
        private string[] _lines;

        [SetUp]
        public void Setup()
        {
            _fileTreeParser = new FileTreeBuilderLib.FileTreeParser();
        }

        [Test]
        public void Parse_EmptyLines_Returns0Directories()
        {
            _lines = Array.Empty<string>();
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Directories.Count;

            Assert.AreEqual(0, actual);
        }

        [Test]
        public void Parse_EmptyLines_Returns0Files()
        {
            _lines = Array.Empty<string>();
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Files.Count;

            Assert.AreEqual(0, actual);
        }

        [Test]
        public void Parse_LineIsDirectory_ReturnsDirectory()
        {
            _lines = new[] { "A" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Directories.Count;

            Assert.AreEqual(1, actual);
        }

        [Test]
        public void Parse_LineIsDirectory_ReturnsDirectoryName()
        {
            _lines = new[] { "A" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Directories[0].Name;

            Assert.AreEqual("A", actual);
        }

        [Test]
        public void Parse_LineIsDirectory_Returns0Files()
        {
            _lines = new[] { "A" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Files.Count;

            Assert.AreEqual(0, actual);
        }

        [Test]
        public void Parse_LineIsFile_Returns0Directories()
        {
            _lines = new[] { "A 1" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Directories.Count;

            Assert.AreEqual(0, actual);
        }

        [Test]
        public void Parse_LineIsFile_ReturnsFile()
        {
            _lines = new[] { "A 1" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Files.Count;

            Assert.AreEqual(1, actual);
        }

        [Test]
        public void Parse_LineIsFile_ReturnsFileName()
        {
            _lines = new[] { "A 1" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Files[0].Name;

            Assert.AreEqual("A", actual);
        }

        [Test]
        public void Parse_LineIsFile_ReturnsFileSize()
        {
            _lines = new[] { "A 1" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Files[0].Size;

            Assert.AreEqual(1, actual);
        }

        [Test]
        public void Parse_LinesWith2Directories_Returns2Directories()
        {
            _lines = new[] { "B", "A" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Directories.Count;

            Assert.AreEqual(2, actual);
        }

        [Test]
        public void Parse_LinesWith2DirectoriesWithSort_Returns1stDirectoryName()
        {
            _lines = new[] { "B", "A" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Directories[0].Name;

            Assert.AreEqual("B", actual);
        }

        [Test]
        public void Parse_LinesWith2DirectoriesWithSort_Returns2ndDirectoryName()
        {
            _lines = new[] { "B", "A" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Directories[1].Name;

            Assert.AreEqual("A", actual);
        }

        [Test]
        public void Parse_Lines2Files_Returns2Files()
        {
            _lines = new[] { "B 2", "A 1" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Files.Count;

            Assert.AreEqual(2, actual);
        }

        [Test]
        public void Parse_Lines2FilesWithSort_Returns1stFileName()
        {
            _lines = new[] { "B 2", "A 1" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Files[0].Name;

            Assert.AreEqual("B", actual);
        }

        [Test]
        public void Parse_Lines2FilesWithSort_Returns2ndFileName()
        {
            _lines = new[] { "B 2", "A 1" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Files[1].Name;

            Assert.AreEqual("A", actual);
        }

        [Test]
        public void Parse_LinesWith1DirectoryAnd2Subdirectories_Returns2Subdirectories()
        {
            _lines = new[] { "A", "A\\B", "A\\C" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Directories[0].Directories.Count;

            Assert.AreEqual(2, actual);
        }

        [Test]
        public void Parse_LinesWith1DirectoryAnd2Subdirectories_Returns1stSubdirectoryName()
        {
            _lines = new[] { "A", "A\\B", "A\\C" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Directories[0].Directories[0].Name;

            Assert.AreEqual("B", actual);
        }

        [Test]
        public void Parse_LinesWith1DirectoryAnd2Subdirectories_Returns2ndSubdirectoryName()
        {
            _lines = new[] { "A", "A\\B", "A\\C" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Directories[0].Directories[1].Name;

            Assert.AreEqual("C", actual);
        }

        [Test]
        public void Parse_LinesWith1DirectoryAnd2Subdirectories_Returns0Files()
        {
            _lines = new[] { "A", "A\\B", "A\\C" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Directories[0].Files.Count;

            Assert.AreEqual(0, actual);
        }

        [Test]
        public void Parse_LinesWith1DirectoryAnd2Files_Returns0Subdirectories()
        {
            _lines = new[] { "A", "A\\B 1", "A\\C 2" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Directories[0].Directories.Count;

            Assert.AreEqual(0, actual);
        }

        [Test]
        public void Parse_LinesWith1DirectoryAnd2Files_Returns2Files()
        {
            _lines = new[] { "A", "A\\B 1", "A\\C 2" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Directories[0].Files.Count;

            Assert.AreEqual(2, actual);
        }

        [Test]
        public void Parse_LinesWith1DirectoryAnd2Files_Returns1stFileName()
        {
            _lines = new[] { "A", "A\\B 1", "A\\C 2" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Directories[0].Files[0].Name;

            Assert.AreEqual("B", actual);
        }

        [Test]
        public void Parse_LinesWith1DirectoryAnd2Files_Returns1stFileSize()
        {
            _lines = new[] { "A", "A\\B 1", "A\\C 2" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Directories[0].Files[0].Size;

            Assert.AreEqual(1, actual);
        }

        [Test]
        public void Parse_LinesWith1DirectoryAnd2Files_Returns2ndFileName()
        {
            _lines = new[] { "A", "A\\B 1", "A\\C 2" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Directories[0].Files[1].Name;

            Assert.AreEqual("C", actual);
        }

        [Test]
        public void Parse_LinesWith1DirectoryAnd2Files_Returns2ndFileSize()
        {
            _lines = new[] { "A", "A\\B 1", "A\\C 2" };
            var tree = _fileTreeParser.Parse(_lines);
            var actual = tree.Root.Directories[0].Files[1].Size;

            Assert.AreEqual(2, actual);
        }
    }
}