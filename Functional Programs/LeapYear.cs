using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
    public class LeapYear
    {
        public void leafYear()
        {
            // TODO Auto-generated method stub
            Console.WriteLine("Enter Year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year >= 1582 && year % 4 == 0 || year % 400 == 0 && year % 100 != 0)
            {
                Console.WriteLine("Leap Year:" + year);
            }
            else
            {
                Console.WriteLine("Not a Leap Year:" + year);
            }
            Console.ReadKey();

        }

    }

}
