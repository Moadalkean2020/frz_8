using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MultiFaceRec
{
    public partial class ShowMyData : Form
    {
        public ShowMyData()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amara\Desktop\face_recognition_8-master_2\Data.mdf;Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from infTable ", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            dataGridView1.DataSource = dt;
            SqlConnection connection1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amara\Desktop\face_recognition_8-master_2\Data.mdf;Integrated Security=True");
            connection1.Open();
            SqlCommand cmd1 = new SqlCommand("Select * from [Table]", connection);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            connection1.Close();
        }

        private void ShowMyData_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }
    }
}
