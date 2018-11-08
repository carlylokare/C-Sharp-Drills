using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            string animal = "dog";
            string species = "poodle";
            string color = "white";

            string concatenate = "I have one " + animal + " and she is a " + species + " with " + color + " fur.";
            Console.WriteLine(concatenate);
            Console.ReadLine();

            animal = animal.ToUpper();
            Console.WriteLine(animal);
            Console.ReadLine();

            StringBuilder builder = new StringBuilder();
            builder.Append("My name is Carly.");
            builder.Append(" I am enrolled in the C# bootcamp.");
            builder.Append(" I am really enjoying learning how to pogram.");
            builder.Append(" My favorite course so far is SQL.");
            builder.Append(" My favorite projects were building the pizza website and the SQL database where we had to make several queries to grab specfic data from the tables.");
            builder.Append("I am excited to dive into the next courses this progam offers.");

            Console.WriteLine(builder);
            Console.ReadLine();

        }
    }
}
