using muli;
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
    public partial class viewreports : Form
    {
        public viewreports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            informationabout_sick sc = new informationabout_sick();
            sc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            infomanger ss = new infomanger();
            ss.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }

        private void viewreports_Load(object sender, EventArgs e)
        {

        }
    }
}
