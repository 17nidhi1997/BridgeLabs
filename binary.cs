using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class TOBinary
    {
        public void bin()
        {
            block(71307);
            block(1213);
            block(29);
            block(100);
            static void block(long x)
             {
            List<int> v = new List<int>();
            Console.Write("Blocks for " + x + " : ");

            while (x > 0)
            {
                v.Add((int)x % 2);
                x = x / 2;
            }

           
            for (int i = 0; i < v.Count; i++)
            {
                if (v[i] == 1)
                {
                    Console.Write(i);

                    if (i != v.Count - 1)
                        Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
        
           
        }
    }

}

