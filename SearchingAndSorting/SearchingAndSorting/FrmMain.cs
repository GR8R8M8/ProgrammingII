using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SearchingAndSorting
{
    public partial class frmMain : Form
    {
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();

        private readonly int[] arr = {60, 73, 88, 82, 83, 44, 18, 26, 7, 100, 37, 92, 10, 19, 49, 1, 86, 13, 62, 33};
        private string path;

        public frmMain()
        {
            FreeConsole();
            InitializeComponent();
        }

        #region UI

        private void picClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Sort(arr);
        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            ArrayPrint(arr);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int val = Convert.ToInt16(txtSearch.Text);

                if (radLinear.Checked)
                {
                    if (Search.LinearSearch(arr, val))
                    {
                        MessageBox.Show("Found!");
                    }
                    else
                    {
                        MessageBox.Show("Not Found!");
                    }
                }
                else if (radBinary.Checked)
                {

                    if (Search.BinarySearch(arr, val))
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
            try
            {
                var len = Convert.ToInt32(Interaction.InputBox("Enter the number of integers to be generated"));
                var fileName = Directory.GetCurrentDirectory() + "/dataToSort.txt";
                var numbers = new string[len];
                var gen = new Random();

                for (var i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToString(gen.Next());
                    File.WriteAllLines(fileName, numbers);
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

        private void btnImport_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Title = "Import Items",
                DefaultExt = "txt"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Thread sortThread = new Thread(() => ImportThread(ofd));
                sortThread.IsBackground = true;
                sortThread.Start();
            }
            else
            {
                MessageBox.Show("Nothing could be imported!");
            }
        }

        private void btnOriginalFile_Click(object sender, EventArgs e)
        {
            try
            {
                string[] strArr = File.ReadAllLines(path);
                int[] intArr = Array.ConvertAll(strArr, int.Parse);
                Thread printThread = new Thread(() => ArrayPrint(intArr));
                printThread.IsBackground = true;
                printThread.Start();
                printThread.Join();
            }
            catch
            {
                MessageBox.Show("You must have previously imported a file!");
            }
        }

        #endregion

        #region Methods

        private void Sort(int[] arr)
        {
            try
            {
                int[] _arr = (int[]) arr.Clone();

                if (radInsertion.Checked)
                {
                    SortThread(new InsertionSort(_arr));
                }
                else if (radSelection.Checked)
                {
                    SortThread(new SelectionSort(_arr));
                }
                else if (radBubble.Checked)
                {
                    SortThread(new BubbleSort(_arr));
                }
                else if (radMerge.Checked)
                {
                    SortThread(new MergeSort(_arr));
                }
                else if (radQuick.Checked)
                {
                    SortThread(new QuickSort(_arr));
                }
                else if (radBogo.Checked)
                {
                    SortThread(new BogoSort(_arr));
                }
                else
                {
                    MessageBox.Show("Make sure you have a sort type selected!");
                }

                ArrayPrint(_arr);

            }
            catch (FormatException)
            {
                MessageBox.Show("Make sure all your numbers are integers!");
            }
            catch
            {
                MessageBox.Show("Unhandled exception!");
            }
        }

        private int[] SortThread(Sorts o)
        {
            object arr = null;
            Thread sortThread = new Thread(() => { arr = o.ArrSort(); });
            sortThread.Start();
            sortThread.Join();
            int[] _arr = (int[]) arr;
            return _arr;
        }

        private void ImportThread(OpenFileDialog ofd)
        {
            path = ofd.FileName;
            string[] strArr = File.ReadAllLines(path);
            int[] intArr = Array.ConvertAll(strArr, int.Parse);
            Sort(intArr);
        }

        private void ArrayPrint(int[] arr)
        {
            string result = null;
            if (arr == null)
            {
                AllocConsole();
                Console.WriteLine("There is nothing in the array!");
            }
            else
            {
                foreach (int item in arr)
                {
                    result += Convert.ToString(item) + " ";
                }
            }
        }

        #endregion
    }
}