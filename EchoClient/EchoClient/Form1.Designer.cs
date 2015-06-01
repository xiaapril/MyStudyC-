namespace EchoClient
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
            this.t1 = new System.Windows.Forms.TextBox();
            this.ta = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(40, 22);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(147, 21);
            this.t1.TabIndex = 0;
            // 
            // ta
            // 
            this.ta.Location = new System.Drawing.Point(40, 67);
            this.ta.Multiline = true;
            this.ta.Name = "ta";
            this.ta.Size = new System.Drawing.Size(147, 44);
            this.ta.TabIndex = 1;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Transparent;
            this.b1.BackgroundImage = global::EchoClient.Properties.Resources.back2;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.b1.ForeColor = System.Drawing.Color.Red;
            this.b1.Location = new System.Drawing.Point(74, 145);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(77, 31);
            this.b1.TabIndex = 2;
            this.b1.Text = "Click Here";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EchoClient.Properties.Resources.back1;
            this.ClientSize = new System.Drawing.Size(230, 222);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.ta);
            this.Controls.Add(this.t1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Socket Programming";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox ta;
        private System.Windows.Forms.Button b1;
    }
}

