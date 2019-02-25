using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
    class Gambler
    {
        public static void gambler()
        {
            // TODO Auto-generated method stub
            int betPrice = 1, win = 0, loss = 0;
            Random random = new Random();
            Console.WriteLine("Enter Stake");
            int stake = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Goal");
            int goal = Convert.ToInt32(Console.ReadLine());


            while (stake != 0 && stake != goal)
            {


                if (random.NextDouble() > 0.5)
                {
                    stake = stake + betPrice;
                    Console.WriteLine("User Win and Stake=" + stake);
                    win++;

                    //break;
                }
                else
                {
                    stake = stake - betPrice;
                    Console.WriteLine("User Loss and stake=" + stake);
                    loss++;
                    //break;
                }


            }
            Console.WriteLine("win=" + win);
            Console.WriteLine("Loss=" + loss);

            int total = win + loss;

            double winPercentage = (double)win / total * 100;

            double LossPercentage = (double)loss / total * 100;
            Console.WriteLine("win Percentage=" + winPercentage);
            Console.WriteLine("Loss Percentage=" + LossPercentage);
            Console.ReadKey();
        }
    }
}
