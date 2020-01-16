using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mlava;

namespace MultiFaceRec
{
    public partial class askingaboutadd : Form
    {
        public askingaboutadd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPrincipal add = new FrmPrincipal();
            this.Hide();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert adding = new Insert();
            
            adding.Show();
        }
    }
}
