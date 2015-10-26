using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.SortJaggedArray
{
    public class CriterionMaxElement : ICriterionSort
    {
        private bool direction;

        public bool Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public CriterionMaxElement(bool dir)
        {
            this.Direction = dir;
        }

        public int[] PreporationArray(int[][] sourceArray)
        {
            int[] finalArray = new int[sourceArray.Length];
            for (var i = 0; i < finalArray.Length; i++)
            {
                if (sourceArray[i] != null)
                    foreach (int num in sourceArray[i])
                    {
                        if (Math.Abs(num) > finalArray[i])
                        finalArray[i] = num;
                    }
            }
            return finalArray;
        }
    }
}
