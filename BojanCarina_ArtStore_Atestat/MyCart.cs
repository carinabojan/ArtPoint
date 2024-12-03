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
    public partial class MyCart : UserControl
    {
        int s = 0;
        public MyCart()
        {
            InitializeComponent();
        }

        public System.Windows.Forms.CheckBox GetCheckBox1()
        {
            return this.checkBox1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            updateCart(checkBox1.Checked, "Painting 1-324$", 324);
        }

        private void updateCart(Boolean isChecked, String text, int price)Z
        {
            if (isChecked)
            {
                if (richTextBox1.Text.Length == 0)
                {
                    richTextBox1.Text = richTextBox1.Text + text;
                }
                else
                {
                    richTextBox1.Text = richTextBox1.Text + '\n' + text;
                }
                s = s + price;
            }
            else
            {
                int idx = richTextBox1.Text.IndexOf(text);
                if (idx >= 0)
                {
                    int idx1 = richTextBox1.Text.IndexOf('\n');
                    if (idx1 == -1) {
                        richTextBox1.Text = richTextBox1.Text.Substring(0, idx) + richTextBox1.Text.Substring(idx + text.Length);
                    } else
                    {
                        if(idx > 0)
                        {
                            richTextBox1.Text = richTextBox1.Text.Substring(0, idx - 1) + richTextBox1.Text.Substring(idx + text.Length);
                        } else
                        {
                            richTextBox1.Text = richTextBox1.Text.Substring(idx + text.Length);
                        }
                        
                    }
                    
                }
            }
        }

        public System.Windows.Forms.CheckBox GetCheckBox2()
        {
            return this.checkBox2;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            updateCart(checkBox2.Checked, "Painting 2-570$", 570);
        }
        public System.Windows.Forms.CheckBox GetCheckBox3()
        {
            return this.checkBox3;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            updateCart(checkBox3.Checked, "Painting 3-280$", 280);
        }
        public System.Windows.Forms.CheckBox GetCheckBox4()
        {
            return this.checkBox4;
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            updateCart(checkBox4.Checked, "Painting 4-766$", 766);
        }
        public System.Windows.Forms.CheckBox GetCheckBox5()
        {
            return this.checkBox5;
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            updateCart(checkBox5.Checked, "Sculpture 1-670$", 670);
        }
        public System.Windows.Forms.CheckBox GetCheckBox6()
        {
            return this.checkBox6;
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            updateCart(checkBox6.Checked, "Sculpture 2-900$", 900);
        }
        public System.Windows.Forms.CheckBox GetCheckBox7()
        {
            return this.checkBox7;
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            
            updateCart(checkBox7.Checked, "Sculpture 3-455$", 455);
        }
        public System.Windows.Forms.CheckBox GetCheckBox8()
        {
            return this.checkBox8;
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + '\n' + "Sculpture 4-388$";
            updateCart(checkBox8.Checked, "Sculpture 4-388$", 388);
        }
        public System.Windows.Forms.CheckBox GetCheckBox9()
        {
            return this.checkBox9;
        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            updateCart(checkBox9.Checked, "Digital Art 1-1020$", 1020);
        }

        public System.Windows.Forms.CheckBox GetCheckBox10()
        {
            return this.checkBox10;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + '\n' + "Digital Art 2-180$";
            updateCart(checkBox10.Checked, "Digital Art 2-180$", 180);
        }

        public System.Windows.Forms.CheckBox GetCheckBox11()
        {
            return this.checkBox11;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + '\n' + "Digital Art 3-340$";
            updateCart(checkBox11.Checked, "Digital Art 3-340$", 340);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + '\n' + "Digital Art 4-410$";
            updateCart(checkBox12.Checked, "Digital Art 4-410$", 410);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text =="")
                MessageBox.Show("Please fill in all of your information!");
            else
            {
                MessageBox.Show("Thank you for your purchase! Check your e-mail for the receipt."+'\n'+
                   "Total price: "+Convert.ToString(s));
            richTextBox1.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
                s = 0;
                richTextBox1.Text = "";
            }
              
        }
    }
}
