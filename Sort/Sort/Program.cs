using Sort.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入数字");
            string numbers = Console.ReadLine();
            string[] number = numbers.Trim().Split(' ');
            int[] data = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                data[i] = Convert.ToInt32(number[i]);
            }
            Console.WriteLine("选择排序法：");
            int[] selectsort = SelectSort.Select(data);
            Write(selectsort);

            Console.WriteLine("插入排序法：");
            int[] isnertsort = InsertSort.Insert(data);
            Write(isnertsort);

            Console.WriteLine("冒泡排序法：");
            int[] bubblesort = BubbleSort.Bubble(data);
            Write(bubblesort);

            Console.WriteLine("希尔排序法：");
            int[] shellsort = ShellSort.Shell(data);
            Write(shellsort);

            Console.WriteLine("堆排序法：");
            int[] halfsort = HeapSort.Heap(data);
            Write(halfsort);

            Console.ReadKey();
        }
        public static void Write(int[] numbers)
        {
            for (int t = 0; t < numbers.Length; t++)
            {
                Console.Write(numbers[t] + " ");
            }
            Console.Write("\n");
        }

    }
}
