using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace checklistBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (NewValue.Text.Trim() != "")
            {
                checkedListBox1.Items.Add(NewValue.Text);
                NewValue.Text = "";
            }
            else
            {
                MessageBox.Show("请输入一个字符串！");
                NewValue.Focus();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex != -1)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
                OldValue.Clear();
            }
            else
            {
                MessageBox.Show("请选中待删除的项！");              
            }
        }

        private void ShowValues_Click(object sender, EventArgs e)
        {
            string SelectValues = "以下值被选中：\n" + new String('-', 48) + "\n";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                SelectValues += checkedListBox1.CheckedItems[i].ToString();
            }
            MessageBox.Show(SelectValues);
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {
            OldValue.Text = checkedListBox1.Items[checkedListBox1.SelectedIndex].ToString(); 
        }
    }
}
