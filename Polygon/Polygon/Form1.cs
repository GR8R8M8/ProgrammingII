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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            ETriangle triangle = new ETriangle(Convert.ToDouble(txtInput.Text));
            Square square = new Square(Convert.ToDouble(txtInput.Text));
            Pentagon pentagon = new Pentagon(Convert.ToDouble(txtInput.Text));
            Hexagon hexagon = new Hexagon(Convert.ToDouble(txtInput.Text));
            Octagon octagon = new Octagon(Convert.ToDouble(txtInput.Text));

            lblOutput.Text = String.Format("Triangle: {0} \nSquare: {1} \nPentagon: {2} \nHexagon: {3} \nOctagon: {4}", Math.Round(triangle.getArea(), 2), Math.Round(square.getArea(), 2), Math.Round(pentagon.getArea(), 2), Math.Round(hexagon.getArea(), 2), Math.Round(octagon.getArea(), 2));

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
        #endregion =

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
                return ((3 * Math.Sqrt(3))/2) * (this.side * this.side);
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


}
