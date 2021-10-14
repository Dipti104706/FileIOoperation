using FileIOoperation.FileIO;
using System;

namespace FileIOoperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File IO Operations");
            string path = @"H:\visualstudio\FileIOoperation\FileIOoperation\FileIO\Sample.txt";
            FileReadWriteOperation file = new FileReadWriteOperation();
            file.FilExists(path);
            file.ReadAllTextInFile();
            Console.ReadLine();
        }
    }
}
