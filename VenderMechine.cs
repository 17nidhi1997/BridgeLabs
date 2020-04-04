using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class venderMechain
    {

        public void money()
        {
            Console.WriteLine("enter the amount");
            int amount = Convert.ToInt32(Console.ReadLine());

            int[] notes = new int[] { 2000, 500, 200, 100 ,50 ,20 ,10 ,5 ,2 ,1 };
                int[] noteCounter = new int[9];

                
                for (int i = 0; i < 9; i++)
                {
                    if (amount >= notes[i])
                    {
                        noteCounter[i] = amount / notes[i];
                        amount = amount - noteCounter[i] * notes[i];
                    }
               
              
                }

                 
                Console.WriteLine("Currency Count ->");
                for (int i = 0; i < 9; i++)
                {
                    if (noteCounter[i] != 0)
                    {
                        Console.WriteLine(notes[i] + " : "
                            + noteCounter[i]);
                    }
                }
            }

           
               


        }
    }


