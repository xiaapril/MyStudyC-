namespace addCtrlAtRuntimeApp
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
            this.btn_addButtons = new System.Windows.Forms.Button();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_addButtons
            // 
            this.btn_addButtons.Location = new System.Drawing.Point(12, 16);
            this.btn_addButtons.Name = "btn_addButtons";
            this.btn_addButtons.Size = new System.Drawing.Size(71, 26);
            this.btn_addButtons.TabIndex = 0;
            this.btn_addButtons.Text = "添加按钮";
            this.btn_addButtons.UseVisualStyleBackColor = true;
            this.btn_addButtons.Click += new System.EventHandler(this.btn_addButtons_Click);
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(100, 19);
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(172, 21);
            this.txt_msg.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.btn_addButtons);
            this.Name = "Form1";
            this.Text = "动态添加按钮";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addButtons;
        private System.Windows.Forms.TextBox txt_msg;
    }
}

