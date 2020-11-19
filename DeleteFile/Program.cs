using System;
using System.IO;


namespace DeleteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileDelete();
            
        }
        public static void FileDelete()
        {
            string RootPath = @"C:\Users\opilane\Samples\PLayerTwo";
            string FileName = "balls.txt";

            if (File.Exists(Path.Combine(RootPath, FileName)))
            {
                File.Delete(Path.Combine(RootPath, FileName));
            } else
            {
                Console.WriteLine("File Not Found Error 404");
            }

        }
    }
}
