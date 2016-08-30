using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Sort
{
    class BubbleSort
    {
        public static int[] Bubble(int[] data)
        {
            int i, j, temp;  
            bool exchange;
            for (i = 0; i < data.Length; i++) 
            {
                exchange = false; 
                for (j = data.Length - 2; j >= i; j--)
                {
                    if (data[j + 1] < data[j]) 
                    {
                        temp = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = temp;
                        exchange = true; 
                    }
                }
                if (!exchange)  
                {
                    break;
                }
            }
            return data;
        }
    }
}
