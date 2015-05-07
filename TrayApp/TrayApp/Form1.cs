using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrayApp
{
    public partial class Form1 : Form
    {
        private Icon m_Icon1;
        private Icon m_Icon2;
        private bool m_bTrayFlag;
        private bool m_bIconFlag;

        public Form1()
        {
            InitializeComponent();

            m_bTrayFlag = false;
            m_bIconFlag = true;

            menuItem4.Enabled = false;

            try
            {
                m_Icon1 = new Icon("Icon1.ico");
                m_Icon2 = new Icon("Icon2.ico");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message, "Animate Tray - Error");
                menuItem4.Enabled = false;
                menuItem1.Enabled = false;
            }
        }

        private void m_trayIcon_DoubleClick(object sender, EventArgs e)
        {
            if (m_bTrayFlag == true)
            {
                this.Activate();
                this.Show();
                this.Refresh();
                m_bTrayFlag = false;
            }
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            m_timer.Stop();
            menuItem4.Enabled = false;
            menuItem1.Enabled = true;
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
           // AboutDlg dlg = new AboutDlg();
           // dlg.ShowDialog(this);
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            m_timer.Start();
            menuItem4.Enabled = false;
            menuItem1.Enabled = true;
        }

        private void m_timer_Tick(object sender, EventArgs e)
        {

        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            m_trayIcon.Dispose();
            this.Close();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

       
    }
}
