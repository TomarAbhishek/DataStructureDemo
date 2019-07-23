using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureArray.MultiDiminsional_Array
{
    class Inside_Pattern
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int size = 2 * n - 1;
            int front = 0;
            int end = size - 1;
            int[,] arr = new int[size, size];
            while (n > 0)
            {
                for (int i = front; i <= end; i++)
                {
                    for (int j = front; j <= end; j++)
                    {
                        if (i == front || i == end || j == front || j == end)
                        {
                            arr[i, j] = n;
                        }
                    }
                }
                front++;
                end--;
                n--;
            }
            print(arr, size);
            Console.ReadLine();
        }
        static void print(int[,] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(arr[i, j]);
                Console.WriteLine();
            }
        }
    }
}
