using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuSpinner
{
    public partial class ProSettings : Form
    {
        public ProSettings()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Circle"))
            {
                Program.SetValue("SpinMode", comboBox1.Text);
                CircleSpinOptions.Show();
            }
            else
            {
                Program.SetValue("SpinMode", comboBox1.Text);
                CircleSpinOptions.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Program.IsNumeric(Angle.Text))
            {
                if (Int32.Parse(Angle.Text) > 0 && Int32.Parse(Angle.Text) < 180)
                {
                    Program.SetValue("Angle", Angle.Text);
                }
                else
                {
                    MessageBox.Show("ERROR - Angle have to be > 0 and < 180");
                }
            }
            else
            {
                MessageBox.Show("ERROR - Angle have to be a number");
            }
        }
    }
}
