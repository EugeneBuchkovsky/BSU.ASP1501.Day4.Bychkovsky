using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.SortJaggedArray
{
    class SortLogic
    {
        public static void Sort(int[][] sourceArray, int[] arrayValues, bool direction)
        {
            for (int i = 0; i < arrayValues.Length - 1; i++)
                for (int j = 0; j < arrayValues.Length - i - 1; j++)
                {
                    if ((arrayValues[j] > arrayValues[j + 1]) == direction || sourceArray[j] == null)
                    {
                        int temp = arrayValues[j];
                        arrayValues[j] = arrayValues[j + 1];
                        arrayValues[j + 1] = temp;

                        int[] tempArray = sourceArray[j];
                        sourceArray[j] = sourceArray[j + 1];
                        sourceArray[j + 1] = tempArray;
                    }
                }
        }
    }
}
