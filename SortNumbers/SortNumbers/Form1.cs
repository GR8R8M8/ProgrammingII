using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortNumbers
{
    public partial class Form1 : Form
    {
        List<int> negList = new List<int>();
        List<int> evenList = new List<int>();
        List<int> oddList = new List<int>();
        private int c = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (c < 9)
            {
                int n = Convert.ToInt16(txtInput.Text);
                if (Math.Sign(n) == -1)
                {
                    negList.Add(n);
                }
                else if (n % 2 == 0)
                {
                    evenList.Add(n);
                }
                else
                {
                    oddList.Add(n);
                }

                txtInput.Text = null;
            }
            else if (c == 9)
            {
                btnEnter.Enabled = false;

                int n = Convert.ToInt16(txtInput.Text);
                if (Math.Sign(n) == -1)
                {
                    negList.Add(n);
                }
                else if (n % 2 == 0)
                {
                    evenList.Add(n);
                }
                else
                {
                    oddList.Add(n);
                }

                foreach (int num in evenList)
                {
                    lblEven.Text += String.Format(" {0}", num);
                }

                foreach (int num in oddList)
                {
                    lblOdd.Text += String.Format(" {0}", num);
                }

                foreach (int num in negList)
                {
                    lblNegative.Text += String.Format(" {0}", num);
                }
            }
            c++;
            lblEntries.Text = String.Format("Number of entries: {0}", c);
        }
    }
}
