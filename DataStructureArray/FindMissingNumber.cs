using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureArray
{
    class FindMissingNumber
    {
        /*public static void Main(string[] str)
        {
            int[] arr = { 3,                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 1, 2, 4, 5, 6 };

            FindMissingNumberMethod1(arr, arr.Length);
            FindMissingNumberMethod2(arr, arr.Length);
            FindMissingNumberMethod3(arr, arr.Length);


            Console.ReadLine();
        }
        */
        static void FindMissingNumberMethod1(int[] arr,int size)
        {
            int total = (size + 1) * (size + 2) / 2;
            for(int i=0; i<size; i++)
            {
                total = total - arr[i];
            }
            Console.WriteLine(total);
        }
        static void FindMissingNumberMethod2(int[] arr, int size)
        {
            int xor1 = arr[0];
            int xor2 = 1;
            for(int i=1; i < size; i++)
            {
                xor1 = xor1 ^ arr[i];
            }
            for (int i = 2; i <=size+1; i++)
            {
                xor2 = xor2 ^i;
            }
            Console.WriteLine(xor1 ^ xor2);
        }
        static void FindMissingNumberMethod3(int[] arr, int size)
        {
            int largest = size + 1;
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += arr[i] - (i + 1);
            }
            Console.WriteLine(largest - sum);
        }
        
    }
}
