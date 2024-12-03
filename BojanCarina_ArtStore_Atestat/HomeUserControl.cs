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
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
            readMorePurple1.Visible=false;
            readMorePurple1.SendToBack();
            readMoreGreen1.Visible = false;
            readMoreGreen1.SendToBack();
            readMoreYellow1.Visible = false;
            readMoreYellow1.SendToBack();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            readMorePurple1.Visible=true;
            readMorePurple1.BringToFront();
        }

        private void readMorePurple1_Load(object sender, EventArgs e)
        {

        }

        private void ReadMoreGreen_Click(object sender, EventArgs e)
        {
            readMoreGreen1.Visible = true;
            readMoreGreen1.BringToFront();
        }

        private void ReadMoreYellow_Click(object sender, EventArgs e)
        {
        }

        private void ReadMoreYellow_Click_1(object sender, EventArgs e)
        {
            readMoreYellow1.Visible = true;
            readMoreYellow1.BringToFront();
        }
    }
}
