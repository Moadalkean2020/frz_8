using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Data.SqlClient;

namespace mlava
{
    public partial class My_partner_details : Form
    {
        public My_partner_details()
        {
            InitializeComponent();
        }

        private void My_partner_details_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amara\Desktop\face_recognition_8-master_2\Data.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Table] ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Singleton user = Singleton.Instance;
            string nameuser = user.getuser();
            
           
            foreach (DataRow row in dt.Rows ) 
            {
                
                string nameu = row["username"].ToString();
                if (nameu == nameuser && row["kind"].ToString() == "sick")
                {
                    string name = row["work"].ToString();
                    
                    label2.Text = name;
                    SqlDataAdapter sda2 = new SqlDataAdapter("Select * From [Table] WHERE username = '" + name + "'", con);
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);
                    string lname = dt2.Rows[0][4].ToString();
                    string pnum = dt2.Rows[0][5].ToString();
                    label1.Text = pnum;
                    label3.Text = lname;

                    //listBox1.Items.Add(name);

                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
