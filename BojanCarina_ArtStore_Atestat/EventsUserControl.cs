using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BojanCarina_ArtStore_Atestat
{
    public partial class EventsUserControl : UserControl
    {
        public EventsUserControl()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && checkBox1.Checked == true)
            {
                if (checkBox3.Checked == true)
                    MessageBox.Show("You will receive a message with the tickets and your auction number. " +
                                    "Thank you for your participation!");
                else
                    MessageBox.Show("You will receive a message with the tickets." +
                                        "Thank you for your participation! ");
            }
            else
                MessageBox.Show("Please fill in all of your information!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
