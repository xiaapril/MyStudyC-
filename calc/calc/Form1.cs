using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calc
{
    public partial class Calculator1 : Form
    {
        private int opMain = 0;//1(加法) 2(减法) 3(乘法) 4(除法)
        private double mainNum1 = 0;//存储第一个数
        private double mainNum2 = 0;//存储第二个数
        private bool isSecond = false;//用来判断输入的是第一个还是第二个数
        private bool isDone = false;//用来判断是否按了等于按钮
        private bool isDecimal = false;//用来判断是否有小数

        public Calculator1()
        {
            InitializeComponent();
        }

        public void setText(string textSet)
        {
            if (textSet.Equals("clear"))
            {
                txtResult.Text = "";
                isDone = false;
                isSecond = false;
                isDecimal = false;
            }
            else
            {
                if (isSecond)
                {
                    txtResult.Text = textSet;
                    isSecond = false;
                    isDecimal = false;
                }
                else
                {
                    if (isDone)
                    {
                        txtResult.Text = textSet;
                        isDone = false;
                    }
                    else
                        txtResult.Text += textSet;
                }
            }
            btnEquals.Select();
        }

        public void Calc(double num1, double num2, int op)
        {
            double answer = 0;
            switch (op)
            { 
                case 1:
                    answer = num1 + num2;
                    break;
                case 2:
                    answer = num1 - num2;
                    break;
                case 3:
                    answer = num1 * num2;
                    break;
                case 4:
                    answer = num1 / num2;
                    break;
            }
            setText(answer.ToString());
        }

        private void doEquals()
        {
            mainNum2 = double.Parse(txtResult.Text);
            setText("clear");
            Calc(mainNum1, mainNum2, opMain);
            isDone = true;
        }
        
        private void changeSign()
        {
            double storNum;
            if (txtResult.Text.Length > 0)
            {
                storNum = double.Parse(txtResult.Text);
                storNum *= -1;
                txtResult.Text = storNum.ToString();
            }
            btnEquals.Select();
        }

        private void setOperator(int operation)
        {
            if (txtResult.Text.Length > 0)
            {
                opMain = operation;
                mainNum1 = double.Parse(txtResult.Text);
                isSecond = true;
                isDone = false;
                btnEquals.Select();
            }
        }

        private void setDecimal()
        {
            if (!isDecimal)
            {
                setText(".");
                isDecimal = true;
            }
            btnEquals.Select();
        }

        public void filterKeys(int keyCode)
        {
            switch (keyCode)
            { 
                case 96:
                    setText("0");
                    break;
                case 97:
                    setText("1");
                    break;
                case 98:
                    setText("2");
                    break;
                case 99:
                    setText("3");
                    break;
                case 100:
                    setText("4");
                    break;
                case 101:
                    setText("5");
                    break;
                case 102:
                    setText("6");
                    break;
                case 103:
                    setText("7");
                    break;
                case 104:
                    setText("8");
                    break;
                case 105:
                    setText("9");
                    break;
                case 67:
                    setText("clear");
                    break;
                case 107:
                    setOperator(1);
                    break;
                case 109:
                    setOperator(2);
                    break;
                case 106:
                    setOperator(3);
                    break;
                case 111:
                    setOperator(4);
                    break;
                case 110:
                    setDecimal();
                    break;
            }
        }

        private void Calculator1_KeyDown(object sender, KeyEventArgs e)
        {
            filterKeys(e.KeyValue);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            setText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            setText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            setText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            setText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            setText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            setText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            setText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            setText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            setText("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            setText("0");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setOperator(1);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            setOperator(2);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            setOperator(3);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            setOperator(4);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isSecond = false;
            setText("clear");
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            changeSign();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            setDecimal();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            doEquals();
        }
    }
}
