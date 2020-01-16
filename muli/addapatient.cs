using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using mlava;

namespace MultiFaceRec
{
    public partial class addapatient : Form
    {
        

        public addapatient()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string st = "sick";
            Singleton user = Singleton.Instance;
            string nameuser = user.getuser();
            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\amara\Desktop\master\Data.mdf; Integrated Security = True");
            SqlCommand cmd;
            connection.Open();
            string sqlQvery = "Insert into [Table](username,password,kind,work,lastname,phonenumber)Values('" + textBox1.Text + "','" + textBox2.Text +"','" + st + "','" + nameuser +"','" +textBox4.Text+ "',@phonenumber)"; 
            cmd = new SqlCommand(sqlQvery, connection);
            cmd.Parameters.Add(new SqlParameter("@phonenumber", int.Parse(textBox5.Text)));
            
           
            /*
            cmd.Parameters.Add(new SqlParameter("@password", textBox2.Text));
            cmd.Parameters.Add(new SqlParameter("@work", nameuser));
            cmd.Parameters.Add(new SqlParameter("@kind", "sick"));
            cmd.Parameters.Add(new SqlParameter("@lastname", textBox4.Text));
            cmd.Parameters.Add(new SqlParameter("@phonenumber", int.Parse(textBox5.Text)));*/
            int N = cmd.ExecuteNonQuery();
            MessageBox.Show("Datas Saved Successfully ");
            
            connection.Close();
        }

        private void addapatient_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
