using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //1.Create a one-dimensioanl Array of stings. ask for input. create an array and loop through the array
        string[] colors = new string[6];
        Console.WriteLine("Please enter 5 colors");
        for (int i = 0; i < colors.Length; i++)
        {
            colors[i] = Console.ReadLine();
            Console.WriteLine(colors[i]);
        }
        Console.ReadLine();

        //2.Create an infinite loop
        int months = 12;
        for (int i = 0; i != months; i += 5)
        {
            Console.WriteLine($"Months Counted: {i}");
            Console.WriteLine($"Months Left: {months - i}");
        }


        //3.Fix the infinte loop
        int months1 = 12;
        for (int i = 0; i <= months1; i++)
        {
            Console.WriteLine($"Months Counted: {i}");
            Console.WriteLine($"Months Left: {months1 - i}");
        }


        //4.Create a loop using the "<" operator
        int[] temperatures = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        for (int i = 0; i < temperatures.Length; i++)
        {
            Console.WriteLine(temperatures[i]);
        }
        Console.ReadLine();

        //5.Create a loop using "<=" operator
        int[] ages = { 21, 45, 18, 36, 29, 34 };

        for (int j = 0; j <= ages.Length - 1; j++)
        {
            Console.WriteLine(ages[j]);
        }
        Console.ReadLine();


        //6,7,8. Creat list of strings. Create a loop that iterates through the list and displays the index of the array that contains matching text on screen.
        List<string> names2 = new List<string>() { "Lauren", "Carol", "Nicole", "Jackie", "Joe" };
        Console.WriteLine("Pick a name to see which index it is located at in the list");
        string _name = Console.ReadLine();

        if (!names2.Contains(_name))
        {
            Console.WriteLine("This name does not exist");
        }
        else
        {
            foreach (string name in names2)
            {
                if (_name == name)
                {
                    Console.WriteLine(names2.IndexOf(name));
                }
            }
        }
        Console.ReadLine();


        List<string> cities = new List<string>() { "London", "Paris", "Amsterdam", "Tokyo", "Zurich", "London" };
        Console.WriteLine("Pick a city to see which index it is located at in the list");
        string _city = Console.ReadLine();


        //9.10.Create a loop that iterates through a list and displays the multiple indices of the duplicated string
        int index = 0;
        if (!cities.Contains(_city))
        {
            Console.WriteLine("This city does not exist");
        }
        else
        {
            for (int i = 0; i < cities.Count; i++)
            {
                index = i;
                if (_city == cities[i])
                {
                    Console.WriteLine(cities[i] + " at index of " + index);
                }
            }
            Console.ReadLine();
        }

        //11. Create list of strings that has 2 identical strings. Create a foreach loop that evaluates each item and displays a message showing the string and if it's duplicated.
        List<string> sports = new List<string>() { "Soccer", "Basketball", "Softball", "", "Football", "Soccer", "Baseball" };
        Console.WriteLine("Pick a sport to see if it in the list, if not it will be added to the list");
        string _sport = Console.ReadLine();

        if (!sports.Contains(_sport))
        {
            sports.Add(_sport);
            Console.WriteLine("This sport does not exist, but it will get added to the list");
        }
        else
        {
            foreach (string sport in sports)
            {
                if (_sport == sport)
                {
                    Console.WriteLine("This sport aleady exists");
                }
            }
        }
        Console.ReadLine();

    }
}

