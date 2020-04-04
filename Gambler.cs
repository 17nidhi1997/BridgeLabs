using System;
using System.Collections.Generic;
using System.Text;

namespace Functiona
{
    class Gambler
    {
        public void Game()
        {
            int stake, goal, trails, wins = 0, loss= 0,bets = 0,count=0;
            Random rand = new Random();
            Console.WriteLine("Enter the value of stake number of games played");
            stake = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the goal");
            goal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of games played");
            trails = Convert.ToInt32(Console.ReadLine());
            int cash = stake;
            while (cash > 0 && cash < goal && count < trails)
            {
                bets++;
                if (rand.NextDouble() > 0.5)
                {
                    cash++;
                    wins++;
                }
                else
                {
                    cash--;
                    loss++;
                }
                count++;
                if(cash == goal)
                {
                    Console.WriteLine("you have won " + wins);
                    break;
                }
            }
            Console.WriteLine("Wins : " +wins);
            Console.WriteLine("percent of Wins: " + (wins * 100 / count));
            Console.WriteLine("percent of loss:" +(loss * 100 / count));

        }

    }
}
