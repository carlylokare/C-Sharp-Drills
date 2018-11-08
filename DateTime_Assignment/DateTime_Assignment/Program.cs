using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string formattedDate = DateTime.Now.ToString("dddd, dd, MMMM yyyy HH:mm");
            Console.WriteLine(formattedDate);
            Console.ReadLine();

            Console.WriteLine("Pick a whole number to see what time it will be in that many hours from now");
            int hours = Convert.ToInt32(Console.ReadLine());
            DateTime currentTime = DateTime.Now;
            DateTime twoHoursLater = currentTime.AddHours(hours);
            Console.WriteLine(string.Format("{0} {1}", currentTime, twoHoursLater));
            Console.ReadLine();

        }
    }
}
