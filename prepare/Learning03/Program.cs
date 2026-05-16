using System;
using System.Security.Cryptography;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");   

        string filename = "myfile.txt";
        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("test");
        }

        writeJoke(filename);
        readJoke(filename);

        static void writeJoke(string filename)
        {
            using(StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine("insert joke here");
            }
        }
        static void readJoke(string filename)
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

        }
    }
}