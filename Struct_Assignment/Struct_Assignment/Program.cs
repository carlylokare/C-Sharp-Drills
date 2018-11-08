using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    public struct Number
    {
        public decimal x;

        public Number(decimal p1)
        {
            x = p1;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Number number1;
            number1.x = 1.0M;

            Console.WriteLine(number1.x);
            Console.ReadKey();
        }
    }
}
