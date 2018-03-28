using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLati
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            string sentence = txtText.Text;
            List<string> words = new List<string>(sentence.Split());
            StringBuilder sb = new StringBuilder();
            foreach (string word in words)
            {
                sb.Append(PigConvert(word) + " ");
            }

            lblOutput.Text = sb.ToString();
        }

        public string PigConvert(string word)
        {
            string result = string.Empty;
            string pigSuffixVowelFirst = "yay";
            string pigSuffixConstanantsFirst = "ay";

            string vowels = "aeiouAEIOU";

            if (vowels.Contains(word.First()))
            {
                result = word + pigSuffixVowelFirst;
            }
            else
            {
                int count = 0;
                string end = string.Empty;
                foreach (char c in word)
                {
                    if (!vowels.Contains(c))
                    {
                        end += c;
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                result = word.Substring(count) + end + pigSuffixConstanantsFirst;
            }
            return result;
        }




    }
}
