using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLines
{
    public partial class Form1 : Form
    {
        Coordinates[] coords = new Coordinates[10];
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            Graphics surface = this.CreateGraphics();
            Pen penBlue = new Pen(Color.Blue, 5);

            for (int i = 0; i < count - 1; i++)
            {
                surface.DrawLine(penBlue, coords[i].x, coords[i].y, coords[i+1].x, coords[i+1].y);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (count > 9)
            {
                lblOutput.Text = "There is no more room left in your array!";
            }
            else
            {
                Coordinates coord = new Coordinates(e.X, e.Y);
                lblOutput.Text = String.Format("Your coordinates for point {0} are X:{1} Y:{2}",count ,e.X, e.Y);
                coords[count] = coord;
                count++;
            }
        }
    }

    public struct Coordinates
    {
        public int x { get; set; }
        public int y { get; set; }

        public Coordinates(int pt1, int pt2)
        {
            x = pt1;
            y = pt2;
        }

    }

}
