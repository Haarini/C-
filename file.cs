using System;
using System.IO;

namespace FileHandlingArticleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if(File.Exists("test.txt"))
            {
                string content = File.ReadAllText("test.txt");
                Console.WriteLine("Current content of file:");
                Console.WriteLine(content);
            }
            Console.WriteLine("Please enter new content for the file:");
            string newContent = Console.ReadLine();
            File.WriteAllText("test.txt", newContent);
        }
    }
}