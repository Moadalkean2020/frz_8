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
using System.Security.Cryptography;
using mlava;

namespace MultiFaceRec
{
    public partial class detect_by_cam : Form
    {
       

        bool check = false;
        
        public enum CompareResult
        {
            ciCompareOk,
            ciPixelMismatch,
            ciSizeMismatch
        };
        public static CompareResult Compare(Image bmp1, Image bmp2)
        {
            CompareResult cr = CompareResult.ciCompareOk;

            //Test to see if we have the same size of image
            if (bmp1.Size != bmp2.Size)
            {
                cr = CompareResult.ciSizeMismatch;
            }
            else
            {
                //Convert each image to a byte array
                System.Drawing.ImageConverter ic = new System.Drawing.ImageConverter();
                byte[] btImage1 = new byte[1];
                btImage1 = (byte[])ic.ConvertTo(bmp1, btImage1.GetType());
                byte[] btImage2 = new byte[1];
                btImage2 = (byte[])ic.ConvertTo(bmp2, btImage2.GetType());

                //Compute a hash for each image
                SHA256Managed shaM = new SHA256Managed();
                byte[] hash1 = shaM.ComputeHash(btImage1);
                byte[] hash2 = shaM.ComputeHash(btImage2);

                //Compare the hash values
                for (int i = 0; i < hash1.Length && i < hash2.Length && cr == CompareResult.ciCompareOk; i++)
                {
                    if (hash1[i] != hash2[i])
                        cr = CompareResult.ciPixelMismatch;
                }
            }
            return cr;
        }
        public detect_by_cam()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            
        }
        string imglo = "";
        private void button4_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglo = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglo;

            }
            label5.Visible = true;
        }


   

    private void button2_Click(object sender, EventArgs e)
        {
            
            try {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amara\Desktop\face_recognition_8-master_2\Data.mdf;Integrated Security=True");
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from infTable", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int i = 0;
               
                foreach (DataRow row in dt.Rows)
                {

                    byte[] img = (byte[])dt.Rows[i][3];
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox2.Image = Image.FromStream(ms);
                    CompareResult cr;
                    cr = Compare(pictureBox1.Image, pictureBox2.Image);

                    if (cr == CompareResult.ciCompareOk)
                    {

                        label3.Text = dt.Rows[i][1].ToString();
                        label4.Text = dt.Rows[i][2].ToString();

                        label3.Visible = true;
                        label4.Visible = true;
                        label1.Visible = true;
                        label2.Visible = true;

                        check = true;
                        break;


                    }
                    if (check == true)
                    {
                     
                            break;
                    }
                        

                    
                    i++;
                   
                }

                if (check == false)
                {

                    pictureBox2.Image = Image.FromFile(@"C:\Users\wajdial\Desktop\face_recognition_8-master\Resources\4926305-red-x.jpg");
                  
                    MessageBox.Show("אין זיהוי לתמונה כזאת");
                    
                      
                }
            }
            catch (Exception)
            {
                pictureBox2.Image = null;
                MessageBox.Show("נא להזנת את התמונה נכון");
                
            }
            
            }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = null;
            label4.Text = null;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }

        private void detect_by_cam_Load(object sender, EventArgs e)
        {
            button5.Visible = false; ;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amara\Desktop\face_recognition_8-master_2\Data.mdf;Integrated Security=True");
         SqlDataAdapter sda = new SqlDataAdapter("Select * From [Table] ", con);
         DataTable dt1 = new DataTable();
         sda.Fill(dt1);
         Singleton user = Singleton.Instance;
         string nameuser = user.getuser();
           foreach (DataRow row in dt1.Rows)
           {

               string nameu = row["username"].ToString();
               if (nameu == nameuser && row["kind"].ToString() == "partner")
               {
                   button5.Visible = true;
               }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (check == true)
            {
                //askingitem che = new askingitem();
                //che.Show();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(" ?אין תמונה כזאת במערכת רוצה להוסיף אותו  ", "ERROR ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Insert insnew = new Insert();
                    this.Hide();
                    insnew.Show();

                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

    }
}
