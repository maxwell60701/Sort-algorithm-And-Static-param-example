using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class SortMethod
    {
        private int privot;
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int[] Bubble(int[] list)
        {
            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    // Exchange(ListPrev[j], ListPrev[j + 1]);
                    if (list[j] > list[j + 1])
                    {                    
                        Swap(j, j + 1, list);
                    }
                }

            }
            return list;
        }

        /// <summary>
        /// 快速排序
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public void QuickSort(ref int[] list, int low, int high)
        {
            if (low < high)
            {
                privot = Partion(list, low, high);
                if (privot != low)
                    QuickSort(ref list, low, privot - 1);   //对中间值左边比他小的数组排序
                if (privot != high)
                    QuickSort(ref list, privot + 1, high); //对中间值右边比他大的数组排序
            }

        }
        private int Partion(int[] list, int low, int high)
        {
            int pviot = list[low];
            while (low < high)
            {
                while (low < high && list[high] > pviot)
                    high--;
                Swap(low, high, list);


                while (low < high && list[low] <= pviot)
                    low++;
                Swap(low, high, list);
            }
            return low;
        }
        /// <summary>
        /// 交换LOW与HIGH的值
        /// </summary>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <param name="list"></param>
        private void Swap(int low,int high,int[] list)
        {
            int mid = 0;
            mid = list[high];
            list[high] = list[low];
            list[low] = mid;

        }

    }
}
