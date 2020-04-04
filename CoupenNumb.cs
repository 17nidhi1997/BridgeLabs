using System;
using System.Collections.Generic;
using System.Text;

namespace Functiona
{
    class coupon
    {
        public void number()
        {
            Console.WriteLine("How many distinct coupon you want to generate:");
            int n = Convert.ToInt32(Console.ReadLine());
                
               while ( n > 0 )
                {
                Random rand = new Random();
                int random1=rand.Next(0, 25);
                int random2 = rand.Next(30, 60);
                int random3 = rand.Next(100, 1000);
                int random4 = rand.Next(1000, 2000);
                Console.WriteLine("coupon number " +n+ "=" + random4+""+random2+""+random3+""+random1);
                n = (n - 1);
}
        }
    }
}
