using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Task1.DelegateToInterface
{
    public class SortCondition: IConditional
    {
        private SortDelegate sortMethod;

        public SortCondition(SortDelegate del)
        {
            if (del == null)
                throw new ArgumentNullException(nameof(del));
            sortMethod = del;
        }


        public int CheckCondition(int[] arr)
        {
            return sortMethod(arr);
        }
    }
}
