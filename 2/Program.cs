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
            int napokszama = int.Parse(split1[0]);
            int napok = int.Parse(split1[1]);
            int fok = int.Parse(split1[3]);
           
            string input2 = Console.ReadLine();
            string[] split2 = input2.Split(' ');

                int res = 0;
                bool lastDayTrue = false;
                List<int> fokok = new List<int>();
                foreach (string szam in split2)
                {
                    fokok.Add(int.Parse(szam));
                }
                
                


               for (int i = 0; i < napokszama; i++) {
                   if (fokok[i] > fok) {
                       if (lastDayTrue) {
                           res += 1;
                            lastDayTrue = false;
                       } else {
                           lastDayTrue = true;
                       }
                   } else {
                       lastDayTrue = false;
                   }
               }
               Console.WriteLine(res);
               
              
            }
        

       
    }
}
