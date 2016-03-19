using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Task1
{
    public enum SortOrder
    {
        Ascendent,
        Descendent
    }

    public static class ArraySort
    {

        /// <summary>
        /// Sorts the array in ascendent/descendent order by the sum of each row
        /// </summary>
        public static void SortByRowSum(int[][] arr, SortOrder order)
        {
            if (arr == null)
                throw new ArgumentNullException($"{nameof(arr)}");
            Sort(arr, order, new SumCondition());
        }

        /// <summary>
        /// Sorts the array in ascendent/descendent order by maximum absolut element of each row
        /// </summary>
        public static void SortByMaxAbsRowElement(int[][] arr, SortOrder order)
        {
            if (arr == null)
                throw new ArgumentNullException($"{nameof(arr)}");
            Sort(arr, order, new AbsCondition());
        }

        #region Private methods

        private static void Sort(int[][] arr, SortOrder order, IConditional condinion)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (order == SortOrder.Ascendent)
                    {
                        if ((arr[j] == null) || (arr[j + 1] != null && condinion.CheckCondition(arr[j]) > condinion.CheckCondition(arr[j + 1])))
                            Swap(arr, j);
                    }
                    else
                    {
                        if ((arr[j] == null) || (arr[j + 1] != null && condinion.CheckCondition(arr[j]) < condinion.CheckCondition(arr[j + 1])))
                            Swap(arr, j);
                    }
        }

        private static void Swap(int[][] arr, int index)
        {
            int[] temp = arr[index];
            arr[index] = arr[index + 1];
            arr[index + 1] = temp;
        }

        #endregion
    }
}
