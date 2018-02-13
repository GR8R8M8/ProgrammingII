using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Polygon
{
    public partial class Form1 : Form
    {

        List<Polygon> shapes = new List<Polygon>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {

            if (radTriangle.Checked == true)
            {
                shapes.Add(new ETriangle(Convert.ToDouble(txtInput.Text)));
            }            
            else if (radSquare.Checked == true)
            {
                shapes.Add(new Square(Convert.ToDouble(txtInput.Text)));
            }
            else if (radPentagon.Checked == true)
            {
                shapes.Add(new Pentagon(Convert.ToDouble(txtInput.Text)));
            }
            else if (radHexagon.Checked == true)
            {
                shapes.Add(new Hexagon(Convert.ToDouble(txtInput.Text)));
            }
            else if (radOctagon.Checked == true)
            {
                shapes.Add(new Octagon(Convert.ToDouble(txtInput.Text)));
            }

            txtInput.Text = "";

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double totalArea = 0;

            foreach (Polygon shape in shapes)
            {
                lblOutput.Text += String.Format("The area of your {0} is: {1:F2}\n", shape.GetType().Name,shape.getArea());
                totalArea += shape.getArea();
            }

            lblOutput.Text += String.Format("The total area of all your polygons is: {0:F2}", totalArea);

        }
    }

    #region Polygon
    abstract class Polygon
    {
        protected double side { get; set; }

        public Polygon(double side = 0)
        {
            this.side = side;
        }

        abstract public double getArea();
    }
    #endregion

    #region ETriangle : Polygon
    class ETriangle : Polygon
    {

        public ETriangle(double side = 0) : base(side) { }

        public override double getArea()
        {
            return (Math.Sqrt(3) / 4) * (this.side * this.side);
        }
    }
    #endregion

    #region Square : Polygon
    class Square : Polygon
    {
        public Square(double side = 0) : base(side) { }

        public override double getArea()
        {
            return this.side * this.side;
        }
    }
    #endregion

    #region Pentagon : Polygon
    class Pentagon : Polygon
    {
        public Pentagon(double side = 0) : base(side) { }

        public override double getArea()
        {
            return (.25 * (Math.Sqrt(5 * (5 + (2 * Math.Sqrt(5)))))) * (this.side * this.side);
        }
    }
    #endregion

    #region Hexagon : Polygon
    class Hexagon : Polygon
    {
        public Hexagon(double side = 0) : base(side) { }

        public override double getArea()
        {
            return ((3 * Math.Sqrt(3)) / 2) * (this.side * this.side);
        }
    }
    #endregion

    #region Octagon : Polygon
    class Octagon : Polygon
    {
        public Octagon(double side = 0) : base(side) { }

        public override double getArea()
        {
            return 2 * (1 + Math.Sqrt(2)) * (this.side * this.side);
        }
    }
    #endregion

}
