using System;
using System.Collections.Generic;
using System.Text;

namespace Functiona
{
    class Replace
    {

        public void replace()
        {
            string word = "Hello user , How are you";
            Console.WriteLine("Enter ur name");
            string name = Console.ReadLine();
            if (name.Length >= 3)
            {
                string words = word.Replace("user", name);
                Console.WriteLine(words);
            }
            else
            {
                Console.WriteLine("Enter the name min of 3 chacter");
            }
        }



    }
}
