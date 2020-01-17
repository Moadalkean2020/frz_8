using MultiFaceRec;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace mlava
{
    public partial class MyData : Form
    {
        public MyData()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insert ss = new Insert();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Update ss = new Update();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete ss = new Delete();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            ShowMyData ss = new ShowMyData();
            ss.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search ss = new Search();
            ss.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }

        private void MyData_Load(object sender, EventArgs e)
        {

        }
    }
}
