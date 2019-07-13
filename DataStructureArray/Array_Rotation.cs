using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureArray
{
    class Array_Rotation
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int rotation = 2;
            int size = array.Length;
            /*
            Console.Write("Enter the size of an array  : ");
            int size =Convert.ToInt32( Console.ReadLine());

            int[] array = new Int32[size];
            for(int i=0; i<size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the rotation  : ");
            int rotation = Convert.ToInt32(Console.ReadLine());*/
            LeftRotate(array, 0, rotation - 1);
            LeftRotate(array, rotation, size-1 );
            LeftRotate(array, 0, size - 1);
            for (int i = 0; i < size; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
            SwapRotation(array, rotation, size);
            for (int i=0;i<size;i++)
            Console.Write(array[i]+ " ");
            CircularArrayRotation(array, 3);
            Console.ReadLine();
        }

        public static void LeftRotate(int[] arr, int min , int max)
        {
            while (min < max)
            {
                int temp = arr[min];
                arr[min] = arr[max];
                arr[max] = temp;
                min++;
                max--;
            }
        }
        public static void SwapRotation(int[] arr, int rotation, int size)
        {
            for(int i =0; i<rotation; i++)
            {
                int temp = arr[i];
                for(int j=i;j<size; j += 2)
                {
                    if (j + 2 < size)
                    {
                        arr[j] = arr[j + 2];
                    }
                    else
                    {
                        arr[j] = temp;
                    }
                }
            }
        }

        public static void CircularArrayRotation(int [] arr, int rotation)
        {
            Console.Write(arr[rotation] +" ");
            int temp = rotation + 1;
            while (temp != rotation)
            {
                temp = temp % arr.Length;
                Console.Write(arr[temp]+ " ");
                temp++;
            } 
        }
    }
}
