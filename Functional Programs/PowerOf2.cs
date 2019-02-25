using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
    class PowerOf2
    {
       public void powerOf2()
        { 
        Console.WriteLine("Enter The Number");
        int num = Convert.ToInt32(Console.ReadLine());
       for(int i=1; i<=num;i++)
        {
            Console.WriteLine("Power of 2 is" + Math.Pow(2, i));
        }
            Console.ReadKey();
        }
    }
}
