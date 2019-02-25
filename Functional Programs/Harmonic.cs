using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
    class Harmonic
    {
        public void harmonic()
        {
        // TODO Auto-generated method stub
        double result = 0;
        Console.WriteLine("Enter Number:");
        
        int n = Convert.ToInt32(Console.ReadLine());
        while (n > 0)
        {
            result = result + (double)1 / n;
            n--;

        }
    Console.WriteLine("Harmonic Number=" + result);
            Console.ReadKey();
    }
    }
}
