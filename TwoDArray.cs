using System;
using System.Collections.Generic;
using System.Text;

namespace Functiona
{
    class TwoDArray
    {
        public void array2D()
        {
                int rows, cols;
                Console.WriteLine("Enter the number of rows and colums");
                rows = Convert.ToInt32(Console.ReadLine());
                cols = Convert.ToInt32(Console.ReadLine());
                double[,] arr = new double[rows, cols];
                Console.WriteLine("Enter the elements of double array");
                arr = FetchDouble2DArray(arr);
                Print2DArray(arr);

            }
        public static int[,] FetchInt2DArray(int[,] array)
        {
            int rows = 0, cols = 0, counter = 0;
            for (rows = 0; rows < array.GetLength(0); rows++)
            {
                for (cols = 0; cols < array.GetLength(1); cols++)
                {
                    counter++;
                    Console.WriteLine("Enter the element {0}", counter);
                    array[rows, cols] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return array;
        }
        public static bool[,] FetchBool2DArray(bool[,] array)
        {
            int rows = 0, cols = 0, counter = 0;
            for (; rows < array.GetLength(0); rows++)
            {
                for (cols = 0; cols < array.GetLength(1); cols++)
                {
                    counter++;
                    Console.WriteLine("Enter the element {0}", counter);
                    array[rows, cols] = Convert.ToBoolean(Console.ReadLine());
                }
            }
            return array;
        }
        public static double[,] FetchDouble2DArray(double[,] array)
        {
            int rows = 0, cols = 0, counter = 0;
            for (rows=0; rows < array.GetLength(0); rows++)
            {
                for (cols = 0; cols < array.GetLength(1); cols++)
                {
                    counter++;
                    Console.WriteLine("Enter the element {0}", counter);
                    array[rows, cols] = Convert.ToDouble(Console.ReadLine());
                }
            }
            return array;
        }

public static void Print2DArray<Template>(Template[,] array)
        {
            int rows = 0, cols = 0;
            for (rows = 0; rows < array.GetLength(0); rows++)
            {
                for (cols = 0; cols < array.GetLength(1); cols++)
                {
                    Console.Write("{0} ", array[rows,cols]);

                }
                Console.WriteLine();
            }
        }
    }
}
  

