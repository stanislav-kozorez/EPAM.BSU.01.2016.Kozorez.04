using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Task1.DelegateToInterface
{
    public class SumCondition: IConditional
    {
        public int CheckCondition(int[] arr)
        {
            return arr.Sum();
        }
    }
}
