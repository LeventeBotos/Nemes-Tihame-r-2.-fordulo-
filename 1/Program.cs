using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            string input1 = Console.ReadLine();
            string[] split1 = input1.Split(' ');
            int retek = int.Parse(split1[0]);
            int minszam = int.Parse(split1[1]);

            string input2 = Console.ReadLine();
            string[] split2 = input2.Split(' ');

            int res = 0;
            List<int> szabade = new List<int>();
            foreach (string szam in split2)
            {
                szabade.Add(int.Parse(szam));
            }




            for (int i = 0; i < retek; i++)
            {
                int tempres = 0;
                if (szabade[i] == 1)
                {
                    for (int x = i; x < retek; x++)
                    {

                        if (szabade[x] == 1)
                        {
                            tempres += 1;
                        }
                    }
                    if (tempres > minszam || tempres == minszam)
                    {
                        tempres -= 2;
                    }
                    else
                    {
                        tempres = 0;
                    }
                    // Console.WriteLine(tempres);
                }
                res += tempres;
            }

            Console.WriteLine(res);

        }


    }
}
