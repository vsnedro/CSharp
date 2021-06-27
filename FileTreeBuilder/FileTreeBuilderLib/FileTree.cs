using System.Collections.Generic;

namespace FileTreeBuilderLib
{
    public class FileTree
    {
        public DirectoryNode Root { get; } = new("");

        public abstract class TreeNodeCustom
        {
            public string Name { get; }

            protected TreeNodeCustom(string name)
            {
                Name = name;
            }
        }

        public class FileNode : TreeNodeCustom
        {
            public int Size { get; }

            public FileNode(string name, int size) : base(name)
            {
                Size = size;
            }
        }

        public class DirectoryNode : TreeNodeCustom
        {
            public List<DirectoryNode> Directories { get; } = new();
            public List<FileNode> Files { get; } = new();

            public DirectoryNode(string name) : base(name)
            {
            }
        }
    }
}
