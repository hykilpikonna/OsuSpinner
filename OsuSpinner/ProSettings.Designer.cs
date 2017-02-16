namespace OsuSpinner
{
    partial class ProSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProSettings));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CircleSpinOptions = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Angle = new System.Windows.Forms.TextBox();
            this.AutoClick = new System.Windows.Forms.CheckBox();
            this.CircleSpinOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Circle",
            "Triangle",
            "Square"});
            this.comboBox1.Location = new System.Drawing.Point(78, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Circle";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Spin mode:";
            // 
            // CircleSpinOptions
            // 
            this.CircleSpinOptions.BackColor = System.Drawing.Color.Transparent;
            this.CircleSpinOptions.Controls.Add(this.AutoClick);
            this.CircleSpinOptions.Controls.Add(this.label2);
            this.CircleSpinOptions.Controls.Add(this.Angle);
            this.CircleSpinOptions.Location = new System.Drawing.Point(12, 39);
            this.CircleSpinOptions.Name = "CircleSpinOptions";
            this.CircleSpinOptions.Size = new System.Drawing.Size(261, 210);
            this.CircleSpinOptions.TabIndex = 2;
            this.CircleSpinOptions.TabStop = false;
            this.CircleSpinOptions.Text = "Circle spin options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angle :";
            // 
            // Angle
            // 
            this.Angle.Location = new System.Drawing.Point(61, 19);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(178, 20);
            this.Angle.TabIndex = 0;
            this.Angle.Text = "20";
            this.Angle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AutoClick
            // 
            this.AutoClick.AutoSize = true;
            this.AutoClick.Checked = true;
            this.AutoClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoClick.Location = new System.Drawing.Point(16, 48);
            this.AutoClick.Name = "AutoClick";
            this.AutoClick.Size = new System.Drawing.Size(142, 17);
            this.AutoClick.TabIndex = 2;
            this.AutoClick.Text = "Auto click while spinning";
            this.AutoClick.UseVisualStyleBackColor = true;
            this.AutoClick.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ProSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CircleSpinOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProSettings";
            this.Opacity = 0.85D;
            this.Text = "ProSettings";
            this.CircleSpinOptions.ResumeLayout(false);
            this.CircleSpinOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox CircleSpinOptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Angle;
        private System.Windows.Forms.CheckBox AutoClick;
    }
}