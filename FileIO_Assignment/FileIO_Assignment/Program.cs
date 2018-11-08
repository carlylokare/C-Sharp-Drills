using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a whole number to be logged into a text file.");
            string text = Console.ReadLine();
            File.WriteAllText("C:\\Users\\Carly Lokare\\Documents\\Log\\fileio.txt", text);
            string fileRead = File.ReadAllText("C:\\Users\\Carly Lokare\\Documents\\Log\\fileio.txt");
            Console.WriteLine("Value contained in file " + " " + fileRead );
            Console.ReadLine();

        }
    }
}
