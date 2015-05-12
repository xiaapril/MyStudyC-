using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace addCtrlAtRuntimeApp
{
    public partial class Form1 : Form
    {
        int count = 0;//用于计数，添加了多少按钮

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_addButtons_Click(object sender, EventArgs e)
        {
            //计数，计算目前是添加的第几个按钮
            count++;

            //计算待添加按钮的位置
            int localX = 10 * count;
            int localY = this.btn_addButtons.Height * count + 20;

            Button toAddButton = new Button();

            //设置按钮属性，记住初始化新添加控件的位置
            toAddButton.Name = "Button" + count;
            toAddButton.Text = "按钮" + count + "";
            toAddButton.Location=new Point(localX, localY);

            //设置添加按钮的控件
            toAddButton.MouseEnter += new EventHandler(this.btn_MouseEnter);
            toAddButton.MouseLeave+=new EventHandler(this.btn_MouseLeave);
            toAddButton.Click+=new EventHandler(this.btn_Click);

            this.Controls.Add(toAddButton);
        }

        private void btn_MouseEnter(object sender,EventArgs e)
        {
            Button currentButton = (Button)sender;
            currentButton.BackColor = Color.Blue;
        }

         private void btn_MouseLeave(object sender,EventArgs e)
        {
            Button currentButton = (Button)sender;
            currentButton.BackColor = DefaultBackColor;
        }

         private void btn_Click(object sender,EventArgs e)
        {
            Button currentButton = (Button)sender;
            txt_msg.Text = "你点击了" + currentButton.Text;

        }
    }
}
