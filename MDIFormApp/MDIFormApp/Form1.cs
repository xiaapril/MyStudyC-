using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDIFormApp
{
    public partial class Form1 : Form
    {
        private static int FormCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void FileNew_Click(object sender, EventArgs e)
        {
            Form frmTemp = new Form();
            frmTemp.MdiParent = this;
            frmTemp.Text = "Window#" + FormCount.ToString();
            FormCount++;
            frmTemp.Show();
        }

        private void FileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void WindowHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void WindowVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
