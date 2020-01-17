using mlava;
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
    public partial class askingitem : Form
    {
        public askingitem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update uu = new Update();
            uu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete dd = new Delete();
            dd.Show();
            this.Hide();
        }
    }
}
