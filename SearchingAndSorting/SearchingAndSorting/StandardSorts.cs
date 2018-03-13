using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            int count = 0;

            while (!IsSorted(arr))
            {
                Shuffle(arr);
                count++;
            }

            MessageBox.Show("That took " + count + " tries");
            return arr;

        }

        static int[] Shuffle(int[] arr)
        {
            int temp;
            int rnd;
            Random rand = new Random();

            for (int i = 0; i < arr.Length; ++i)
            {
                rnd = rand.Next(arr.Length);
                temp = arr[i];
                arr[i] = arr[rnd];
                arr[rnd] = temp;
            }

            return arr;
        }

        private static void Swap(int[] arr, int item1, int item2)
        {
            int temp = arr[item1];
            arr[item1] = arr[item2];
            arr[item1] = temp;
        }

        private static bool IsSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
    }
}
