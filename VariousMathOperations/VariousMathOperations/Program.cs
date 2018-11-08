using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariousMathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takes an input from the user and multiplies it by 50.
            Console.WriteLine("Please type a number you would like to multiply by 50");
            string numberFirst = Console.ReadLine();
            int firstNumber = Convert.ToInt32(numberFirst);
            int totalFirst = 50 * firstNumber;
            Console.WriteLine(totalFirst);
            Console.ReadLine();

            //Takes an input from the user and adds 25 to it.
            Console.WriteLine("Please type a number you would like to add by 25");
            string numberSecond = Console.ReadLine();
            int secondNumber = Convert.ToInt32(numberSecond);
            int totalSecond = 25 + secondNumber;
            Console.WriteLine(totalSecond);
            Console.ReadLine();

            //Takes an input from the user and divides it by 12.5
            Console.WriteLine("Please type a number you would like to divide by 12.5");
            string numberThird = Console.ReadLine();
            int thirdNumber = Convert.ToInt32(numberThird);
            double totalThird = 12.5 / thirdNumber;
            Console.WriteLine(totalThird);
            Console.ReadLine();

            //Takes an input from the user and checks if it is greater than 50 and returns true or false.
            Console.WriteLine("Please type a number to check if it is greater than 50");
            string numberFourth = Console.ReadLine();
            int fourthNumber = Convert.ToInt32(numberFourth);
            bool truthyOrFalsey = fourthNumber > 50;
            Console.WriteLine(truthyOrFalsey.ToString());
            Console.ReadLine();


            //Takes an input from the user and divides by 7 and prints the remainder
            Console.WriteLine("Please type a number to divide by 7 and it will print the remainder");
            string numberFifth = Console.ReadLine();
            int fifthNumber = Convert.ToInt32(numberFifth);
            int whatsLeftOver = 7 % fifthNumber;
            Console.WriteLine(whatsLeftOver);
            Console.ReadLine();

        }
    }
}
