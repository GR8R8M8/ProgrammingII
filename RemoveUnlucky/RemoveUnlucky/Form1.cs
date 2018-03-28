using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoveUnlucky
{
    public partial class Form1 : Form
    {
        List<int> lint = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random gen = new Random();
            for (int i = 0; i < 10; i++)
            {
                int n = gen.Next(1, 101);
                lint.Add(n);
                lblOut.Text += " " + n;
                
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                lint.Remove(Convert.ToInt16(textBox1.Text));
                lblOut.Text = null;
                foreach (int n in lint)
                {
                    lblOut.Text += " " + n;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter numerical values only!");
            }

        }
    }
}
