using System;
using System.Windows.Forms;
using MultiFaceRec;
using mlava;

namespace MultiFaceRec
{
    public partial class mal : Form
    {
        public mal()
        {
            InitializeComponent();
            Singleton user = Singleton.Instance;
            string nameuser = user.getuser();
            label2.Text = nameuser;
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 s = new Form1();
            s.Show();


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            addapatient newx = new addapatient();
            newx.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            viewreports ss1 = new viewreports();
            ss1.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            help ss2 = new help();
            ss2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmPrincipal newfrm = new FrmPrincipal();
            newfrm.Show();
            
        }

        private void mal_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            updatesick upsick = new updatesick();
            upsick.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            askingaboutadd innew = new askingaboutadd();
            innew.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            about abouty = new about();
            abouty.Show();
        }
    }
}
