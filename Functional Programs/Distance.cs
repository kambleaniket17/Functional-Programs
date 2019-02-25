using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
    public class Distance
    {
        public static void calculateDistance()
        {

            // TODO Auto-generated method stub\
            double distance;
            Console.WriteLine("Enter X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            int y = Convert.ToInt32(Console.ReadLine());
            distance = (double)Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine("Distance=" + distance);
            Console.ReadKey();
        }
    }
 }
