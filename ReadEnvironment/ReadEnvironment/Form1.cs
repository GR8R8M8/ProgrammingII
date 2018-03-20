using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadEnvironment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperatingSystem opSys = Environment.OSVersion;
            PlatformID opSysID = opSys.Platform;

            string[] logicalDrives = Environment.GetLogicalDrives();
            string driveString = "";
            foreach (string drive in logicalDrives)
            {
                driveString += drive + " ";
            }

            listBox1.Items.Add("Operating System:\t\t"+ opSys);
            listBox1.Items.Add("Operating SYstem ID:\t" + opSysID);
            listBox1.Items.Add("Common Language Runtime:\t" + Environment.Version);
            listBox1.Items.Add("MachineName:\t\t" + Environment.MachineName);
            listBox1.Items.Add("");
            listBox1.Items.Add("User ID:\t\t\t" + Environment.UserName);
            listBox1.Items.Add("Current Directory:\t\t" + Environment.CurrentDirectory);
            listBox1.Items.Add("Drives Present:\t\t" + driveString);

        }
    }
}
