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
    public partial class ReadMoreGreen : UserControl
    {
        public ReadMoreGreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Visible = false;
        }
    }
}
