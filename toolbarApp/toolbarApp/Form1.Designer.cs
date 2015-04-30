namespace toolbarApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewRed = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewYellow = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonFileExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonViewRed = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonViewYellow = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonViewBlue = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonHelpAbout = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.View,
            this.Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileExit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(58, 21);
            this.File.Text = "文件(&F)";
            // 
            // FileExit
            // 
            this.FileExit.Name = "FileExit";
            this.FileExit.Size = new System.Drawing.Size(115, 22);
            this.FileExit.Text = "退出(&E)";
            this.FileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // View
            // 
            this.View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewRed,
            this.ViewYellow,
            this.ViewBlue});
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(60, 21);
            this.View.Text = "视图(&V)";
            // 
            // ViewRed
            // 
            this.ViewRed.Name = "ViewRed";
            this.ViewRed.Size = new System.Drawing.Size(116, 22);
            this.ViewRed.Text = "红色(&R)";
            this.ViewRed.Click += new System.EventHandler(this.ViewRed_Click);
            // 
            // ViewYellow
            // 
            this.ViewYellow.Name = "ViewYellow";
            this.ViewYellow.Size = new System.Drawing.Size(116, 22);
            this.ViewYellow.Text = "黄色(&Y)";
            this.ViewYellow.Click += new System.EventHandler(this.ViewYellow_Click);
            // 
            // ViewBlue
            // 
            this.ViewBlue.Name = "ViewBlue";
            this.ViewBlue.Size = new System.Drawing.Size(116, 22);
            this.ViewBlue.Text = "蓝色(&B)";
            this.ViewBlue.Click += new System.EventHandler(this.ViewBlue_Click);
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpAbout});
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(61, 21);
            this.Help.Text = "帮助(&H)";
            // 
            // HelpAbout
            // 
            this.HelpAbout.Name = "HelpAbout";
            this.HelpAbout.Size = new System.Drawing.Size(118, 22);
            this.HelpAbout.Text = "关于......";
            this.HelpAbout.Click += new System.EventHandler(this.HelpAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFileExit,
            this.toolStripSeparator1,
            this.toolStripButtonViewRed,
            this.toolStripButtonViewYellow,
            this.toolStripButtonViewBlue,
            this.toolStripSeparator2,
            this.toolStripButtonHelpAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(530, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButtonFileExit
            // 
            this.toolStripButtonFileExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFileExit.Image")));
            this.toolStripButtonFileExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFileExit.Name = "toolStripButtonFileExit";
            this.toolStripButtonFileExit.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonFileExit.Text = "退出";
            this.toolStripButtonFileExit.ToolTipText = "退出程序";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonViewRed
            // 
            this.toolStripButtonViewRed.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonViewRed.Image")));
            this.toolStripButtonViewRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonViewRed.Name = "toolStripButtonViewRed";
            this.toolStripButtonViewRed.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonViewRed.Text = "红色";
            this.toolStripButtonViewRed.ToolTipText = "把窗体设置成红色";
            // 
            // toolStripButtonViewYellow
            // 
            this.toolStripButtonViewYellow.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonViewYellow.Image")));
            this.toolStripButtonViewYellow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonViewYellow.Name = "toolStripButtonViewYellow";
            this.toolStripButtonViewYellow.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonViewYellow.Text = "黄色";
            this.toolStripButtonViewYellow.ToolTipText = "把窗体设置成黄色";
            // 
            // toolStripButtonViewBlue
            // 
            this.toolStripButtonViewBlue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonViewBlue.Image")));
            this.toolStripButtonViewBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonViewBlue.Name = "toolStripButtonViewBlue";
            this.toolStripButtonViewBlue.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonViewBlue.Text = "蓝色";
            this.toolStripButtonViewBlue.ToolTipText = "把窗体设置成蓝色";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonHelpAbout
            // 
            this.toolStripButtonHelpAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHelpAbout.Image")));
            this.toolStripButtonHelpAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHelpAbout.Name = "toolStripButtonHelpAbout";
            this.toolStripButtonHelpAbout.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonHelpAbout.Text = "关于";
            this.toolStripButtonHelpAbout.ToolTipText = "帮助信息";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 342);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "使用菜单";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem FileExit;
        private System.Windows.Forms.ToolStripMenuItem View;
        private System.Windows.Forms.ToolStripMenuItem ViewRed;
        private System.Windows.Forms.ToolStripMenuItem ViewYellow;
        private System.Windows.Forms.ToolStripMenuItem ViewBlue;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem HelpAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonFileExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonViewRed;
        private System.Windows.Forms.ToolStripButton toolStripButtonViewYellow;
        private System.Windows.Forms.ToolStripButton toolStripButtonViewBlue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonHelpAbout;
    }
}

