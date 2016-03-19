using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Task1
{
    class AbsCondition : IConditional
    {
        public int CheckCondition(int[] arr)
        {
            return arr.Select(x => Math.Abs(x)).ToArray().Max();
        }
    }
}
