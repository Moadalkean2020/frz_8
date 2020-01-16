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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
                
        }

        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\amara\Desktop\master\Data.mdf; Integrated Security = True");
        string imglo = "";
        SqlCommand cmd;
        private void button1_Click(object sender, EventArgs e)
        {
            
            byte[] images = null;
            FileStream streem = new FileStream(imglo,FileMode.Open,FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);
            images = brs.ReadBytes((int)streem.Length);

            connection.Open();
            string sqlQvery = "Insert into infTable(theid,firstname,LastName,photo)Values('" + textBox3.Text+ "','"+ textBox1.Text + "','" + textBox2.Text+ "',@images)";
            cmd = new SqlCommand(sqlQvery,connection);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            int N = cmd.ExecuteNonQuery();
            MessageBox.Show( "Datas Saved Successfully ");
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglo =dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglo;

            }
            pictureBox1.Visible = true;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }

        private void Insert_Load(object sender, EventArgs e)
        {

        }
    }

}
