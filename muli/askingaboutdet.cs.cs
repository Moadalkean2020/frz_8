using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class askingaboutdet : Form
    {
        public askingaboutdet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            detect_by_cam det = new detect_by_cam();
            det.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPrincipal add = new FrmPrincipal();
            this.Hide();
            add.Show();
        }
    }
}
