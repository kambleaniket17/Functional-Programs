using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
    class Triplets
    {
        public static void calculateTriple()
        {
            Console.WriteLine("Enter The Numbers");
            int b = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[b];
            Console.WriteLine("Enter " + b + "Numbers");
            for (int i = 0; i < b; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                // Console.WriteLine(a[i]);
            }

            for (int i = 0; i < b; i++)
            {
                for (int j = i; j < b; j++)
                {
                    for (int k = j; k < b; k++)
                    {
                        if (a[i] + a[j] + a[k] == 0)
                        {
                            Console.WriteLine("Number Is equal to 0");
                            Console.Write(a[i] + "\t");
                            Console.Write(a[j] + "\t");
                            Console.Write(a[k] + "\t");

                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
