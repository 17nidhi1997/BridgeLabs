using System;
using System.Collections.Generic;
using System.Text;

namespace Functiona
{
    class coinToss
    {
        public void coins()
        {
            float head = 0;
            float tail = 0;
            Console.WriteLine("Enter the number of flip");
            int flip = Convert.ToInt32(Console.ReadLine());
            int flips = flip;
            while (flips > 0)
            {
                Random random = new Random();
                if (random.Next() % 2 == 0) 
                {
                    tail = tail + 1;
                }
                else
                {
                    head = head + 1;
                }
                flips--;
            }
            Console.WriteLine("tails:"+tail);
            Console.WriteLine("head:" +head);
            Console.WriteLine("persentage of heads:" +((head / flip) * 100));
            Console.WriteLine("persentage of tails:" + ((tail / flip) * 100));
        }
    }
}
