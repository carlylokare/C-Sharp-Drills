using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        try
        {
            List<int> numberList = new List<int>() { 20, 30, 40, 50, 60, 70 };
            Console.WriteLine("Pick any number to divide each number in the list by");
            string numberOne = Console.ReadLine();
            int numberDivide = Convert.ToInt32(numberOne);


            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine(numberList[i] / numberDivide);

            }
            Console.ReadLine();
        }

        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number.");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }

    }

}
