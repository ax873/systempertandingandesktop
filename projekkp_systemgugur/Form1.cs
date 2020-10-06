using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekkp_systemgugur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;
            if (panel2.Width >= 700)
            {
                timer1.Stop();
                this.Hide();
                Menuu f2 = new Menuu();
                f2.Show(); 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
