using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace toolbarApp
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Equals((object)toolStripButtonFileExit))
            {
                FileExit_Click(sender, e);
            }
            else if (e.ClickedItem.Equals((object)toolStripButtonViewRed))
            {
                ViewRed_Click(sender, e);
            }
            else if (e.ClickedItem.Equals((object)toolStripButtonViewYellow))
            {
                ViewYellow_Click(sender, e);
            }
            else if (e.ClickedItem.Equals((object)toolStripButtonViewBlue))
            {
                ViewBlue_Click(sender, e);
            }
            else
            {
                HelpAbout_Click(sender, e);
            }
        }

        
    }
}
