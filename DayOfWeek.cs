using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
	class DaayOfWeek
	{
		public void day()
		{

			Console.WriteLine("enter day:");
			int d = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("enter month:");
			int m = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("enter year:");
			int y = Convert.ToInt32(Console.ReadLine());
			
			int d1 = calculateDayOfWeek(d, m, y);
			switch (d1)
			{
				case 0:
					Console.WriteLine("day is sunday");
					break;
				case 1:
					Console.WriteLine("day is monday");
					break;
				case 2:
					Console.WriteLine("day is tueday");
					break;
				case 3:
					Console.WriteLine("day is wednesday");
					break;
				case 4:
					Console.WriteLine("day is thurday");
					break;
				case 5:
					Console.WriteLine("day is friday");
					break;
				case 6:
					Console.WriteLine("day is saturday");
					break;
			}

			 int calculateDayOfWeek(int day, int month, int year)
			{
				int y1, x, m, d1;
				y1 = year - (14 - month) / 12;
				x = y1 + (y1 / 4) - (y1 / 100) + (y1 / 400);
				m = month + 12 * ((14 - month) / 12) - 2;
				d1 = (day + x + 31 * m / 12) % 7;
				return d1;

			}

		}

	}
}

