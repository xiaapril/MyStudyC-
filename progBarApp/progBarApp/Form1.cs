using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace progBarApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Elapsed(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 200)
            {
                progressBar1.Value = 0;
                return;
            }
            progressBar1.Value += 20;
        }
    }
}
