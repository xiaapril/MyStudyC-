using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ipBox
{
    /// <summary>
    /// 自主编写控件，生成.dll文件，功能模块化
    /// </summary>
    public partial class ipBox : TextBox
    {
        private int digitPos = 0;
        private int DelimitNumber = 0;

        public ipBox()
        {
            InitializeComponent();
        }

        private void ipBox_Load(object sender, EventArgs e)
        {

        }

        private void ipBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ipBox sd = (ipBox)sender;
            sd.MaskIpAddr(e);
        }

        private void MaskIpAddr(KeyPressEventArgs e)
        {
            int len = this.Text.Length;
            int indx = this.Text.LastIndexOf(".");
            // if test is highlighted reset vars
            if(this.SelectedText == this.Text) 
            {
                indx=-1;
                digitPos=0;
                DelimitNumber=0;
            }
            if(Char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == 8)
            { // only digit, Backspace and dot are accepted
                string tmp = this.Text;
                if (e.KeyChar != 8)
                {
                    if (e.KeyChar != '.' )
                    {
                        if(indx > 0)
                            digitPos = len-indx;
                        else
                            digitPos++;	
                    }
                    if(digitPos == 3 && e.KeyChar != '.')
                    {
                        string tmp2 = this.Text.Substring(indx+1)+e.KeyChar;
                        if(Int32.Parse(tmp2)> 255) // check validation
                            MessageBox.Show("The number can't be bigger than 255 -> " + tmp2);
                        else
                        {
                            if (DelimitNumber<3)
                            {
                                this.AppendText(e.KeyChar.ToString());
                                this.AppendText(".");
                                DelimitNumber++;
                                e.Handled = true;
                            }
                        }
                    }
                    else if (digitPos == 4 && DelimitNumber<3)
                        this.AppendText(".");
                }
                else
                {
                    e.Handled = false;
                    if((len-indx) == 1)
                    {
                        DelimitNumber--;
                        if (indx > -1 )
                        {
                            digitPos = len-indx;
                        }
                        else
                            digitPos--;
                    }
                    else 
                    {
                        if(indx > -1)
                            digitPos=len-indx-1;
                        else
                            digitPos=len-1;
                    }
                }
            }
            else
                e.Handled = true;
        }	
        
    }
}
