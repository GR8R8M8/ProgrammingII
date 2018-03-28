using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museum_Manager
{
    public partial class Viewer : Form
    {
        public List<Artwork> art = new List<Artwork>();
        private int ind = 0;

        public Viewer(List<Artwork> _art)
        {
            art = _art;
            InitializeComponent();
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            string Name = art[0].Name;
            string Artist = art[0].ArtistName;
            int Year = art[0].Year;

            picOutput.Image = Image.FromFile(art[0].Path);
            lblArtworkName.Text = "Artwork Name: " + Name;
            lblArtist.Text = "Artist: " + Artist;
            lblYear.Text = "Year: " + Year;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ind++;

            string Name = art[ind].Name;
            string Artist = art[ind].ArtistName;
            int Year = art[ind].Year;

            picOutput.Image = Image.FromFile(art[ind].Path);
            lblArtworkName.Text = "Artwork Name: " + Name;
            lblArtist.Text = "Artist: " + Artist;
            lblYear.Text = "Year: " + Year;

            if (ind > 0)
            {
                btnPrevious.Enabled = true;
            }
            else
            {
                btnPrevious.Enabled = false;
            }

            if (ind == art.Count - 1)
            {
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            ind--;

            string Name = art[ind].Name;
            string Artist = art[ind].ArtistName;
            int Year = art[ind].Year;

            picOutput.Image = Image.FromFile(art[ind].Path);
            lblArtworkName.Text = "Artwork Name: " + Name;
            lblArtist.Text = "Artist: " + Artist;
            lblYear.Text = "Year: " + Year;

            if (ind > 0)
            {
                btnPrevious.Enabled = true;
            }
            else
            {
                btnPrevious.Enabled = false;
            }

            if (ind == art.Count - 1)
            {
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
            }
        }
    }
}
