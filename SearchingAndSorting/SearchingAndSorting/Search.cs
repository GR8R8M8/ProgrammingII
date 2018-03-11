using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAndSorting
{
    public class Search
    {
        #region LinearSearch
        public static bool LinearSearch(int[] arr, int val)
        {
            foreach (int num in arr)
            {
                if (val == num)
                {
                    return true;
                }
            }

            return false;
        }
        #endregion

        #region BinarySearch
        public static bool BinarySearch(int[] arr, int val)
        {
            int[] _arr = (int[]) arr.Clone();

            int min = 0;
            int max = _arr.Length - 1;
            int mid = (min + max) / 2;
            int index = -1;

            do
            {
                if (_arr[mid] == val)
                {
                    return true;
                }
                else if (_arr[mid] < val)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                    mid = (min + max) / 2;
                }
            } while ((min <= max) && (index == -1));

            return false;
        }
        #endregion
    }
}
