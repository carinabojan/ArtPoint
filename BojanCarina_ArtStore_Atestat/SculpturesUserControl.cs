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
    public partial class SculpturesUserControl : UserControl
    {
        private MyCart myCart;
        public SculpturesUserControl(MyCart myCart)
        {
            InitializeComponent();
            this.myCart = myCart;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox1.Text);
            a = a + 100;
            if (a > 1000)
                textBox1.Text = "Sold!";
            else
                textBox1.Text = Convert.ToString(a);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox2.Text);
            a = a + 100;
            if (a > 2000)
                textBox2.Text = "Sold!";
            else
                textBox2.Text = Convert.ToString(a);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox3.Text);
            a = a + 100;
            if (a > 1300)
                textBox3.Text = "Sold!";
            else
                textBox3.Text = Convert.ToString(a);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox4.Text);
            a = a + 100;
            if (a > 800)
                textBox4.Text = "Sold!";
            else
                textBox4.Text = Convert.ToString(a);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Text = "Item sold";
            MessageBox.Show("Go to your cart!");
            button1.Enabled = false;
            this.myCart.GetCheckBox5().CheckState = CheckState.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            button2.Text = "Item sold";
            MessageBox.Show("Go to your cart!");
            button2.Enabled = false;
            this.myCart.GetCheckBox6().CheckState = CheckState.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            button3.Text = "Item sold";
            MessageBox.Show("Go to your cart!");
            button3.Enabled = false;
            this.myCart.GetCheckBox7().CheckState = CheckState.Checked;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            button4.Text = "Item sold";
            MessageBox.Show("Go to your cart!");
            button4.Enabled = false;
            this.myCart.GetCheckBox8().CheckState = CheckState.Checked;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
