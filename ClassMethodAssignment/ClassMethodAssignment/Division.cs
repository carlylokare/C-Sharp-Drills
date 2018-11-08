using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Division
    {
        public void Divide2(int number)
        {
            Console.WriteLine(number / 2);
        }
       
        public void getValues(out int x, out int y)
        {
            Console.WriteLine("Enter the first value");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value");
            y = Convert.ToInt32(Console.ReadLine());

        }

        public static void whichOne(int x)
        {
            Console.WriteLine("whichOne(int x)");
        }

        public static void whichOne(string y)
        {
            Console.WriteLine("whichOne(string y)");
        }

        
    }
}
