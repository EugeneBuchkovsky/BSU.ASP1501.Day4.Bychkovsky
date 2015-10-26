using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.SortJaggedArray
{
    public static class SortJaggedArray
    {
        public static void SortArray(this int[][] sourceArray, ICriterionSort criterion)
        {
            SortLogic.Sort(sourceArray, criterion.PreporationArray(sourceArray), criterion.Direction);
        }
    }
}
