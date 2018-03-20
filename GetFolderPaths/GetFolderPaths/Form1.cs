using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetFolderPaths
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Windows System:\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.System));
            listBox1.Items.Add("Program Files:\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
            listBox1.Items.Add("Desktop Folder:\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
            listBox1.Items.Add("Favorites:\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.Favorites));
            listBox1.Items.Add("History:\t\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.History));

            listBox1.Items.Add("My Documents:\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            listBox1.Items.Add("Programs:\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.Programs));
            listBox1.Items.Add("Recent Files:\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.Recent));
            listBox1.Items.Add("Send To Folder:\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.SendTo));
            listBox1.Items.Add("Start Menu:\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.StartMenu));

            listBox1.Items.Add("Start Files:\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.Startup));
            listBox1.Items.Add("System Files:\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.System));
            listBox1.Items.Add("Application Files:\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            listBox1.Items.Add("Common Application Files:\t" + Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
            listBox1.Items.Add("Local Application Files:\t" + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

            listBox1.Items.Add("Cookies:\t\t\t" + Environment.GetFolderPath(Environment.SpecialFolder.Cookies));

        }
    }
}
