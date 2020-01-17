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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amara\Desktop\face_recognition_8-master_2\Data.mdf;Integrated Security=True");
        string imglo = "";
        SqlCommand cmd;
        private void button1_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglo = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglo;

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            //---------------------------------------------------------------
            byte[] images = null;
            FileStream streem = new FileStream(imglo, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);
            images = brs.ReadBytes((int)streem.Length);

            connection.Open();
            string sqlQvery = "Update  infTable set firstname=@firstname ,LastName=@LastName,photo=@photo where theid=@theid";
            cmd = new SqlCommand(sqlQvery, connection);
            cmd.Parameters.Add(new SqlParameter("@theid", textBox3.Text));
            
            cmd.Parameters.Add(new SqlParameter("@firstname", textBox1.Text));
            
            cmd.Parameters.Add(new SqlParameter("@LastName", textBox2.Text));
            
          
            cmd.Parameters.Add(new SqlParameter("@photo", images));
            int N = cmd.ExecuteNonQuery();
            MessageBox.Show(N.ToString() + "Datas Update Successfully ");
            connection.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amara\Desktop\face_recognition_8-master_2\Data.mdf;Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from infTable where theid=@theid ", connection);
            cmd.Parameters.AddWithValue("@theid", int.Parse(textBox3.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //dataGridView1.DataSource = dt;
            pictureBox1.Visible = true;

            string firstname = dt.Rows[0][1].ToString();
            string lastname = dt.Rows[0][2].ToString();
            textBox1.Text = firstname;
            textBox2.Text = lastname;
            byte[] img = (byte[])dt.Rows[0][3];
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            connection.Close();

        }
    }
}
