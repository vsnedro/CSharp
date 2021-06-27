using System;

namespace FileTreeBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileTreeBuilderLib.FileTreeBuilder.BuildAndWrite("D:\\Temp\\files.txt", "D:\\Temp\\tree.txt");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}