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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = HomeButton.Height;
            SidePanel.Top = HomeButton.Top;
            homeUserControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = HomeButton.Height;
            SidePanel.Top = HomeButton.Top;
            homeUserControl1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = PaintingsButton.Height;
            SidePanel.Top = PaintingsButton.Top;
            paintingsUserControl1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height =SculpturesButton.Height;
            SidePanel.Top = SculpturesButton.Top;
            sculpturesUserControl1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = DigitalArtButton.Height;
            SidePanel.Top = DigitalArtButton.Top;
            digitalUserControl1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = EventsButton.Height;
            SidePanel.Top = EventsButton.Top;
            eventsUserControl1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void MyCartButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = MyCartButton.Height;
            SidePanel.Top = MyCartButton.Top;
            myCart1.BringToFront();
        }

        private void homeUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void homeUserControl3_Load(object sender, EventArgs e)
        {
            
        }

        private void digitalUserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void sculpturesUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
