using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museum_Manager
{
    public partial class MainForm : Form
    {
        public List<Artwork> artLib = new List<Artwork>();

        private string fileName = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.png;*.jpeg;*.jpg;";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                picDisplay.Image = Image.FromFile(ofd.FileName);
            }
            else
            {
                MessageBox.Show("No image could be imported");
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Artist = txtArtist.Text;
            int Year = Convert.ToInt16(txtYear.Text);

            Artwork art = new Artwork(Name, Artist, Year, fileName);
            artLib.Add(art);
            MessageBox.Show("Added!");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Viewer view = new Viewer(artLib);
            view.ShowDialog();
        }
    }
}
