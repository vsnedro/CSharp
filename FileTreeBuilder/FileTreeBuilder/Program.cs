using System;
using FileTreeBuilderLib;

namespace FileTreeBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var treeBuilder = new FileTreeBuilderLib.FileTreeBuilder();
            var treeTask = treeBuilder.BuildAsync("D:\\Temp\\files.txt");
            var reporter = new FileTreeReporter();
            reporter.ExportToFileAsync(treeTask.Result, "D:\\Temp\\tree.txt");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
