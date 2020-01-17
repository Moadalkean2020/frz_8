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
    public partial class infPAM : Form
    {
        public infPAM()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void infPAM_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amara\Desktop\face_recognition_8-master_2\Data.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Table] ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                string kind = row["kind"].ToString();
                if (kind == "partner")
                    listBox1.Items.Add(row["username"].ToString());

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
    }
}
