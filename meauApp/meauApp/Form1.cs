using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace meauApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void ViewYellow_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void ViewBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void HelpAbout_Click(object sender, EventArgs e)
        {

        }

        private void selfdefine_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = meauApp.Properties.Resources.backColor;

        }
    }
}
