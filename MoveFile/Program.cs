using System;
using System.IO;

namespace MoveFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Soldier!");
            MoveFile()
        }
        public static void MoveFile()
        {
            string SourceDirectory = @"C:\Users\opilane\Samples\PlayerOne";
            string DestinationPath = @"C:\Users\opilane\Samples\PlayerTwo";
            string FileName = "Ball.Txt";


            File.Move(Path.Combine(SourceDirectory, FileName), Path.Combine(DestinationPath, FileName));
        }
    }
}
