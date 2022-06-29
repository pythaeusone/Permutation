using System;

namespace Permutation
{
    class Permut2
    {
        public void Per(string wort, string erg)
        {
            if (wort.Length == 0)
            {
                Console.WriteLine(" " + erg);

                return;
            }

            for (int i = 0; i < wort.Length; i++)
            {
                char c = wort[i];

                string str_eins = wort.Substring(0, i);
                string str_zwei= wort.Substring(i + 1);
                string einszwei = str_eins + str_zwei;
                string e = erg + c;

                Per(einszwei, e);
            }
        }
    }
}
