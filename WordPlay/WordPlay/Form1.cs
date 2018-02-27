using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPlay
{
    public partial class Form1 : Form
    {
        string[] nouns = { "teacher", "bird", "ape", "fish" };
        string[] adjectives = { "shiny", "old", "pink", "stinky" };
        string[] adverbs = { "gently", "hesitantly", "confidently", "loudly" };
        string[] verbs = { "ran", "jumped", "swam", "flew" };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            Random gen = new Random();
            lblOutput.Text = String.Format("{0} {1} {2} {3}", nouns[gen.Next(0, nouns.Length)],
                adjectives[gen.Next(0, adjectives.Length)], adverbs[gen.Next(0, adverbs.Length)],
                verbs[gen.Next(0, verbs.Length)]);

        }
    }
}
