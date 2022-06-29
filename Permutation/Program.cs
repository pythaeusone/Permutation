using System;

namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Printers print = new Printers();

            string[] arr = {"A", "AA", "AB", "ABC", "AAC"};

            print.PrinteV1(arr);
            Console.WriteLine("");
            print.PrinteV2(arr);

            Console.ReadKey();
        }
    }
}
