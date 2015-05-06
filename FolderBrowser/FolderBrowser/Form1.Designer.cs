namespace FolderBrowser
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("A:");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("C:");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("D:");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Temp");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("WINNT");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Documents and Settings");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Programe Files");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("泡泡龙全集");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("E:", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("F:");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("I:");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("我的电脑", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode9,
            treeNode10,
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FolderTree = new System.Windows.Forms.TreeView();
            this.fileIconList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // FolderTree
            // 
            this.FolderTree.ImageIndex = 0;
            this.FolderTree.ImageList = this.fileIconList;
            this.FolderTree.Location = new System.Drawing.Point(12, 12);
            this.FolderTree.Name = "FolderTree";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Node0";
            treeNode1.Text = "A:";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "Node1";
            treeNode2.Text = "C:";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "Node2";
            treeNode3.Text = "D:";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "Node6";
            treeNode4.Text = "Temp";
            treeNode5.ImageIndex = 0;
            treeNode5.Name = "Node7";
            treeNode5.Text = "WINNT";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "Node8";
            treeNode6.Text = "Documents and Settings";
            treeNode7.ImageIndex = 0;
            treeNode7.Name = "Node9";
            treeNode7.Text = "Programe Files";
            treeNode8.Name = "Node10";
            treeNode8.Text = "泡泡龙全集";
            treeNode9.ImageIndex = 1;
            treeNode9.Name = "Node3";
            treeNode9.Text = "E:";
            treeNode10.ImageIndex = 1;
            treeNode10.Name = "Node4";
            treeNode10.Text = "F:";
            treeNode11.ImageIndex = 1;
            treeNode11.Name = "Node5";
            treeNode11.Text = "I:";
            treeNode12.ImageIndex = 2;
            treeNode12.Name = "Node0";
            treeNode12.Text = "我的电脑";
            this.FolderTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.FolderTree.SelectedImageIndex = 0;
            this.FolderTree.Size = new System.Drawing.Size(258, 234);
            this.FolderTree.TabIndex = 0;
            // 
            // fileIconList
            // 
            this.fileIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileIconList.ImageStream")));
            this.fileIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.fileIconList.Images.SetKeyName(0, "CLSDFOLD.ICO");
            this.fileIconList.Images.SetKeyName(1, "DRIVE.ICO");
            this.fileIconList.Images.SetKeyName(2, "MYCOMP.ICO");
            this.fileIconList.Images.SetKeyName(3, "OPENFOLD.ICO");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 262);
            this.Controls.Add(this.FolderTree);
            this.Name = "Form1";
            this.Text = "浏览我的电脑";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView FolderTree;
        private System.Windows.Forms.ImageList fileIconList;
    }
}

