using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Sort
{
    public class HeapSort
    {
        public static int[] Heap(int[] data)
        { 
            Heapsort(data);
            return data;
        }
        static void HeapAdjust(int[] sqdata, int s, int m)
        {
            int rc = sqdata[s];
            for (int j = 2 * s; j <= m; j *= 2)
            {
                if (j < m && sqdata[j] < sqdata[j + 1])
                    ++j;
                if (rc >= sqdata[j])
                    break; sqdata[s] = sqdata[j]; s = j;
            }
            sqdata[s] = rc;
        }
        static void Heapsort(int[] sqdata)
        {
            int m;
            for (int i = (sqdata.Length - 1) / 2; i > 0; --i)
                HeapAdjust(sqdata, i, sqdata.Length - 1);
            for (int i = sqdata.Length - 1; i > 1; --i)
            {
                m = sqdata[1];
                sqdata[1] = sqdata[i];
                sqdata[i] = m;
                HeapAdjust(sqdata, 1, i - 1);
            }
        }
    }
}
