using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.SortJaggedArray
{
    public interface ICriterionSort
    {
        /// <summary>
        /// Property for indicate ascending (true) of descending (false)
        /// </summary>
        bool Direction { get; set; }

        /// <summary>
        /// Method for indicate sorting function.
        /// </summary>
        /// <param name="sourceArray"></param>
        /// <returns></returns>
        new int[] PreporationArray(int[][] sourceArray);
    }
}
