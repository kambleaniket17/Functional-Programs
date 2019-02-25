using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
    class Array2D
    {
        public static void calculat2Darray()
        {
            Console.WriteLine("Enter Row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Column");
            int col = Convert.ToInt32(Console.ReadLine());
            int i = 0, j = 0;
            int[,] array = new int[row, col];

            Console.WriteLine("Enter The Elements");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("The 2D Array is:\n");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write("{0}\t", array[i, j]);

                }
                Console.Write("\n");

            }
            Console.ReadKey();

        }
    }
}
