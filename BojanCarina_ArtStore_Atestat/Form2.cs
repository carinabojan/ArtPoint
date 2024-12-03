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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "carina" && textBox2.Text == "12345")
            {
                new Form1().Show();
                this.Hide();
            }
            else
            { MessageBox.Show("Your username or password are incorrect!");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
               

        }
    }
}
