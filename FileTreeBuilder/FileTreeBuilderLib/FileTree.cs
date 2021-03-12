using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTreeBuilderLib
{
    public class FileTree
    {
        public DirectoryNode Root = new("");

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
            public List<DirectoryNode> Directories = new();
            public List<FileNode> Files = new();

            public DirectoryNode(string name) : base(name)
            {
            }
        }
    }
}
