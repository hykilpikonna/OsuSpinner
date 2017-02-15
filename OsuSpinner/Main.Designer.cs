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
            this.components = new System.ComponentModel.Container();
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
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Hotkey = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Test = new System.Windows.Forms.Button();
            this.Pro = new System.Windows.Forms.Button();
            this.contextMenuStrip2.SuspendLayout();
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
            this.Speed.TextChanged += new System.EventHandler(this.Speed_TextChanged);
            // 
            // Random
            // 
            this.Random.Enabled = false;
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
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(120, 70);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.startToolStripMenuItem.Text = "Enable";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.stopToolStripMenuItem.Text = "Disable";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 20);
            this.button1.TabIndex = 12;
            this.button1.Text = "Enable";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 20);
            this.button2.TabIndex = 12;
            this.button2.Text = "Disable";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Hotkey
            // 
            this.Hotkey.Enabled = false;
            this.Hotkey.FormattingEnabled = true;
            this.Hotkey.Location = new System.Drawing.Point(329, 73);
            this.Hotkey.Name = "Hotkey";
            this.Hotkey.Size = new System.Drawing.Size(105, 21);
            this.Hotkey.TabIndex = 13;
            this.Hotkey.Text = "V";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(326, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hotkey:";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(175, 12);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(114, 29);
            this.Test.TabIndex = 14;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            // 
            // Pro
            // 
            this.Pro.BackColor = System.Drawing.Color.Aquamarine;
            this.Pro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pro.Location = new System.Drawing.Point(176, 122);
            this.Pro.Name = "Pro";
            this.Pro.Size = new System.Drawing.Size(114, 20);
            this.Pro.TabIndex = 15;
            this.Pro.Text = "I\'m a PRO!";
            this.Pro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Pro.UseVisualStyleBackColor = false;
            this.Pro.Click += new System.EventHandler(this.Pro_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(471, 161);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.Pro);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.Hotkey);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.label5);
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
            this.contextMenuStrip2.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox Hotkey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Button Pro;
    }
}

