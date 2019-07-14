using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            if (size > 3 && size <= 5000)
            {
                char[] ch = (Console.ReadLine()).ToCharArray();

                Console.WriteLine(GetMinInsert(ch,size));
                Console.Write(CountInsertion(ch, 0, size - 1));
                Console.ReadLine();
            }

        }
        public static int GetMinInsert(char[] str, int n)
        {
            int l, h, len;
            int[,] table = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    table[i, j] = 0;
                }
            }
            for (len = 1; len < n; len++)
            {
                for (l = 0, h = len; h < n; l++, h++)
                {
                    table[l, h] = (str[l] == str[h]) ? (table[l + 1, h - 1]) : (Math.Min(table[l, h - 1], table[l + 1, h]) + 1);
                }
            }

            return table[0, n - 1];
        }

        public static int CountInsertion(char[] ch, int l, int h)
        {
            if (l > h)
            {
                return ch.Length;
            }
            if (l == h)
            {
                return 0;
            }
            if (l == h - 1)
            {
                if (ch[l] == ch[h])
                    return 0;
                else
                    return 1;
            }
            if (ch[l] == ch[h])
            {
                return CountInsertion(ch, l + 1, h - 1);
            }
            else
            {
                return Math.Min(CountInsertion(ch, l, h - 1), CountInsertion(ch, l + 1, h)) + 1;
            }

        }
    }
}
