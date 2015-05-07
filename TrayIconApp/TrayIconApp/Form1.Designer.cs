namespace TrayIconApp
{
    partial class TrayIcon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrayIcon));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.maximize = new System.Windows.Forms.ToolStripMenuItem();
            this.minimise = new System.Windows.Forms.ToolStripMenuItem();
            this.helpme = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "黄易贴";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maximize,
            this.minimise,
            this.helpme,
            this.exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 92);
            // 
            // maximize
            // 
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(100, 22);
            this.maximize.Text = "显示";
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // minimise
            // 
            this.minimise.Name = "minimise";
            this.minimise.Size = new System.Drawing.Size(100, 22);
            this.minimise.Text = "隐藏";
            this.minimise.Click += new System.EventHandler(this.minimise_Click);
            // 
            // helpme
            // 
            this.helpme.Name = "helpme";
            this.helpme.Size = new System.Drawing.Size(100, 22);
            this.helpme.Text = "帮助";
            this.helpme.Click += new System.EventHandler(this.helpme_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 22);
            this.exit.Text = "退出";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // tBox
            // 
            this.tBox.BackColor = System.Drawing.Color.Orange;
            this.tBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBox.Location = new System.Drawing.Point(0, 0);
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(284, 262);
            this.tBox.TabIndex = 1;
            this.tBox.Text = "今天要事\n9:00  与测试处联系测试事宜\n10:00 和电信局同事见面\n14:00 商讨数据库设计";
            // 
            // TrayIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.tBox);
            this.MaximizeBox = false;
            this.Name = "TrayIcon";
            this.ShowInTaskbar = false;
            this.Text = "黄易贴";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem maximize;
        private System.Windows.Forms.ToolStripMenuItem minimise;
        private System.Windows.Forms.ToolStripMenuItem helpme;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.RichTextBox tBox;
    }
}

