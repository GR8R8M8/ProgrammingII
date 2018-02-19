using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                btnStart.Text = "Stop";
                tmrChanger.Start();
            }
            else
            {
                btnStart.Text = "Start";
                tmrChanger.Stop();
            }
        }

        private void tmrChanger_Tick(object sender, EventArgs e)
        {
            Random gen = new Random();
            int r = gen.Next(256);
            int g = gen.Next(256);
            int b = gen.Next(256);
            Color col = Color.FromArgb(r, g, b);
            BackColor = col; 
        }

    }
}
