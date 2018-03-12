using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAndSorting
{
    public static class StandardSorts
    {
        #region InsertionSort
        public static int[] InsertionSort(int[] arr)
        {
            int insertVal;

            for (int next = 1; next < arr.Length; next++)
            {
                insertVal = arr[next];
                int move = next;
                while (move > 0 && arr[move - 1] > insertVal)
                {
                    arr[move] = arr[move - 1];
                    move--;
                }
                arr[move] = insertVal;
            }

            return arr;
        }
        #endregion

        #region SelectionSort
        public static int[] SelectionSort(int[] arr)
        {
            int smallestVal;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                smallestVal = i;
                for (int index = i + 1; index < arr.Length; index++)
                {
                    if (arr[index] < arr[smallestVal])
                    {
                        smallestVal = index;
                    }
                }

                if (smallestVal != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[smallestVal];
                    arr[smallestVal] = temp;
                }
            }

            return arr;
        }
        #endregion

        #region BubbleSort
        public static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int numSwaps = 0;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        numSwaps++;
                    }
                }

                if (numSwaps == 0)
                {
                    break;
                }
            }

            return arr;
        }
        #endregion

        #region BogoSort
        public static int[] BogoSort(int[] arr)
        {
            List<int> _list = arr.OfType<int>().ToList();
            Sort(_list);
            int[] _arr = _list.ToArray();
            return _arr;
        }

        private static void Sort<T>(List<T> list) where T : IComparable
        {
            while (!list.isSorted())
            {
                list.Shuffle();
            }
        }

        private static bool isSorted<T>(this IList<T> list) where T : IComparable
        {
            if (list.Count <= 1)
            {
                return true;
            }

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(list[i - 1]) < 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void Shuffle<T>(this IList<T> list)
        {
            Random rand = new Random();
            for (int i = 0; i < list.Count; i++)
            {
                int swapIndex = rand.Next(list.Count);
                T temp = list[swapIndex];
                list[swapIndex] = list[i];
                list[i] = temp;
            }
        }
        #endregion
    }
}
