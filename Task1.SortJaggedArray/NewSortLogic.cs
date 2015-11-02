using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.SortJaggedArray
{
    //public delegate int IncapSort(int[] x, int[] y);

    public static class NewSortLogic
    {
        public static void Sort(this int[][] sourceArray, ISortArray sorter)
        {
            for (int i = 0; i < sourceArray.Length - 1; i++)
                for (int j = 0; j < sourceArray.Length - i - 1; j++)
                {
                    if (sorter.CompareCriterion(sourceArray[j], sourceArray[j + 1]) > 0)
                    {
                        int[] temp = (int[])sourceArray[j].Clone();
                        sourceArray[j] = sourceArray[j + 1];
                        sourceArray[j + 1] = temp;
                    }
                }
        }
    }
}
