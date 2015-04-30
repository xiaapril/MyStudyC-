namespace meauApp
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewRed = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewYellow = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.selfdefine = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.View,
            this.Help});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(584, 25);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileExit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(58, 21);
            this.File.Text = "文件(&F)";
            // 
            // View
            // 
            this.View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewRed,
            this.ViewYellow,
            this.ViewBlue,
            this.selfdefine});
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(60, 21);
            this.View.Text = "视图(&V)";
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpAbout});
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(61, 21);
            this.Help.Text = "帮助(&H)";
            // 
            // FileExit
            // 
            this.FileExit.Name = "FileExit";
            this.FileExit.Size = new System.Drawing.Size(152, 22);
            this.FileExit.Text = "退出(&E)";
            this.FileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // ViewRed
            // 
            this.ViewRed.Name = "ViewRed";
            this.ViewRed.Size = new System.Drawing.Size(152, 22);
            this.ViewRed.Text = "红色(&R)";
            this.ViewRed.Click += new System.EventHandler(this.ViewRed_Click);
            // 
            // ViewYellow
            // 
            this.ViewYellow.Name = "ViewYellow";
            this.ViewYellow.Size = new System.Drawing.Size(152, 22);
            this.ViewYellow.Text = "黄色(&Y)";
            this.ViewYellow.Click += new System.EventHandler(this.ViewYellow_Click);
            // 
            // ViewBlue
            // 
            this.ViewBlue.Name = "ViewBlue";
            this.ViewBlue.Size = new System.Drawing.Size(152, 22);
            this.ViewBlue.Text = "蓝色(&B)";
            this.ViewBlue.Click += new System.EventHandler(this.ViewBlue_Click);
            // 
            // HelpAbout
            // 
            this.HelpAbout.Name = "HelpAbout";
            this.HelpAbout.Size = new System.Drawing.Size(152, 22);
            this.HelpAbout.Text = "关于......";
            this.HelpAbout.Click += new System.EventHandler(this.HelpAbout_Click);
            // 
            // selfdefine
            // 
            this.selfdefine.Name = "selfdefine";
            this.selfdefine.Size = new System.Drawing.Size(152, 22);
            this.selfdefine.Text = "自定义(&S)";
            this.selfdefine.Click += new System.EventHandler(this.selfdefine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 408);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "使用菜单";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem FileExit;
        private System.Windows.Forms.ToolStripMenuItem View;
        private System.Windows.Forms.ToolStripMenuItem ViewRed;
        private System.Windows.Forms.ToolStripMenuItem ViewYellow;
        private System.Windows.Forms.ToolStripMenuItem ViewBlue;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem HelpAbout;
        private System.Windows.Forms.ToolStripMenuItem selfdefine;
    }
}

