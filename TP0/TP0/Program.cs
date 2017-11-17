using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;

namespace TP0
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MyPow(2,2));
        }
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
    }

        static void SayHello()
        {
            Console.WriteLine("What's your name?");
            Console.WriteLine("Well hello " + Console.ReadLine() + "!");
        }

        static void CalcAge()
        {
            Console.WriteLine("What is your date of birth?");
            string str;
            while((str = Console.ReadLine()) == "")
            {
                
            }
            Console.WriteLine("Looks like you're around " + (2017 - int.Parse(str)));
        }

        static int Absolute(int x)
        {
            if (x >= 0)
                return x;
            else
                return -x;
        }

        static uint MyFact(uint n)
        {
            if (n == 1)
                return n;
            else
                return n * MyFact(n - 1);

        }

        static double MyPow(double x, int n)
        {
            if (x >= 0)
            {
                if (n == 0)
                    return x;
                else
                    return x * MyFact(x(n - 1));
            }
            else
            {
                if (n == 0)
                    return x;
                else
                    return x * MyFact(x, (n + 1));
            }
        }
    }
    }