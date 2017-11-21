using System;
using System.Xml.Schema;

namespace TP0
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MyGcd(16, 100));
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
                if (n == 1)
                    return x;
                else
                    return x * MyPow(x, n-1);
            }
            else
            {
                if (n == 0)
                    return x;
                else
                    return x * MyPow(x, n + 1);
            }
        }

        static uint MyFibo(uint n)
        {
            if (n == 1 || n == 0)
                return n;
            else
                return MyFibo(n - 1) + MyFibo(n - 2);
        }

        static string ChangeChar(string s, char c, uint n)
        {
            if (n > s.Length - 1)
            {
                return s;
            }
            else
            {
                if (n == 0)
                    return c + s.Substring(1);
                else
                    return s[0] + ChangeChar(s.Substring(1), c, n-1);
            }

        }

        static uint MyGcd(uint a, uint b)
        {
            int b2 = (int) b;
            int a2 = (int) a;
            if (a2 > b2)
            {
                if (a % b == 0)
                    return b;
                else
                    return MyGcd(a, a % b);
            }
            else
            {
                if (b % a == 0)
                    return b;
                else
                    return MyGcd(a, b % a);
            }
        }

        static double MySqrt(double n, uint i)
        {
            if (i == 0)
                return 1 / 2;
            else
                return (MySqrt(n, i - 1) + n / MySqrt(n, i - 1)) / 2;
        }
    }
}