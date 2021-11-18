using System;
using System.IO;

namespace CreateLogITpe21
{
    class Program
    {
        static void Main(string[] args)
        {
           string newDirectory = "LOGITpe21";

            CreateMyDirectory(newDirectory);
        }


        private static void CreateMyDirectory(string myDirectoryName)
        {
            string rootDirectory = @"C:\Users\opilane\samples";          
            string directoryfullPath = @$"{rootDirectory}\{myDirectoryName}";

            if (Directory.Exists(directoryfullPath))
            {
                Console.WriteLine($"Directory {myDirectoryName} already exists in {rootDirectory}.");

            }
            else
            {
                Directory.CreateDirectory(directoryfullPath);
                Console.WriteLine($"Directory {myDirectoryName} has been created.");
            }
        }
    }

}
