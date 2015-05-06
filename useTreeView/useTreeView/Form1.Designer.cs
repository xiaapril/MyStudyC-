namespace useTreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("打印机");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("文件二");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("文件一", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("我的电脑", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FolderTree = new System.Windows.Forms.TreeView();
            this.fileIconList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // FolderTree
            // 
            this.FolderTree.ImageIndex = 0;
            this.FolderTree.ImageList = this.fileIconList;
            this.FolderTree.Location = new System.Drawing.Point(4, 12);
            this.FolderTree.Name = "FolderTree";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Node1";
            treeNode1.Text = "打印机";
            treeNode2.ImageIndex = 3;
            treeNode2.Name = "Node3";
            treeNode2.Text = "文件二";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "Node2";
            treeNode3.Text = "文件一";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "Node0";
            treeNode4.Text = "我的电脑";
            this.FolderTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.FolderTree.SelectedImageIndex = 0;
            this.FolderTree.Size = new System.Drawing.Size(280, 250);
            this.FolderTree.TabIndex = 0;
            // 
            // fileIconList
            // 
            this.fileIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileIconList.ImageStream")));
            this.fileIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.fileIconList.Images.SetKeyName(0, "MYCOMP.ICO");
            this.fileIconList.Images.SetKeyName(1, "DRIVE.ICO");
            this.fileIconList.Images.SetKeyName(2, "OPENFOLD.ICO");
            this.fileIconList.Images.SetKeyName(3, "CLSDFOLD.ICO");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(310, 287);
            this.Controls.Add(this.FolderTree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView FolderTree;
        private System.Windows.Forms.ImageList fileIconList;
    }
}

