using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureArray
{
    //longest sum with the same sum in two binary arrays
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int output;
        //    int[] array1 = { 0, 1, 0, 1, 0, 1, 1, 1, 1 };
        //    int[] array2 = { 1, 1, 1, 0, 1, 0, 1, 1, 1 };

        //    output = Method1(array1, array2, array1.Length);
        //    Console.WriteLine(output);

        //    output = Method2(array1, array2, array1.Length);
        //    Console.WriteLine(output);
        //    Console.ReadLine();
        //}
        static int Method1(int[] array1, int[] array2, int size)
        {
            int maxLength = 0;

            for (int i = 0; i < size; i++)
            {
                int arraysum1 = 0;
                int arraysum2 = 0;

                for (int j = i; j < size; j++)
                {
                    arraysum1 += array1[j];
                    arraysum2 += array2[j];

                    if (arraysum1 == arraysum2)
                    {
                        if (maxLength < (j - i + 1))
                            maxLength = j - i + 1;
                    }
                }
            }
            return maxLength;
        }
        static int Method2(int[] array1, int[] array2, int size)
        {
            int maxLength = 0;
            int arraysum1 = 0;
            int arraysum2 = 0;
            int curr_diff = 0;
            int diff_index = 0;

            int[] diff_array = Enumerable.Repeat(-1, (2 * size + 1)).ToArray();

            for (int i=0; i<size; i++)
            {
                arraysum1 += array1[i];
                arraysum2 += array2[i];

                curr_diff = arraysum1 - arraysum2;
                diff_index = size + curr_diff;

                if(curr_diff == 0)
                {
                    maxLength = i + 1;
                }
                else if (diff_array[diff_index] == -1)
                {
                    diff_array[diff_index] = i;
                }
                else
                {
                    int lenght = i - diff_array[diff_index];
                    if (lenght > maxLength)
                    {
                        maxLength = lenght;
                    }
                }
            }
            return maxLength;
        }
    }
}
