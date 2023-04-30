using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Hastane
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
            Init_Data();
        }
        


        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            sunucu_isim sunucu = new sunucu_isim();
            string isim = sunucu_isim.isim;

            SqlConnection bag = new SqlConnection("Data Source = " + isim + "; initial catalog = hastane; integrated security = true;");




            SqlCommand komut = new SqlCommand("select * from kul_giris where kul_adi = '" + guna2TextBox1.Text + "' and kul_sifre = '" + guna2TextBox2.Text + "' ", bag);
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Save_Data();
                timer git = new timer();
                
                git.Show();
                this.Hide();

            }
            else
            {
                guna2Separator1.Visible = false;
                label4.Visible = true;
                guna2TextBox1.Clear();
                guna2TextBox2.Clear();
                guna2TextBox1.Focus();

               

            }

            
        }

        

       



        public int pos;

        

        

        

        private void giris_Load(object sender, EventArgs e)
        {
            pos = this.Location.X;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_Enter_1(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "Kullanıcı adı")
            {
                guna2TextBox1.Text = "";
                guna2TextBox1.ForeColor = Color.Black;
                guna2TextBox2.ForeColor = Color.LightGray;

            }
        }

        private void guna2TextBox1_Leave_1(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "")
            {
                guna2TextBox1.Text = "Kullanıcı adı";
                guna2TextBox1.ForeColor = Color.LightGray;

            }
        }

        private void guna2TextBox2_Enter_1(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "Şifre")
            {
                guna2TextBox2.Text = "";
                guna2TextBox2.ForeColor = Color.Black;
                guna2TextBox2.PasswordChar = '*';

            }
        }
        char? none = null;
        private void guna2TextBox2_Leave_1(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "")
            {
                guna2TextBox2.Text = "Şifre";
                guna2TextBox2.ForeColor = Color.LightGray;
                guna2TextBox2.PasswordChar = Convert.ToChar(none);

            }
        }

        private void guna2TextBox1_EnabledChanged(object sender, EventArgs e)
        {

        }
        private void Init_Data()
        {
            if (Properties.Settings.Default.UserName!= string.Empty)
            {
                if (Properties.Settings.Default.Remember == true)
                {
                    guna2TextBox1.Text = Properties.Settings.Default.UserName;
                    guna2TextBox2.Text = Properties.Settings.Default.Password;
                    guna2CustomCheckBox1.Checked = true;


                }
                else
                {
                    guna2TextBox1.Text = Properties.Settings.Default.UserName;
                }
            }
            
        }
        private void Save_Data()
        {
            if (guna2CustomCheckBox1.Checked)
            {
                Properties.Settings.Default.UserName = guna2TextBox1.Text;
                Properties.Settings.Default.Password = guna2TextBox2.Text;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guncel_not git = new guncel_not();
            git.Show();
        }

      


       

        

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            giris_kul git = new giris_kul();

            git.Show();
            this.Hide();
        }

        private void guna2CustomCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            sunucu_isim ekle = new sunucu_isim();
            ekle.Show();
        }
    }
}
