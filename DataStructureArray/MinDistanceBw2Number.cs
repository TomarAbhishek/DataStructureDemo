using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureArray
{
    class MinDistanceBw2Number
    {
        //public static void Main(string[] argss)
        //{
        //    int[] arr = { 1, 2, 3, 4, 1, 3, 6, 9, 8, 5, 1, 3, 7, 5, 4, 1, 3, 6, 9, 4, 6, 41, 45, 11, 65 };

        //    MinDistanceMethod1(arr, 41, 7);
        //    MinDistanceMethod2(arr, 41, 7);
        //    Console.ReadLine();
        //}
        static void MinDistanceMethod1(int[] arr, int x, int y)
        {
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if ((arr[i] == x && arr[j] == y || arr[i] == y && arr[j] == x) && (min > Math.Abs(i - j)))
                    {
                        min = Math.Abs(i - j);
                    }
                }
            }
            Console.WriteLine(min);
        }
        static void MinDistanceMethod2(int[] arr, int x, int y)
        {
            int i = 0;
            int min = int.MaxValue;
            int prev_index=0;

            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x || arr[i] == y)
                {
                    prev_index = i;
                    break;
                }
            }
            for (; i < arr.Length; i++)
            {
                if (arr[i] == x || arr[i] == y)
                {
                    if(arr[prev_index] != arr[i] && (i-prev_index) < min)
                    {
                        min = i - prev_index;
                        prev_index = i;
                    }
                    else
                    {
                        prev_index = i;
                    }
                }
            }
            Console.WriteLine(min);
        }
    }
}
