using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MultiFaceRec;
using mlava;
using System.Data.SqlClient;


namespace MultiFaceRec
{
    public partial class patient_main_page : Form
    {
        public patient_main_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //askingaboutdet deta = new askingaboutdet();
            //deta.Show();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            How_to_use_this_app_page x = new How_to_use_this_app_page();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 s = new Form1();
            s.Show();
        }

        private void patient_main_page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amara\Desktop\face_recognition_8-master_2\Data.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Table] ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Singleton user = Singleton.Instance;
            string nameuser = user.getuser();
            label2.Text = nameuser;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            My_partner_details det = new My_partner_details();
            det.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //patierndet patdet = new patierndet();
            //patdet.Show();
            
        }
    }
}
