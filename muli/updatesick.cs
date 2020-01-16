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
using mlava;

namespace MultiFaceRec
{
    public partial class updatesick : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\amara\Desktop\master\Data.mdf; Integrated Security = True");

        SqlCommand cmd = new SqlCommand();
        private SqlCommand cmd2;

        public updatesick()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amara\Desktop\master\Data.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Table] ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Singleton user = Singleton.Instance;
            string nameuser = user.getuser();
            foreach (DataRow row in dt.Rows)
            {
                if (row["kind"].ToString() == "sick" && row["work"].ToString() == nameuser)
                {
                    listBox1.Items.Add(string.Format(" name : {0} {1} | phone number  : {2} |", row["username"], row["lastname"], row["phonenumber"]));
                }

            }
        }

        private void updatesick_Load(object sender, EventArgs e)
        {
            //TODO ::
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from [Table] where username=@username ", connection);
            cmd.Parameters.AddWithValue("@username", (textBox3.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //dataGridView1.DataSource = dt;
            
            string firstname = dt.Rows[0][0].ToString();
            string lastname = dt.Rows[0][4].ToString();

            textBox2.Text = firstname;
            textBox1.Text = lastname;
            textBox4.Text = dt.Rows[0][5].ToString();
           
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

           

            //---------------------------------------------------------------
           

            connection.Open();
            string cmd2 = "Update [Table] set username='" + textBox2.Text + "', lastname='" + textBox1.Text + "' , phonenumber = '" + int.Parse(textBox4.Text)+ "' where username = '" + textBox3.Text + " '";

            SqlCommand check = new SqlCommand(cmd2, connection);
            check.ExecuteNonQuery();
            
            MessageBox.Show("Datas Update Successfully ");
            connection.Close();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //TODO ::
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
    }

