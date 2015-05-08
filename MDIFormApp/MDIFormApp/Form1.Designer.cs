namespace MDIFormApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Window = new System.Windows.Forms.ToolStripMenuItem();
            this.FileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Window});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileNew,
            this.FileExit,
            this.toolStripMenuItem5});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(58, 21);
            this.File.Text = "文件(&F)";
            // 
            // Window
            // 
            this.Window.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WindowCascade,
            this.WindowHorizontal,
            this.WindowVertical});
            this.Window.Name = "Window";
            this.Window.Size = new System.Drawing.Size(64, 21);
            this.Window.Text = "窗口(&W)";
            // 
            // FileNew
            // 
            this.FileNew.Name = "FileNew";
            this.FileNew.Size = new System.Drawing.Size(152, 22);
            this.FileNew.Text = "新建(&N)";
            this.FileNew.Click += new System.EventHandler(this.FileNew_Click);
            // 
            // FileExit
            // 
            this.FileExit.Name = "FileExit";
            this.FileExit.Size = new System.Drawing.Size(152, 22);
            this.FileExit.Text = "退出(&E)";
            this.FileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem5.Text = "-";
            // 
            // WindowCascade
            // 
            this.WindowCascade.Name = "WindowCascade";
            this.WindowCascade.Size = new System.Drawing.Size(152, 22);
            this.WindowCascade.Text = "层叠(&C)";
            this.WindowCascade.Click += new System.EventHandler(this.WindowCascade_Click);
            // 
            // WindowHorizontal
            // 
            this.WindowHorizontal.Name = "WindowHorizontal";
            this.WindowHorizontal.Size = new System.Drawing.Size(152, 22);
            this.WindowHorizontal.Text = "水平排列(&H)";
            this.WindowHorizontal.Click += new System.EventHandler(this.WindowHorizontal_Click);
            // 
            // WindowVertical
            // 
            this.WindowVertical.Name = "WindowVertical";
            this.WindowVertical.Size = new System.Drawing.Size(152, 22);
            this.WindowVertical.Text = "竖直排列(&V)";
            this.WindowVertical.Click += new System.EventHandler(this.WindowVertical_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "多窗口应用程序";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem FileNew;
        private System.Windows.Forms.ToolStripMenuItem FileExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem Window;
        private System.Windows.Forms.ToolStripMenuItem WindowCascade;
        private System.Windows.Forms.ToolStripMenuItem WindowHorizontal;
        private System.Windows.Forms.ToolStripMenuItem WindowVertical;
    }
}

