namespace BrickOut
{
    partial class SpeedDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SlowRadio = new System.Windows.Forms.RadioButton();
            this.MediumRadio = new System.Windows.Forms.RadioButton();
            this.FastRadio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FastRadio);
            this.groupBox1.Controls.Add(this.MediumRadio);
            this.groupBox1.Controls.Add(this.SlowRadio);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speed";
            // 
            // SlowRadio
            // 
            this.SlowRadio.AutoSize = true;
            this.SlowRadio.Checked = true;
            this.SlowRadio.Location = new System.Drawing.Point(16, 24);
            this.SlowRadio.Name = "SlowRadio";
            this.SlowRadio.Size = new System.Drawing.Size(47, 16);
            this.SlowRadio.TabIndex = 0;
            this.SlowRadio.TabStop = true;
            this.SlowRadio.Text = "Slow";
            this.SlowRadio.UseVisualStyleBackColor = true;
            this.SlowRadio.CheckedChanged += new System.EventHandler(this.SlowRadio_CheckedChanged);
            // 
            // MediumRadio
            // 
            this.MediumRadio.AutoSize = true;
            this.MediumRadio.Location = new System.Drawing.Point(16, 52);
            this.MediumRadio.Name = "MediumRadio";
            this.MediumRadio.Size = new System.Drawing.Size(59, 16);
            this.MediumRadio.TabIndex = 1;
            this.MediumRadio.TabStop = true;
            this.MediumRadio.Text = "Medium";
            this.MediumRadio.UseVisualStyleBackColor = true;
            // 
            // FastRadio
            // 
            this.FastRadio.AutoSize = true;
            this.FastRadio.Location = new System.Drawing.Point(16, 80);
            this.FastRadio.Name = "FastRadio";
            this.FastRadio.Size = new System.Drawing.Size(47, 16);
            this.FastRadio.TabIndex = 2;
            this.FastRadio.TabStop = true;
            this.FastRadio.Text = "Fast";
            this.FastRadio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SpeedDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(126, 148);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SpeedDialog";
            this.Text = "Level";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FastRadio;
        private System.Windows.Forms.RadioButton MediumRadio;
        private System.Windows.Forms.RadioButton SlowRadio;
        private System.Windows.Forms.Button button1;
    }
}