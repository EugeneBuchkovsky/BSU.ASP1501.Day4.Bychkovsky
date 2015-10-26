using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.SortJaggedArray
{
    public interface ICriterionSort
    {
        bool Direction { get; set; }

        int[] PreporationArray(int[][] sourceArray);
    }
}
