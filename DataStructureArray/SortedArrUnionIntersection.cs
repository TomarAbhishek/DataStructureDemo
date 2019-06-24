using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureArray
{
    class SortedArrUnionIntersection
    {
        /*public static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 5, 7, 9 };
            int[] arr2 = { 2, 3, 4, 6, 8, 9 };

            PrintArray(arr1);
            PrintArray(arr2);

            Union(arr1, arr2, arr1.Length, arr2.Length);
            Intersection(arr1, arr2, arr1.Length, arr2.Length);

            Console.ReadLine();
        }
        */
        static void Union(int[] arr1, int[] arr2, int m,int n)
        {
            Console.WriteLine("******************* UNION *******************");
            int i = 0, j = 0;
            while(i<m && j < n)
            {
                if (arr1[i] < arr2[j])
                {
                    Console.Write(arr1[i++] + " ");
                }
                else if (arr1[i] > arr2[j])
                {
                    Console.Write(arr2[j++] + " ");
                }
                else
                {
                    Console.Write(arr1[i++] + " ");
                    j++;
                }
            }
            while (i < m)
            {
                Console.Write(arr1[i++] + " ");
            }
            while(j < n)
            {
                Console.Write(arr2[j++] + " ");
            }
            Console.WriteLine();
        }
        static void Intersection(int[] arr1, int[]arr2, int m, int n)
        {
            Console.WriteLine("******************* INTERSECTION *******************");
            int i = 0, j = 0;
            while (i < m && j < n)
            {
                if (arr1[i] < arr2[j])
                {
                    i++;
                }
                else if (arr1[i] > arr2[j])
                {
                    j++;
                }
                else
                {
                    Console.Write(arr1[i++] + " ");
                    j++;
                }
            }
            Console.WriteLine();
        }
        static void PrintArray(int[] arr)
        {
            for(int i=0; i< arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
