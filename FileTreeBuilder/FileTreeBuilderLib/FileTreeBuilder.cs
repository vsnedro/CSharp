using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTreeBuilderLib
{
    public class FileTreeBuilder
    {
        public async Task<FileTree> BuildAsync(string fileName)
        {
            var parser = new FileTreeParser();
            var tree = await parser.ParseAsync(fileName);

            var sorter = new FileTreeSorter();
            sorter.Sort(tree);

            return tree;
        }
    }
}
