using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Schema;

namespace Basics
{
    public class Arrays
    {
        public static int Search(int[] arr, int e)
        {
            int i = 0;
            int l = arr.Length;
            while (i < l && arr[i] != e)
            {
                ++i;
            }
            if (i == l)
                return -1;
            else
                return i;
        }

        public static int KingOfTheHill(int[] arr)
        {
            int l = arr.Length;
            int a, b;
            a = arr[0];
            for (int i = 1; i < l; i++)
            {
                b = arr[i];
                if (b > a)
                    a = b;
            }
            return a;
        }

        public static int[] CloneArray(int[] arr)
        {
            int l = arr.Length;
            int[] arr2 = new int[l];
            for (int i = 0; i < l-1; i++)
            {
                arr2[i] = arr[i];
            }
            return arr2;
        }
        public static void BubbleSort(int[] arr)
        {
            //FIXME
            int l = arr.Length;
            int a, b;
            for (int i = l; i > 0 ; i--)
            {
                for (int j = 0; j < i-1; j++)
                {
                    a = arr[j];
                    b = arr[j + 1];
                    if (a > b)
                        Reference.Swap(ref a,ref b);
                    arr[j] = a;
                    arr[j + 1] = b;
                }
            }
        }
    }
}