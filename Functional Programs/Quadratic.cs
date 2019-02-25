using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
    public class Quadratic
    {
        public static void quadraticEquations()
        {
            Console.WriteLine("Enter A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter C");
            int c = Convert.ToInt32(Console.ReadLine());
            double Delta = (b * b) - (4 * a * c);
            Console.WriteLine(Delta);
            double Root1 = (-b + Math.Sqrt(Delta)) / (2 * a);
            Console.WriteLine(Root1);
            double Root2 = (-b - Math.Sqrt(Delta)) / (2 * a);
            Console.WriteLine(Root2);
            Console.ReadKey();
        }
    }
}
