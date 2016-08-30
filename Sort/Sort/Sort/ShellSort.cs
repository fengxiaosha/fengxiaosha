using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Sort
{
    public class ShellSort
    {
        public static int[] Shell(int[] data)
        {
            int inc;
            for (inc = 1; inc <= data.Length / 9; inc = 3 * inc + 1) ;
            for (; inc > 0; inc /= 3)
            {
                for (int i = inc + 1; i <= data.Length; i += inc)
                {
                    int t = data[i - 1];
                    int j = i;
                    while ((j > inc) && (data[j - inc - 1] > t))
                    {
                        data[j - 1] = data[j - inc - 1];
                        j -= inc;
                    }
                    data[j - 1] = t;
                }
            }
            return data;
        }
    }
}
