using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{


    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
        }

        private int databaseFull = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (databaseFull < 5)
                {
                    Student student = new Student(txtName.Text, Convert.ToDouble(txtGPA.Text));
                    lstDatabase.Items.Add(student.ToString());
                    databaseFull++;
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Please enter a valid GPA");
                txtName.Text = "";
                txtGPA.Text = "";
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("The number of students is exceeded");
                txtName.Text = "";
                txtGPA.Text = "";
            }
            catch
            {
                MessageBox.Show("Fatal error, exiting...");
                Application.Exit();
            }

        }
    }

    public class Student
    {
        public string name { get; set; }

        private double _gpa;
        public double gpa
        {
            get { return _gpa; }
            set
            {
                if ((value >= 0) && (value <= 4.00))
                {
                    _gpa = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public Student(string name, double gpa)
        {
            this.name = name;
            this.gpa = gpa;
        }

        public override string ToString()
        {
            return String.Format("{0}\t{1:F2}", this.name, this.gpa);
        }

    }

}
