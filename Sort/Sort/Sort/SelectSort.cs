using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Sort
{
    public class SelectSort
    {       
        public static int[] Select(int[] data)
        {
            for (int i = 0; i < data.Length - 1; ++i)
            {
                int min = i;
                for (int j = i + 1; j < data.Length; ++j)
                {
                    if (data[j] < data[min])
                        min = j;
                }
                int t = data[min];
                data[min] = data[i];
                data[i] = t;
            }
            return data;
        }
    }
}
