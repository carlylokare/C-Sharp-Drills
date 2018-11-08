using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While.DoWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //WHILE LOOP
            Console.WriteLine("Guess a color?");
            string color = Console.ReadLine();
            bool isGuessed = color == "blue";

            while (!isGuessed)
            {
                switch (color)
                {
                    case "red":
                        Console.WriteLine("You guessed Red. Try again");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("You guessed Green. Ty again");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "purple":
                        Console.WriteLine("You guessed Purple. Try again");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "blue":
                        Console.WriteLine("You guessed Blue. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                }
            }

            Console.ReadLine();

            //DO WHILE LOOP

            Console.WriteLine("Guess a color?");
            string colorFav = Console.ReadLine();
            bool isGuessedColor = colorFav == "blue";

            do
            {
                switch (color)
                {
                    case "red":
                        Console.WriteLine("You guessed Red. Try again");
                        Console.WriteLine("Guess a color?");
                        colorFav = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("You guessed Green. Ty again");
                        Console.WriteLine("Guess a color?");
                        colorFav = Console.ReadLine();
                        break;
                    case "purple":
                        Console.WriteLine("You guessed Purple. Try again");
                        Console.WriteLine("Guess a color?");
                        colorFav = Console.ReadLine();
                        break;
                    case "blue":
                        Console.WriteLine("You guessed Blue. That is correct!");
                        isGuessedColor = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a color?");
                        colorFav = Console.ReadLine();
                        break;
                }
            }

            while (!isGuessed);

            Console.ReadLine();
        }
    }
}
