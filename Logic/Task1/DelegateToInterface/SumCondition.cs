﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Task1.DelegateToInterface
{
    public class SumCondition: IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;
            if (x.Sum() < y.Sum())
                return 1;
            else if (x.Sum() > y.Sum())
                return -1;
            else
                return 0;
        }
    }
}
