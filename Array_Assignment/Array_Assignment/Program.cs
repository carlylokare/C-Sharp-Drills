using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
  
        //list of strings
        List<string> stringList = new List<string>();
        stringList.Add("Red");
        stringList.Add("Green");
        stringList.Add("Purple");
        stringList.Add("Blue");
        stringList.Add("Yellow");

        Console.WriteLine("Pick an number from 0-4 and it will display the string at that index of the list");
        string lineind = Console.ReadLine();
        int lineindex = Convert.ToInt32(lineind);
        Console.WriteLine(stringList[lineindex]);
        Console.ReadLine();

        //an array of integers
        int[] numArray = { 5, 2, 10, 200, 5000, 600, 2300 };
        Console.WriteLine("Pick an number from 0-6 and it will display the integer at that index of the array");
        string numberind = Console.ReadLine();
        int numindex = Convert.ToInt32(numberind);
        Console.WriteLine(numArray[numindex]);
        Console.ReadLine();

        //an array of strings
        string[] nameArray = new string[] { "Carly", "Cole", "John", "Sarah", "Nicole" };
        Console.WriteLine("Pick an number from 0-4 and it will display the string at that index of the array");
        string stringind = Console.ReadLine();
        int stringindex = Convert.ToInt32(stringind);
        Console.WriteLine(nameArray[stringindex]);
        Console.ReadLine();

    }
}


