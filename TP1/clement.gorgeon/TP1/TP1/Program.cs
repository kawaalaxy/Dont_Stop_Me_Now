using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace TP1
{
    static class Program
    {
        public static void Main(string[] args)
        {
            BestYears();
        }

        public static void HelloWorlds(int n)
        {
            int i = 0;
            while (i < n)
            {
                i += 1;
                Console.WriteLine("Hello (West)World!");
            }

        }

        public static void Echo()
        {
            string s = Console.ReadLine();
            Console.WriteLine(s);
        }

        static string Erk(string s)
        {
            if (s.Length == 1)
                return s;
            else
                return ((Erk(s.Substring(1))) + s[0]);
        }

        public static void Reverse()
        {
            string s = Console.ReadLine();
            Console.WriteLine(Erk(s));
        }

        static void LoveAcdc()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  * * *   * * *  \n* *   * * *   * *\n*       *       *\n* *  <3 ACDC  * *");
            Console.WriteLine("  * *       * *  \n    * *   * *    \n      * * *      \n        *        ");
        }

        public static void MCQ(string question, string aws1, string aws2, string aws3, string aws4, int aws)
        {
            Console.WriteLine(question + "\n1) " + aws1 + "\n2) " + aws2 + "\n3) " + aws3 + "\n4) " + aws4);
            int r = int.Parse(Console.ReadLine());
            if (r == aws)
            {
                Console.WriteLine("Good job bro!");
            }
            else if (r > 0 || r < 5)
            {
                Console.WriteLine("You loose... The answer was " + aws);
            }
            else
            {
                Console.WriteLine("So counting is too hard, n00b...");
            }
            
        }

        public static void BestYears()
        {
            int y = 1989;
            while (y < 2023)
            {
                if (y == 2020)
                    Console.WriteLine("Best Year");
                if (y == 2022)
                {
                    Console.WriteLine("Bad Year");
                    Console.WriteLine(3);
                }
                else if (y % 2 == 0)
                    Console.WriteLine("Good Year");

                else
                    Console.WriteLine("Bad Year");
                y += 1;
            }
        }
    }    
        
}