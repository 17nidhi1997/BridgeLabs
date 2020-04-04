using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Algorithm
{
    class regex
    {
        public void ca()
        {
			string output,s1,s2,s3,s4;
			
		String str = "Hello <<name>>, We have your full name as <<full name>> in our system."
					+ "Your contact number is 91-xxxxxxxxxx. Please,let us know in case of any clarification."
					+ "Thank you BridgeLabz 01/01/2016.";
		Console.WriteLine(str);
		Console.WriteLine("Enter FirstName:");
		string name = Console.ReadLine();
		Console.WriteLine("Enter Full name :");
		string fname = Console.ReadLine();
		Console.WriteLine("enter your phone number");
		string phno = Console.ReadLine();
		Console.WriteLine("enter your date");
		string date = Console.ReadLine();
			s1 = Regex.Replace(str, "<<name>>", name);
			s2 = Regex.Replace(str, "<<full name>>", fname);
			s3 = Regex.Replace(str, "xxxxxxxxxx", phno);
			s4 = Regex.Replace(str, "01/01/2016", date);
			output = str.Replace( "<<name>>", name).Replace("<<full name>>", fname).Replace("xxxxxxxxxx" ,phno).Replace("01/01/2016",date);
			Console.WriteLine(output);
	
		}
    }
}
