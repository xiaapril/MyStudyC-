namespace checklistBoxApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.OldValue = new System.Windows.Forms.TextBox();
            this.NewValue = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.ShowValues = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(24, 16);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(273, 164);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.Click += new System.EventHandler(this.checkedListBox1_Click);
            // 
            // OldValue
            // 
            this.OldValue.Location = new System.Drawing.Point(17, 210);
            this.OldValue.Name = "OldValue";
            this.OldValue.Size = new System.Drawing.Size(98, 21);
            this.OldValue.TabIndex = 1;
            // 
            // NewValue
            // 
            this.NewValue.Location = new System.Drawing.Point(189, 210);
            this.NewValue.Name = "NewValue";
            this.NewValue.Size = new System.Drawing.Size(105, 21);
            this.NewValue.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(17, 250);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(65, 27);
            this.Add.TabIndex = 3;
            this.Add.Text = "添加(&A)";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(122, 250);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(61, 27);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "删除(&D)";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ShowValues
            // 
            this.ShowValues.Location = new System.Drawing.Point(225, 250);
            this.ShowValues.Name = "ShowValues";
            this.ShowValues.Size = new System.Drawing.Size(69, 27);
            this.ShowValues.TabIndex = 5;
            this.ShowValues.Text = "显示(&S)";
            this.ShowValues.UseVisualStyleBackColor = true;
            this.ShowValues.Click += new System.EventHandler(this.ShowValues_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 288);
            this.Controls.Add(this.ShowValues);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.NewValue);
            this.Controls.Add(this.OldValue);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "使用checkedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox OldValue;
        private System.Windows.Forms.TextBox NewValue;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button ShowValues;
    }
}

