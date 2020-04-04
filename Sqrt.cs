using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class newton
    {
        public void square()
        {
            
            Console.WriteLine("Enter the value");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value");
            int A = Convert.ToInt32(Console.ReadLine());

            double nthRootValue = nthRoot(A, N);
            Console.WriteLine("Nth root is " + Math.Round(nthRootValue * 1000.0) / 1000.0);
            static double nthRoot(int A, int N)
            {
                Random rand = new Random();
               
                double xPre = rand.Next(10); 
                double eps = 0.001;
                double delX = 2147483647;
                double xK = 0.0;
                while (delX > eps)
                {
                    xK = ((N - 1.0) * xPre +
                    (double)A / Math.Pow(xPre, N - 1)) / (double)N;
                    delX = Math.Abs(xK - xPre);
                    xPre = xK;
                }

                return xK;
            }
   
        }

    }
}


