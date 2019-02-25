using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
    class PrimeFactor
    {
        public static void calculatePrimeFactor()
        { 
        // TODO Auto-generated method stub
        Console.WriteLine("Enter number");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i <=n; i++)
        {
            
                int x = 0;
                while (n % i == 0)
                {
                    n/=i;
                    x++;
                    Console.WriteLine("Prime factor=" + i);
                   
                }

            }
            Console.ReadKey();

        }
    }
}
