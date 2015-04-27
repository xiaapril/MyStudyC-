using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myFirstWinApp
{
    //第一个windows应用程序
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txt_input.Text, "hello");
        }

        /// <summary>
        /// The main entry point for the application
        /// </summary>
        [STAThread]
        static void main()
        {
            Application.Run(new Form1());
        }

    }
}
