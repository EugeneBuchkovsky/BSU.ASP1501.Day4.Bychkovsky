using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.SortJaggedArray
{
    public delegate int IncapSort(int[] x, int[] y);

    public class MaxElementNew : ISortArray
    {
        static public int CompareCriterion(int[] x, int[] y)
        {
            if (x.Max() > y.Max())
                return 1;
            if (x.Max() < y.Max())
                return -1;
            
            return 0;

        }
        IncapSort sortWithDelegat = new IncapSort(CompareCriterion);
    }

}
