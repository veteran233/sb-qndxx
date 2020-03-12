using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace qndxx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("输入框不能为空");
            else
            {
                string filename = "http://sv.cyol.com/h5mv/" + int.Parse(textBox1.Text) + "dxx" + int.Parse(textBox2.Text) + ".mp4";

                System.Diagnostics.Process.Start(filename);
            }
        }
    }
}
