using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int res = 0;

            string input1 = Console.ReadLine();
            string[] split1 = input1.Split(' ');
            int sorok = int.Parse(split1[0]);
            int oszlopok = int.Parse(split1[1]);

            string input2 = Console.ReadLine();
            string[] split2 = input2.Split(' ');
            int egeszElsoSor = int.Parse(split2[0]);
            int egeszMasodikSor = int.Parse(split2[1]);

            List<int[]> oszlopokValues = new List<int[]>();
            for (int i = 0; i < oszlopok; i++)
            {
                string newInput = Console.ReadLine();
                string[] newSplit = newInput.Split(' ');
                List<int> temp = new();
                foreach (string item in newSplit)
                {
                    temp.Add(int.Parse(item));
                }

                int[] temp2 = temp.ToArray();
                oszlopokValues.Add(temp2);

            }
            int Sum(int inp)
            {
                int res = 0;

                foreach (int[] item in oszlopokValues)
                {
                    if (item[inp] > item[0])
                    {
                        res += item[0];
                    }
                    else
                    {
                        res += item[inp];
                    }
                }



                return res;
            }


            for (int i = 0; i > oszlopok; i++)
            {

            }
            if (egeszElsoSor < Sum(0))
            {
                Console.WriteLine(true);
                res += egeszElsoSor;
            }
            else
            {
                Console.WriteLine(false);
                res += Sum(0);

            }

            if (egeszMasodikSor < Sum(2))
            {
                Console.WriteLine(true);
                res += egeszMasodikSor;
            }
            else
            {
                Console.WriteLine(false);
                res += Sum(2);

            }
            Console.WriteLine(res);
        }



    }
}
