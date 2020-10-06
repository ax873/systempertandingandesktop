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
    public partial class bagan15 : Form
    {
        public bagan15()
        {
            InitializeComponent();
        }
         public bagan15(string terima) :
            this()
        {
            label1.Text=terima;
        }
        private void bagan15_Load(object sender, EventArgs e)
        {

        }
    }
}
