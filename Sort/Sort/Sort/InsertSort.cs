using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Sort
{
    public class InsertSort
    {
        public static int[] Insert(int[] data)
        {
            for (int i = 1; i < data.Length; ++i)
            {
                int t = data[i];
                int j = i;
                while ((j > 0) && (data[j - 1] > t))
                {
                    data[j] = data[j - 1];
                    --j;
                }
                data[j] = t;
            }
            return data;
        }
    }
}
