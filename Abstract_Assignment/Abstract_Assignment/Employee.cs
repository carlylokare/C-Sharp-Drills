﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Assignment
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
        }
}
}
