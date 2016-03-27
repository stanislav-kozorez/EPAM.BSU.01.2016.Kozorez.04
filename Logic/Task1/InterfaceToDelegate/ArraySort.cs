using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Task1.InterfaceToDelegate
{
    public enum SortOrder
    {
        Ascendent,
        Descendent
    }

    public delegate int SortDelegate(int[] arr);

    public static class ArraySort
    {
        public static void Sort(int[][] arr, SortOrder order, IConditional condition)
        {
            if (arr == null)
                throw new ArgumentNullException($"{nameof(arr)}");
            if (condition == null)
                throw new ArgumentNullException($"{nameof(condition)}");
            SortImplementation(arr, order, condition.CheckCondition);
        }

        public static void Sort(int[][] arr, SortOrder order, SortDelegate condition)
        {
            if (arr == null)
                throw new ArgumentNullException($"{nameof(arr)}");
            if (condition == null)
                throw new ArgumentNullException($"{nameof(condition)}");
            SortImplementation(arr, order, condition);
        }


        #region Private methods

        private static void SortImplementation(int[][] arr, SortOrder order, SortDelegate condition)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (order == SortOrder.Ascendent)
                    {
                        if ((arr[j] == null) || (arr[j + 1] != null && condition(arr[j]) > condition(arr[j + 1])))
                            Swap(arr, j);
                    }
                    else
                    {
                        if ((arr[j] == null) || (arr[j + 1] != null && condition(arr[j]) < condition(arr[j + 1])))
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
