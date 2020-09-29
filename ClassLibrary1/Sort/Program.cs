using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            SortMethod sort1 = new SortMethod();
            var list = new int[] { 10, 8, 5, 9, 7, 9, 7, 1, 3, 23, 15, 65, 23, 21, 10, 6,23,123,31};
            var list2 = list;

            Console.WriteLine("冒泡排序结果为：" + string.Join(",", sort1.Bubble(list)));
            sort1.QuickSort(ref list2, 0, 15);
            Console.WriteLine("快速排序结果为：" + string.Join(",", list2));
            Console.ReadKey();
        }
    }
}
