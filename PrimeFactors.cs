using System;
using System.Collections.Generic;
using System.Text;

namespace Functiona
{
    class factor
    {
        public void primes()
        {
            Console.WriteLine(" enter the number ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            while(i != 1)
            {
                if((num % i) == 0)
                {

                    while((num % i) == 0)
                    {
                        Console.WriteLine(i);
                        num = (num / i);
                    }
                }
                i = (i + 1);
            }
        }
    }
}
