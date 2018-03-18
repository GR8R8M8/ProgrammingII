using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchingAndSorting
{
    public class MergeSort : Sorts
    {
        public MergeSort(int[] arr) : base(arr) { }

        public override int[] ArrSort()
        {
            MSort(arr, 0, arr.Length - 1);
            return arr;
        }

        private long MSort(int[] arr, int low, int high)
        {
            if (low == high)
            {
                return 0;
            }
            else
            {
                long inversionCount = 0;
                int middle = (low / 2) + (high / 2);

                inversionCount += MSort(arr, low, middle);
                inversionCount += MSort(arr, middle + 1, high);
                inversionCount += Merge(arr, low, middle, high);

                return inversionCount;
            }
        }

        private long Merge(int[] arr, int low, int middle, int high)
        {
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;
            int left = low;
            int right = middle + 1;
            long inversionCount = 0;

            while ((left <= middle) && (right <= high))
            {
                if (arr[left] > arr[right])
                {
                    tmp[tmpIndex] = arr[right];
                    inversionCount += ((middle - left) + 1);
                    right++;
                }
                else
                {
                    tmp[tmpIndex] = arr[left];
                    left++;
                }

                tmpIndex++;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = arr[left];
                    left++;
                    tmpIndex++;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = arr[right];
                    right++;
                    tmpIndex++;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                arr[low + i] = tmp[i];
            }

            return inversionCount;

        }
    }

    public class QuickSort : Sorts
    {
        public QuickSort(int[] arr) : base(arr) { }

        public override int[] ArrSort()
        {
            return QSort(arr, 0, arr.Length - 1);
        }

        private int[] QSort(int[] arr, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (arr[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QSort(arr, left, j);
            }

            if (i < right)
            {
                QSort(arr, i, right);
            }

            return arr;

        }
    }
}
