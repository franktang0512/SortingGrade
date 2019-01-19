using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreSorting
{
    class Sort<T> : IComparer<T>
    {
        public static Sort<T> By(params Func<T, T, int>[] comparers)
        {
            return new Sort<T>(comparers);
        }
        public Func<T, T, int>[] Comparers { get; private set; }
        public Sort(params Func<T, T, int>[] comparers)
        {
            Comparers = comparers;
        }
        public int Compare(T x, T y)
        {
            foreach (var c in Comparers)
            {
                var r = c(x, y);
                if (r != 0)
                    return r;
            }
            return 0;
        }
    }
}
