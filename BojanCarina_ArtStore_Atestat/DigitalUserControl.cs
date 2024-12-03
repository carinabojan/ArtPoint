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
    public partial class DigitalUserControl : UserControl
    {
        private MyCart myCart;
        public DigitalUserControl(MyCart myCart)
        {
            InitializeComponent();
            this.myCart = myCart;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox1.Text);
            a = a + 1000;
            if (a > 12000)
                textBox1.Text = "Sold!";
            else
                textBox1.Text = Convert.ToString(a);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox2.Text);
            a = a + 1000;
            if (a > 10000)
                textBox2.Text = "Sold!";
            else
                textBox2.Text = Convert.ToString(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox3.Text);
            a = a + 100;
            if (a > 1000)
                textBox3.Text = "Sold!";
            else
                textBox3.Text = Convert.ToString(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox4.Text);
            a = a + 100;
            if (a > 800)
                textBox4.Text = "Sold!";
            else
                textBox4.Text = Convert.ToString(a);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "Item sold";
            MessageBox.Show("Go to your cart!");
            button4.Enabled = false;
            this.myCart.GetCheckBox9().CheckState = CheckState.Checked;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "Item sold";
            MessageBox.Show("Go to your cart!");
            button7.Enabled = false;
            this.myCart.GetCheckBox10().CheckState = CheckState.Checked;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "Item sold";
            MessageBox.Show("Go to your cart!");
            button6.Enabled = false;
            this.myCart.GetCheckBox11().CheckState = CheckState.Checked;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "Item sold";
            MessageBox.Show("Go to your cart!");
            button8.Enabled = false;
        }
    }
}
