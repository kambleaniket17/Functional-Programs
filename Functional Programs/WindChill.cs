using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
    public class WindChill
    {
        public static void calculateWindTemp()
        {
            Console.WriteLine("Enter Temperature");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Wind Speed");
            int v = Convert.ToInt32(Console.ReadLine());
            double w = 35.74 + 0.6215 * t + (0.4275 * t - 35.75) * Math.Pow(v, 0.16);
            Console.WriteLine("Wind Chill="+w);
            Console.ReadKey();

        }
    }
}
