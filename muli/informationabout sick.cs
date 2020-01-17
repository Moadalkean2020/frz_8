using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using mlava;

namespace MultiFaceRec
{
    public partial class informationabout_sick : Form
    {
        public informationabout_sick()
        {
            InitializeComponent();
        }

        private void informationabout_sick_Load(object sender, EventArgs e)
        {
            // String source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\אלטורי\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amara\Desktop\face_recognition_8-master_2\Data.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Table] ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Singleton user = Singleton.Instance;
            string nameuser = user.getuser();
            foreach (DataRow row in dt.Rows)
            { 
               if(row["kind"].ToString() == "sick" && row["work"].ToString() == nameuser)
                {
                    listBox1.Items.Add(string.Format(" name : {0} {1} | phone number  : {2} |", row["username"], row["lastname"], row["phonenumber"]));
                }
                
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
