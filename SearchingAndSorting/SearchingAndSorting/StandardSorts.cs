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
    public class InsertionSort : Sorts
    {
        public InsertionSort(int[] arr) : base(arr) {}

        public override int[] ArrSort()
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
    }

    public class SelectionSort : Sorts
    {
        public SelectionSort(int[] arr) : base(arr) { }

        public override int[] ArrSort()
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
    }

    public class BubbleSort : Sorts
    {
        public BubbleSort(int[] arr) : base(arr) { }

        public override int[] ArrSort()
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
    }

    public class BogoSort : Sorts
    {
        public BogoSort(int[] arr) : base(arr) { }

        public override int[] ArrSort()
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

        private int[] Shuffle(int[] arr)
        {
            Random rand = new Random();

            for (int i = 0; i < arr.Length; ++i)
            {
                int temp;
                int rnd;
                rnd = rand.Next(arr.Length);
                temp = arr[i];
                arr[i] = arr[rnd];
                arr[rnd] = temp;
            }

            return arr;
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

    }
}
