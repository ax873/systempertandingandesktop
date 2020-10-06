using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekkp_systemgugur.bagan
{
    public partial class bagan_2 : Form
    {
        public bagan_2()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            b3.Text = b1.Text;
            b2.Enabled = false;
            b3.Normalcolor=Color.Red;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            b3.Text = b2.Text;
            b1.Enabled = false;
            b3.Normalcolor = Color.Blue;
        }

        private void bagan_2_Load(object sender, EventArgs e)
        {

        }
    }
}
