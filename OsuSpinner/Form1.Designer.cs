namespace OsuSpinner
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.TextBox();
            this.Random = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Radius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.Location = new System.Drawing.Point(12, 21);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(41, 20);
            this.SpeedLabel.TabIndex = 0;
            this.SpeedLabel.Text = "Speed:";
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(59, 18);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(96, 20);
            this.Speed.TabIndex = 1;
            this.Speed.Text = "1";
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(59, 96);
            this.Random.MaxLength = 3;
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(82, 20);
            this.Random.TabIndex = 9;
            this.Random.Text = "0";
            this.Random.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Offset:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(59, 44);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(82, 20);
            this.X.TabIndex = 1;
            this.X.Text = "ERROR";
            this.X.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y :";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(59, 70);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(74, 20);
            this.Y.TabIndex = 1;
            this.Y.Text = "ERROR";
            this.Y.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Radius:";
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(59, 122);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(96, 20);
            this.Radius.TabIndex = 1;
            this.Radius.Text = "5";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(463, 166);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.X);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.SpeedLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.8D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "OSU Spinner";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.TextBox Speed;
        private System.Windows.Forms.TextBox Random;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Radius;
    }
}

