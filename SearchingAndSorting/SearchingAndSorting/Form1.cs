using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SearchingAndSorting
{
    public partial class frmMain : Form
    {
        int[] arr = new int[] { 39, 10, 57, 1 };

        //int[] arr = new int[] {60, 73, 88, 82, 83, 44, 18, 26, 7, 100, 37, 92, 10, 19, 49, 1, 86, 13, 62, 33};

        public frmMain()
        {
            InitializeComponent();
        }

        #region UI

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int val = Convert.ToInt16(txtSearch.Text);

                if (radLinear.Checked == true)
                {
                    if (Search.LinearSearch(arr, val) == true)
                    {
                        MessageBox.Show("Found!");
                    }
                    else
                    {
                        MessageBox.Show("Not Found!");
                    }
                }
                else if (radBinary.Checked == true)
                {
                    if (Search.BinarySearch(arr, val) == true)
                    {
                        MessageBox.Show("Found!");
                    }
                    else
                    {
                        MessageBox.Show("Not Found!");
                    }
                }
                else
                {
                    MessageBox.Show("Please choose a search type!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integers only!");
            }
            catch
            {
                MessageBox.Show("Unhandled exception!");
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string fileName = Directory.GetCurrentDirectory() + "/dataToSort.txt";
            string[] numbers = new string[1000000];
            Random gen = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToString(gen.Next());
            }
            File.WriteAllLines(fileName, numbers);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Import Items";
            ofd.DefaultExt = "txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                string[] strArr = File.ReadAllLines(fileName);
                int[] intArr = Array.ConvertAll(strArr, Int32.Parse);
                Sort(intArr);
            }
            else
            {
                MessageBox.Show("Nothing could be imported!");
            }

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Sort(arr);
        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            txtOutput.Text = ArrayPrint(arr);
        }

        #endregion

        #region Methods

        private void Sort(int[] arr)
        {
            int[] _arr = (int[])arr.Clone();
            try
            {
                if (radInsertion.Checked == true)
                {
                    StandardSorts.InsertionSort(_arr);
                }
                else if (radSelection.Checked == true)
                {
                    StandardSorts.SelectionSort(_arr);
                }
                else if (radBubble.Checked == true)
                {
                    StandardSorts.BubbleSort(_arr);
                }
                else if (radMerge.Checked == true)
                {
                    RecursiveSorts.MergeSort(_arr);
                }
                else if (radQuick.Checked == true)
                {
                    RecursiveSorts.QuickSort(_arr);
                }
                else if (radBogo.Checked == true)
                {
                    StandardSorts.BogoSort(_arr);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Make sure all your numbers are integers!");
            }
            catch
            {
                MessageBox.Show("Unhandled exception!");
            }


            txtOutput.Text = ArrayPrint(_arr);
        }

        private static string ArrayPrint(int[] arr)
        {
            string result = null;

            foreach (int item in arr)
            {
                result += Convert.ToString(item) + " ";
            }

            if (arr.Length == 0)
            {
                result = "Array is empty!";
            }

            return result;
        }

        #endregion
    }
}
