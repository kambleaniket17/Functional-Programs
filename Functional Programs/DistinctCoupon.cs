using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
    class DistinctCoupon
    {
        public static int randomNumber(Random random)
        {
            return (int)random.Next(0,10);
        }
        public static int collect(int number)
        {

            int count = 0;
            int i = 0;
            int distinct = 0;
            int[] array = new int[number];

            while (i < number)
            {
                count++;
                distinct = 1;
                Random random = new Random(Guid.NewGuid().GetHashCode());
                for (int j = 0; j < number; j++)
                {
                    int value = randomNumber(random);
                    //Console.WriteLine(value);
                    if (array[i] == value)
                    {
                        distinct = 0;
                    }
                }
                if (distinct == 1)
                {
                    array[i] = number;
                    i++;
                }
                Console.WriteLine(count);
            }
            return count;
        }
        
    }
}
