using System;

namespace Permutation
{
    class Permutation
    {

        public void Permuter(char[] array, int i, int len)
        {
            Wechsel w = new Wechsel();

            if (i == len)
            {
                Console.Write(" ");
                Console.Write(array);
                Console.Write("\n");
            }                
            else
            {
                for (int j = i; j <= len; j++)
                {
                    w.Wechseler(ref array[i], ref array[j]);
                    Permuter(array, i + 1, len);
                    w.Wechseler(ref array[i], ref array[j]);
                }
            }
        }

    }
}
