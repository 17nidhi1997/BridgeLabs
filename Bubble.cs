using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class bubble
    {
        public void bubblee()
        {
            
                 int num, i, j, temp;
                 Console.WriteLine("Enter the number of integers to sort:");
                 num = Convert.ToInt32(Console.ReadLine());
                 int[] array = new int[num];

            Console.WriteLine("Enter " + num + " integers: ");
            for (i = 0; i < num; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
               
            }
                for (i = 0; i < (num - 1); i++)
                {
                    for (j = 0; j < num - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("Sorted list of integers:");

                for (i = 0; i < num; i++)
                    Console.WriteLine(array[i]);
            }
        }

    }
    

