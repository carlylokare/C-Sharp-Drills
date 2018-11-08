using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Assignment
{
    class Program
    {
        public enum Day { Sunday, Money, Tuesday, Wednesday, Thursday, Friday, Saturday};

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What day of the week is it?");
                string currentDay = Console.ReadLine();
                Day day = (Day)Enum.Parse(typeof(Day), currentDay, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week", ex);
            }
            finally
            {
                Console.ReadLine();
            }
           
        }
    }
}
