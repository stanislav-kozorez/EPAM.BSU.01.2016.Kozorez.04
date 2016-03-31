using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Task1.DelegateToInterface
{
    public static class ArraySort
    {
        private class ComparerAdapter : IComparer<int[]>
        {
            private Comparison<int[]> comparison;
            public ComparerAdapter(Comparison<int[]> comparison)
            {
                this.comparison = comparison;
            }
            public int Compare(int[] x, int[] y)
            {
                return comparison(x, y);
            }
        }

        public static void Sort(int[][] arr, IComparer<int[]> comparer)
        {
            if (arr == null)
                throw new ArgumentNullException($"{nameof(arr)}");
            if (comparer == null)
                throw new ArgumentNullException($"{nameof(comparer)}");
            SortImplementation(arr, comparer);
        }

        public static void Sort(int[][] arr, Comparison<int[]> comparison)
        {
            if (arr == null)
                throw new ArgumentNullException($"{nameof(arr)}");
            if (comparison == null)
                throw new ArgumentNullException($"{nameof(comparison)}");
            SortImplementation(arr, new ComparerAdapter(comparison));
        }


        #region Private methods

        private static void SortImplementation(int[][] arr, IComparer<int[]> comparer)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (comparer.Compare(arr[j], arr[j + 1]) < 0)
                        Swap(arr, j);
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
