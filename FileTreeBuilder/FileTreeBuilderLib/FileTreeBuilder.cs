using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileTreeBuilderLib
{
    public class FileTreeBuilder
    {
        /// <summary>
        /// Build a file tree based on a file with full paths
        /// </summary>
        /// <param name="fileName">Input file name</param>
        /// <returns>Returns a tree of files</returns>
        public static FileTree Build(string fileName)
        {
            var parser = new FileTreeParser();
            var tree = parser.Parse(fileName);

            var sorter = new FileTreeSorter();
            sorter.Sort(tree);

            return tree;
        }

        /// <summary>
        /// Build a file tree based on a file with full paths and write it to a file
        /// </summary>
        /// <param name="inFilename">Input file name</param>
        /// <param name="outFilename">Output file name</param>
        public static void BuildAndWrite(string inFilename, string outFilename)
        {
            var tree = Build(inFilename);
            var reporter = new FileTreeReporter();
            reporter.ExportToFile(tree, outFilename);
        }
    }
}
