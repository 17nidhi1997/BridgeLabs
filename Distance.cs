using System;
using System.Collections.Generic;
using System.Text;

namespace Functiona
{
    class Distance
    {
        public void dist()
        {
            Console.WriteLine("Enter the point a ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the point b ");
            double b = Convert.ToDouble(Console.ReadLine());
            {
                double distance = Math.Sqrt(Math.Pow((a-b), 2) + Math.Pow((b-a), 2));
                Console.WriteLine(distance);
            }
        }
    }
}
