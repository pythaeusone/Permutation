using System;
using System.Collections.Generic;
using System.Text;

namespace Permutation
{
    class Printers
    {
        public void PrinteV1(string[] arr)
        {
            Permutation per = new Permutation();

            Console.WriteLine(" Mit Array :-p");
            Console.WriteLine("");

            foreach (string s in arr)
            {
                char[] charArray = s.ToCharArray();

                per.Permuter(charArray, 0, (s.Length - 1));

                Console.WriteLine(" ----------");
            }
        }
        
        public void PrinteV2(string[] arr)
        {
            Permut2 per2 = new Permut2();

            Console.WriteLine(" Nur mit char xD");
            Console.WriteLine("");

            foreach (string s in arr)
            {
                per2.Per(s, "");

                Console.WriteLine(" ----------");
            }
        }
    }
}
