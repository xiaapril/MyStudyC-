using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaskedTextBox
{
    ///2015/5/5   暂时不知何用
    /// <summary>
    /// Summary description for UserControl1
    /// </summary>
    public partial class MaskedTextBox : System.Windows.Forms.TextBox
    {
        private int digitPos = 0;
        private int DelimitNumber = 0;

        public MaskedTextBox()
        {
            InitializeComponent();
        }

        private void MaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskedTextBox sd = (MaskedTextBox)sender;
            sd.MaskIpAddr(e);
        }

        private void MaskIpAddr(KeyPressEventArgs e)
        {
            int len = this.Text.Length;
            int index = this.Text.LastIndexOf(".");

            //if test is highlighted reset vars
            if (this.SelectedText == this.Text)
            {
                index = -1;
                digitPos = 0;
                DelimitNumber = 0;
            }

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == 8)
            {
                //only digit,BackSpace and dot are accept
                string tmp = this.Text;
                if (e.KeyChar != 8)
                {
                    if (e.KeyChar != '.')
                    {
                        if (index > 0)
                            digitPos = len - index;
                        else
                            digitPos++;
                    }
                    if (digitPos == 3 && e.KeyChar != '.')
                    {
                        string tmp2 = this.Text.Substring(index + 1) + e.KeyChar;
                        if (Int32.Parse(tmp2) > 255) //check validation
                            MessageBox.Show("The number can't be bigger than 255 ->" + tmp2);
                        else
                        {
                            if (DelimitNumber < 3)
                            {
                                this.AppendText(e.KeyChar.ToString());
                                this.AppendText(".");
                                DelimitNumber++;
                                e.Handled = true;
                            }
                        }
                    }
                    else if (digitPos == 4 && DelimitNumber < 3)
                        this.AppendText(".");
                }
                else
                {
                    e.Handled = false;
                    if ((len - index) == 1)
                    {
                        DelimitNumber--;
                        if (index > -1)
                        {
                            digitPos = len - index;
                        }
                        else
                            digitPos--;
                    }
                    else
                    {
                        if (index > -1)
                            digitPos = len - index - 1;
                        else
                            digitPos = len - 1;
                    }
                }
            }
            else
                e.Handled = true;
        }
    }
}
