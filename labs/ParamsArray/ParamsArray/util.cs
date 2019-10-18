using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class util
    {
        public static int Sum(params int[] paramList)
        {
            int sumTotal = 0;
            if (paramList == null)
                throw new ArgumentException("Util.Sum: null parameter list");
            if (paramList.Length == 0)
                throw new ArgumentException("Util.Sum: empty parameter list");
            foreach (int i in paramList)
                sumTotal += i;
            return sumTotal;
        }
    }
}
