using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace OsuSpinner
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        KeyboardHook hook = new KeyboardHook();

        private void Main_Load(object sender, EventArgs e)
        {
            Program.SetValue("Speed", "10");
            Program.SetValue("X", (Screen.FromControl(this).Bounds.Width / 2).ToString());
            this.X.Text = (Screen.FromControl(this).Bounds.Width / 2).ToString();
            Program.SetValue("Y", (Screen.FromControl(this).Bounds.Height / 2).ToString());
            this.Y.Text = (Screen.FromControl(this).Bounds.Height / 2).ToString();
            Program.SetValue("Offset", "0");
            Program.SetValue("Radius", "3");


            // register the event that is fired after the key press.
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            // register the control + alt + F12 combination as hot key.
            hook.RegisterHotKey(0, Keys.V);
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            // show the keys pressed in a label.
            Program.Spin();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Speed_TextChanged(object sender, EventArgs e)
        {
            if (!Program.IsNumeric(Speed.Text))
            {
                MessageBox.Show("ERROR - Speed have to be a number");
            }
            else
            {
                Program.SetValue("Speed", Speed.Text);
            }
        }

        private void Test_Click(object sender, EventArgs e)
        {
            Program.Spin(Int32.Parse(Speed.Text), Int32.Parse(Radius.Text), Int32.Parse(Random.Text), true);
        }

        ProSettings proFrm = new ProSettings();

        private void Pro_Click(object sender, EventArgs e)
        {
            bool tempPro = Program.pro;
            Program.pro = !Program.pro;
            if(!tempPro)
            {
                proFrm.Show();
                this.Pro.Text = "I'm NOT a PRO!";
            }
            else
            {
                proFrm.Hide();
                this.Pro.Text = "I'm a PRO!";
            }
            
            
        }
    }
}
