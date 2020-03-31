using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;

namespace qndxx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void crawler()
        //{
        //    ScriptEngine engine = Python.CreateEngine();
        //    ScriptScope scope = engine.CreateScope();

        //    //var t = engine.GetSearchPaths();

        //    scope.SetVariable("ans", 0);

        //    ScriptSource source = engine.CreateScriptSourceFromFile(@"pachong.py");
        //    source.Execute(scope);

        //    var result = scope.GetVariable("ans");
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("输入框不能为空");
            else
            {
                //string filename = "http://dxx.wwwtop.top/dxx_video?a=" + textBox1.Text + "&b=" + textBox2.Text + "&c=2&d=1";
                string filename = "http://sv.cyol.com/h5mv/" + textBox1.Text + "dxx" + textBox2.Text + ".mp4";

                System.Diagnostics.Process.Start(filename);
            }
        }
    }
}
