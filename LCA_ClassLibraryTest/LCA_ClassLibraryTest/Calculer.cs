using System.Linq;

namespace LCA_ClassLibraryTest
{
    public class Calculer
    {
        public int CalcSum(int a, int b, params int[] c) => a + b + (c == null ? 0 : c.Sum());
    }
}
