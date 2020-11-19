using System;
using System.IO;

namespace CreateFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Morning Soldier!");
            Console.WriteLine("Emter File Name Now!!!!:");
            string UserInput = Console.ReadLine();
            CreateUserFile(UserInput);
        }
        public static void CreateFiles()
        {
            string RootPath = @"C:\Users\opilane\Samples";
            string FileName = @"Ball.txt";
            File.Create(Path.Combine(RootPath, FileName));
        }
        public static void CreateUserFile(string FileName)
        {
            string RootPath = @"C:\Users\opilane\Samples\PlayerTwo";
            File.Create(Path.Combine(RootPath, FileName));
        }
        public static void CreateFileWithExtension(string FileName)
        {
            string RootPath = @"C:\Users\opilane\Samples\PLayerTwo";
            string FullFileName = $"{FileName}.txt";
            File.Create(Path.Combine(RootPath, FullFileName));


        }


    }
}
