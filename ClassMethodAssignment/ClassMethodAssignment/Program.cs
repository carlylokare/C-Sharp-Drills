using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Pick a whole number to divide by 2");
            int number = Convert.ToInt32(Console.ReadLine());
            Division example = new Division();
            example.Divide2(number);
            Console.ReadKey();


            Division example2 = new Division();
            int a, b;
            example2.getValues(out a, out b);
            Console.WriteLine("After method call, value of a: {0}", a);
            Console.WriteLine("After method call, value of b: {0}", b);
            Console.ReadKey();

            //Division example3 = new Division();
            Division.whichOne("test");
            Console.ReadLine();




        }
    }
}
