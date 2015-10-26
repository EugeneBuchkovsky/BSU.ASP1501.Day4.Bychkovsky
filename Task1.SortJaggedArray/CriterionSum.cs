using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.SortJaggedArray
{
    public class CriterionSum : ICriterionSort
    {
        private bool direction;

        public bool Direction
        {
            get{return direction;}
            set { direction = value; } 
        }

        public CriterionSum(bool dir)
        {
            Direction = dir;
        }

        public int[] PreporationArray(int[][] sourceArray)
        {
            int[] finalArray = new int[sourceArray.Length];
            for (var i = 0; i < finalArray.Length; i++)
            {
                if (sourceArray[i] != null)
                    finalArray[i] = sourceArray[i].Sum();
            }
            return finalArray;
        }
    }
}
