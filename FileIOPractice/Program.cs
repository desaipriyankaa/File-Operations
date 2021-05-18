using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileIOPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"F:\PProject\Advanced\File IO\Start\Employee.txt";
            List<string> lines = File.ReadAllLines(filepath).ToList();

            foreach(var line in lines)
            {

                Console.WriteLine(line);
            }
        }
    }
}
