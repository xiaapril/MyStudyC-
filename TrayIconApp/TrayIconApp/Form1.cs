using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrayIconApp
{
    public partial class TrayIcon : Form
    {
        public TrayIcon()
        {
            InitializeComponent();
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            if (!this.Visible)
                this.Show();
        }

        private void minimise_Click(object sender, EventArgs e)
        {
            if (this.Visible)
                this.Hide();
        }

        private void helpme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("版权所有：******  2001");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
