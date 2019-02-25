// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Origin.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Functional_Programs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Main class Origin.
    /// </summary>
    public class Origin
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 0:
                    string str = "ABC";
                    int n1 = str.Length;
                    Practice.permute(str, 0, n1 - 1);
                    Console.ReadKey();
                    break;

                case 1:
                   Distance d = new Distance();
                   Distance.calculateDistance();
                    break;
                case 2:
                    ReplaceString r = new ReplaceString();
                    r.replaceString();
                    break;
                case 3:
                    FlipCoin f = new FlipCoin();
                    f.calculateFlipCoin();
                    break;
                case 4:
                    LeapYear l = new LeapYear();
                    l.leafYear();
                    break;
                case 5:
                    PowerOf2 p = new PowerOf2();
                    p.powerOf2();
                    break;
                case 6:
                    Harmonic h = new Harmonic();
                    h.harmonic();
                    break;
                case 7:
                    PrimeFactor.calculatePrimeFactor();
                    break;
                case 8:
                    Gambler.gambler();
                    break;
                case 9:
                    // int min = 1;
                    Console.WriteLine("Enter The Number");
                    int number = int.Parse(Console.ReadLine());
                    int a = DistinctCoupon.collect(number);
                    Console.WriteLine(a);
                    Console.ReadKey();
                    break;
                case 10:
                    Array2D.calculat2Darray();
                    break;
                case 11:
                    Triplets.calculateTriple();
                    break;
                case 12:
                    StopWatch s = new StopWatch();
                    s.stopWatch();
                    break;
                case 13:
                    Quadratic.quadraticEquations();
                    break;
                case 14:
                    WindChill.calculateWindTemp();
                    break;
                case 15:
                    Console.WriteLine("Enter The String");
                    string name = Console.ReadLine();

                    string permute = (string)Permutation.permute(name, 0, name.Length - 1);
                    Console.WriteLine(permute);
                    Console.Read();
                    break;

                default:
                    Console.WriteLine();
                    break;
          }
    }
    }
}
