using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStuff_Click(object sender, EventArgs e)
        {
            string sentence = txtInput.Text;
            List<string> words = new List<string>(sentence.Split());

            foreach (string word in words)
            {
                lstOut.Items.Add(word);
            }
        }
    }
}
