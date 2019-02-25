using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
    class FlipCoin
    {
             public void calculateFlipCoin()
        { 
            Random random = new Random();
            int count = 0, count1 = 0, heads = 0, tails = 0;
            Console.WriteLine("Enter The Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (random.NextDouble() < 0.5)
                {
                    //System.out.println("Tails");
                    tails = tails + count;
                    tails++;
                    Console.WriteLine("tails=" + tails);
                }
                else
                {
                    //System.out.println("Heads");
                    heads = heads + count1;
                    heads++;
                    Console.WriteLine("Heads=" + heads);
                }
            }
            float a = (float)tails / n * 100;
            Console.WriteLine("Percentage of Tails=" + a);
            float b = (float)heads / n * 100;
            Console.WriteLine("Percentage of Heads=" + b);
            Console.ReadKey();
        }

    }
}
