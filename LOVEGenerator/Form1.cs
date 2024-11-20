using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOVEGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name1 = textBox1.Text;
            string name2 = textBox2.Text;
            if(name1 == string.Empty)
            {
                label3.Text = "ERROR:nonameontextbox";
            }else if (name1 == "Elmurod" || name2 == "Fazilat")
            {
                string v = "101%";
                label3.Text = v;
            }
            else if(name2 == string.Empty)
            {
                label3.Text = "ERROR:nonameontextbox";
            }
            else
            {
                int loveprersentage = CalculateLovePercentage(name1, name2);
                label3.Text = name1 + " and " + name2 + " are " + loveprersentage + "% ";
            }
        }
        private int CalculateLovePercentage(string name1, string name2)
        {
            int loveprersentage = 0;
            int name1length = name1.Length;
            int name2length = name2.Length;

            for (int i = 0; i < name1length; i++)
            {
                for (int j = 0; j < name2length; j++)
                {
                    if (name1[i] == name2[j])
                    {
                        loveprersentage += 35;
                    }
                }
            }
            if(name1length == name2length)
            {
                loveprersentage += 20;
            }
            if (name1.Equals(name2, StringComparison.OrdinalIgnoreCase))
            {
                loveprersentage += 30;
            }
            return Math.Min(100, loveprersentage);
        }

    }
}
