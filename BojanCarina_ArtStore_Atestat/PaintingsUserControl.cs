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
    public partial class PaintingsUserControl : UserControl
    {
        private MyCart myCart;
        public PaintingsUserControl(MyCart myCart)
        {
            InitializeComponent();
            this.myCart = myCart;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox1.Text);
            a = a + 100;
            if(a>1000)
                textBox1.Text = "Sold!";
            else
            textBox1.Text = Convert.ToString(a);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox2.Text);
            a = a + 100;
            if (a > 1500)
                textBox2.Text = "Sold!";
            else
                textBox2.Text = Convert.ToString(a);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox3.Text);
            a = a + 100;
            if (a > 900)
                textBox3.Text = "Sold!";
            else
                textBox3.Text = Convert.ToString(a);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox4.Text);
            a = a + 100;
            if (a > 2000)
                textBox4.Text = "Sold!";
            else
                textBox4.Text = Convert.ToString(a);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Item sold";
            MessageBox.Show("Go to your cart!");
            button1.Enabled = false;
            this.myCart.GetCheckBox1().CheckState = CheckState.Checked;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "Item sold";
            MessageBox.Show("Go to your cart!");
            button4.Enabled = false;
            this.myCart.GetCheckBox2().CheckState = CheckState.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            button3.Text = "Item sold";
            MessageBox.Show("Go to your cart!");
            button3.Enabled = false;
            this.myCart.GetCheckBox3().CheckState = CheckState.Checked;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            button5.Text = "Item sold";
            MessageBox.Show("Go to your cart!");
            button5.Enabled = false;
            this.myCart.GetCheckBox4().CheckState = CheckState.Checked;
        }
    }
}
