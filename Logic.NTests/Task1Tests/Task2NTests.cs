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
        private int[][] initial = new int[5][] { new int[] { 8, 4, 7, 10, 9, 5, 20, }, null, new int[] { 1, 30, 7, 3 -30 }, null, new int[] { 15, 5, 7, 10, -15, 7 } };

        [Test]
        public void SortByRowSum_AscendentOrder_ChangedInitialArray()
        {
            int[][] expected = new int[5][] { new int[] { 1, 30, 7, 3 - 30 }, new int[] { 15, 5, 7, 10, -15, 7 }, new int[] { 8, 4, 7, 10, 9, 5, 20, }, null, null };

            ArraySort.Sort(initial, SortOrder.Ascendent, new SumCondition());

            for (int i = 0; i < initial.Length; i++)
                CollectionAssert.AreEqual(initial[i], expected[i]);

            ArraySort.Sort(initial, SortOrder.Ascendent, new SumCondition().CheckCondition);

            for (int i = 0; i < initial.Length; i++)
                CollectionAssert.AreEqual(initial[i], expected[i]);
        }

        [Test]
        public void SortByRowSum_DescendentOrder_ChangedInitialArray()
        {
            int[][] expected = new int[5][] { new int[] { 8, 4, 7, 10, 9, 5, 20, }, new int[] { 15, 5, 7, 10, -15, 7 }, new int[] { 1, 30, 7, 3 - 30 }, null, null };

            ArraySort.Sort(initial, SortOrder.Descendent, new SumCondition());

            for (int i = 0; i < initial.Length; i++)
                CollectionAssert.AreEqual(initial[i], expected[i]);

            ArraySort.Sort(initial, SortOrder.Descendent, new SumCondition().CheckCondition);

            for (int i = 0; i < initial.Length; i++)
                CollectionAssert.AreEqual(initial[i], expected[i]);
        }

        [Test]
        public void SortByMaxAbsRowElement_AscendentOrder_ChangedInitialArray()
        {
            int[][] expected = new int[5][] { new int[] { 15, 5, 7, 10, -15, 7 }, new int[] { 8, 4, 7, 10, 9, 5, 20, }, new int[] { 1, 30, 7, 3 - 30 }, null, null };

            ArraySort.Sort(initial, SortOrder.Ascendent, new AbsCondition());

            for (int i = 0; i < initial.Length; i++)
                CollectionAssert.AreEqual(initial[i], expected[i]);

            ArraySort.Sort(initial, SortOrder.Ascendent, new AbsCondition().CheckCondition);

            for (int i = 0; i < initial.Length; i++)
                CollectionAssert.AreEqual(initial[i], expected[i]);
        }

        [Test]
        public void SortByMaxAbsRowElement_DescendentOrder_ChangedInitialArray()
        {
            int[][] expected = new int[5][] { new int[] { 1, 30, 7, 3 - 30 }, new int[] { 8, 4, 7, 10, 9, 5, 20, }, new int[] { 15, 5, 7, 10, -15, 7 }, null, null };

            ArraySort.Sort(initial, SortOrder.Descendent, new AbsCondition());

            for (int i = 0; i < initial.Length; i++)
                CollectionAssert.AreEqual(initial[i], expected[i]);

            ArraySort.Sort(initial, SortOrder.Descendent, new AbsCondition().CheckCondition);

            for (int i = 0; i < initial.Length; i++)
                CollectionAssert.AreEqual(initial[i], expected[i]);
        }
    }
}
