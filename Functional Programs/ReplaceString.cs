using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
    public class ReplaceString
    {
        public void replaceString()
        {
            String str1, str2, str3;

            Console.WriteLine("Enter Name");
            str1 = Console.ReadLine();
            int len = str1.Length;
            if (len >= 3)
            {
                Console.WriteLine("hello:\t" + str1 + ",How are You?");
                Console.WriteLine("Enter Name which you want to replace");
                str2 = Console.ReadLine();
                str3 = str1.Replace(str1, str2);
                Console.WriteLine("hello:\t" + str3 + ",How are You?");
            }
            else
            {
                Console.WriteLine("Enter valide name");
            }
            Console.ReadKey();
        }
       
    }

    }

