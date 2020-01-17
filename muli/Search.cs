using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace mlava
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            label4.Visible = false;
            label3.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amara\Desktop\face_recognition_8-master_2\Data.mdf;Integrated Security=True");
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from infTable where theid=@theid ", connection);
                cmd.Parameters.AddWithValue("@theid", int.Parse(textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //dataGridView1.DataSource = dt;


                string firstname = dt.Rows[0][1].ToString();
                string lastname = dt.Rows[0][2].ToString();
                label5.Text = firstname;
                label6.Text = lastname;
                label4.Visible = true;
                label3.Visible = true;
                label6.Visible = true;
                label5.Visible = true;
                pictureBox1.Visible = true;

                byte[] img = (byte[])dt.Rows[0][3];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                connection.Close();
            }
            catch(Exception)
            {
                MessageBox.Show(" נא להכניס מספר מזהה נכון ");
            }
           

        }

        private void Search_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label5.Text = "";
            label6.Text = "";
            
            pictureBox1.Visible = false;
        }
    }
}
