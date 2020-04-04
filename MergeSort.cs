using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class MergeSort
    {
        public void merge()
        {
            String[] array = { "John", "Anthony", "Angelina", "George", "Victor", "Joe", "Jackson" };
            String[] sortedArray = mergeSort(array);
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine(sortedArray[i] + " ");
            }



            static String[] mergeSort(String[] list)
            {
                String[] sorted = new String[list.Length];
                if (list.Length == 1)
                {
                    sorted = list;
                }
                else
                {
                    int mid = list.Length / 2;
                    String[] left = null;
                    String[] right = null;
                    if ((list.Length % 2) == 0)
                    {
                        left = new String[list.Length / 2];
                        right = new String[list.Length / 2];
                    }
                    else
                    {
                        left = new String[list.Length / 2];
                        right = new String[(list.Length / 2) + 1];
                    }
                    int x = 0;
                    int y = 0;
                    for (; x < mid; x++)
                    {
                        left[x] = list[x];
                    }
                    for (; x < list.Length; x++)
                    {
                        right[y++] = list[x];
                    }
                    left = mergeSort(left);
                    right = mergeSort(right);
                    sorted = mergeArray(left, right);
                }

                return sorted;
            }

            static String[] mergeArray(String[] left, String[] right)
            {
                String[] merged = new String[left.Length + right.Length];
                int lIndex = 0;
                int rIndex = 0;
                int mIndex = 0;
                int comp = 0;
                while (lIndex < left.Length || rIndex < right.Length)
                {
                    if (lIndex == left.Length)
                    {
                        merged[mIndex++] = right[rIndex++];
                    }
                    else if (rIndex == right.Length)
                    {
                        merged[mIndex++] = left[lIndex++];
                    }
                    else
                    {
                        comp = left[lIndex].CompareTo(right[rIndex]);
                        if (comp > 0)
                        {
                            merged[mIndex++] = right[rIndex++];
                        }
                        else if (comp < 0)
                        {
                            merged[mIndex++] = left[lIndex++];
                        }
                        else
                        {
                            merged[mIndex++] = left[lIndex++];
                        }
                    }
                }
                return merged;
            }


        }
    }
}
