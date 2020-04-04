using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class MontlyPayment
    {
        public void cash()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the princpal ammount lone");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the no of years");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the rate of intrest");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Payment(p, y, r));
            static double Payment(double p,double y, double r)
            {
                double n = (12 * y);
                double R = (r / (12 * 100));
                return ((p*R)/(1-Math.Pow((1-R),(-n))));
            }


        }
    }
}
