
namespace Permutation
{
    class Wechsel
    {
        public void Wechseler(ref char x, ref char y)
        {
            char tmps;
            tmps = x;
            x = y;
            y = tmps;
        }
    }
}
