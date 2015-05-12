using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace diy
{
    public partial class Form1 : Form
    {
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            txtBox.Text = "你已经点击了" + count + "次";
            this.BackColor = Color.IndianRed;
            txtBox.BackColor = Color.Cyan;
        }
    }
}
