using System;
using System.Collections.Generic;
using System.Text;

namespace Functiona
{
    class leapYear
    {
        public void leap()
        {
            Console.WriteLine("Enter the year");
            int year=Convert.ToInt32(Console.ReadLine());
            if(((year % 4) == 0) || ((year % 400) == 0))
            {
                Console.WriteLine("year is leap year");
            }
            else if((year % 100) != 0)
            {
                Console.WriteLine("year is not a leap year");
            }
        }
    }

}
