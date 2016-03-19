using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Logic.Task1;

namespace Logic.NTests
{
    [TestFixture]
    public class Task2NTests
    {
        private int[][] initial = new int[5][] { new int[] { 8, 4, 7, 10, 9, 5, 20, }, null, new int[] { 1, 7, 3 }, null, new int[] { 5, 7, 10, 7 } };

        [Test]
        public void SortByRowSum_AscendentOrder_ChangedInitialArray()
        {
            int[][] expected = new int[5][] { new int[] { 1, 7, 3 }, new int[] { 5, 7, 10, 7 }, new int[] { 8, 4, 7, 10, 9, 5, 20, }, null, null };

            ArraySort.SortByRowSum(initial, SortOrder.Ascendent);

            for (int i = 0; i < initial.Length; i++)
                CollectionAssert.AreEqual(initial[i], expected[i]);
        }

        [Test]
        public void SortByRowSum_DescendentOrder_ChangedInitialArray()
        {
            int[][] expected = new int[5][] { new int[] { 8, 4, 7, 10, 9, 5, 20, }, new int[] { 5, 7, 10, 7 }, new int[] { 1, 7, 3 }, null, null };

            ArraySort.SortByRowSum(initial, SortOrder.Descendent);

            for (int i = 0; i < initial.Length; i++)
                CollectionAssert.AreEqual(initial[i], expected[i]);
        }

        [Test]
        public void SortByMaxRowElement_AscendentOrder_ChangedInitialArray()
        {
            int[][] expected = new int[5][] { new int[] { 1, 7, 3 }, new int[] { 5, 7, 10, 7 }, new int[] { 8, 4, 7, 10, 9, 5, 20, }, null, null };

            ArraySort.SortByMaxAbsRowElement(initial, SortOrder.Ascendent);

            for (int i = 0; i < initial.Length; i++)
                CollectionAssert.AreEqual(initial[i], expected[i]);
        }

        [Test]
        public void SortByMaxRowElement_DescendentOrder_ChangedInitialArray()
        {
            int[][] expected = new int[5][] { new int[] { 8, 4, 7, 10, 9, 5, 20, }, new int[] { 5, 7, 10, 7 }, new int[] { 1, 7, 3 }, null, null };

            ArraySort.SortByMaxAbsRowElement(initial, SortOrder.Descendent);

            for (int i = 0; i < initial.Length; i++)
                CollectionAssert.AreEqual(initial[i], expected[i]);
        }
    }
}
