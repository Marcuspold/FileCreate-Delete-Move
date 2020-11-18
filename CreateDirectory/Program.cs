using System;
using System.IO;


namespace CreateDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatFolderOne();
            CreateFolderTwo();
        }

        public static void CreatFolderOne()
        {
            string rootPath = @"C:\Users\opilane\Samples";
            string folderName = "playerOne";
            string fullFolderPath = Path.Combine(rootPath, folderName);
            Console.WriteLine(fullFolderPath);
            if (Directory.Exists(fullFolderPath)) //checks if the folder exists
            {
                Console.WriteLine("playerOne folder already exists.");
            }else
            {
                Directory.CreateDirectory(fullFolderPath);
            }
        }

        public static void CreateFolderTwo()
        {
            string rootPath = @"C:\Users\opilane\Samples";
            string folderName = "playerTwo";
            string fullFolderPath = Path.Combine(rootPath, folderName);
            if (Directory.Exists(fullFolderPath)) 
            {
                Console.WriteLine("playerTwo folder already exists.");
            }
            else
            {
                Directory.CreateDirectory(fullFolderPath);
            }
        }
    }
}
