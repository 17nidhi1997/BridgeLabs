using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class binarySearch
    {
        public void search()
        {
            // Driver method to test above 

            int i;
            String[] arr = { "corn", "rabbit", "ide", "mango", "abc" };
            for (i = 0; i <= arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("enter the element to search");
            String x = Console.ReadLine();
            int result = binarySearch(arr, x);
            int n = arr.Length + 1;
            if (result == n)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at " + "index " + result);

            static int binarySearch(String[] arr, String x)
            {
                int l = 0, r = arr.Length - 1;
                while (l <= r)
                {
                    int m = l + (r - l) / 2;
                     int res =x.CompareTo( arr[m]);
                    // Check if x is present at mid 
                    if (res == 0)
                        return m;

                    // If x greater, ignore left half 
                   else if (res > 0)
                        l = m + 1;

                    // If x is smaller, ignore right half 
                    else
                        r = m - 1;
                }

                return -1;
            }

            
            }
        }
    }
    
