using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace Algorithm
{
    class perm
    {
        public void per()
        {
            ArrayList al = new ArrayList();
            ArrayList ar = new ArrayList();

            //recurion           
            String str = "ABC";
            int n = str.Length;
            permute(str, 0, n - 1);
            Console.WriteLine("---------");
            //iteration
            String s = "ABC";
            printPermutn(s, "");
            Console.WriteLine("\nE) to check if the arrays returned by two string functions above are equal");
            Console.WriteLine();
            Console.WriteLine(ar.Equals(al));
          
            void permute(String str, int l, int r)
            {
                if (l == r)
                {
                    Console.WriteLine(str);
                    ar.Add("str");
                   
                }
                else
                {
                    for (int i = l; i <= r; i++)
                    {
                        str = swap(str, l, i);
                        permute(str, l + 1, r);
                        str = swap(str, l, i);
                    }
                }
            }

            
            static String swap(String a,int i, int j)
            {
                char temp;
                char[] charArray = a.ToCharArray();
                temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
                string s = new string(charArray);
                return s;
            }

            //iteration
             string printPermutn(String str, String ans)
            {

                if (str.Length == 0)
                {
                   Console.WriteLine(ans + " ");
                    al.Add(str);
                    return null;
                }
                for (int i = 0; i < str.Length; i++)
                {
                    char ch = str[i];
                    String ros = str.Substring(0, i) + str.Substring(i + 1);
                    printPermutn(ros, ans + ch);
                }
                return null;
            }
            

        }
    }
    }

