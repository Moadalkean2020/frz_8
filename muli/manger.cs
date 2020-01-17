using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MultiFaceRec;
using mlava;
using System.Windows.Forms;

namespace mlava
{
    public partial class manger : Form
    {
        public manger()
        {
            InitializeComponent();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 retur = new Form1();
            retur.Show();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewreportsmanger viewmanger = new viewreportsmanger();
            viewmanger.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyData ss = new MyData();
            ss.Show();
        }
    }
}
