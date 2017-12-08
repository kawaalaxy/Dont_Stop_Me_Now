using System;
using System.Xml.Schema;

namespace Basics
{
    public class Reference
    {
        public static void Swap(ref int a, ref int b)
        {
            int c = a;
            c = a;
            a = b;
            b = c;
        }

        public static int Trunc(ref float f)
        {
            //FIXME
            int g = (int) f;
            f = f - g;
            return g;
        }

        public static void RotChar(ref char c, int n)
        {
            //FIXME    
            
        }

        public static void test(int[]arr)
        {
            int l = arr.Length;
            for (int i = 0; i < l; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n");
        }
    }
}