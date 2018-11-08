using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            int pgNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please anser true or false.");
            string needHelp = Console.ReadLine();
            bool neededHelp = Convert.ToBoolean(needHelp);
            Console.WriteLine("Where there any positive experiences you'd like to share? Please give Specifics.");
            string myExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string myFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hoursStudying = Convert.ToInt32(hoursStudied);
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
