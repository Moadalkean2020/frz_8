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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\amara\Desktop\master\Data.mdf; Integrated Security = True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("Delete infTable where theid=@theid", connection);
            cmd.Parameters.AddWithValue("@theid",int .Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Successfully Deleteds");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }
    }
}
