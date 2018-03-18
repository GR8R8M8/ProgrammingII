using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAndSorting
{
    public class Sorts
    {
        public int[] arr { get; set; }

        public Sorts(int[] _arr = null)
        {
            arr = _arr;
        }

        public virtual int[] ArrSort()
        {
            return arr;
        }
    }
}
