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

namespace Hastane
{
    public partial class giris_kul : Form
    {
        public giris_kul()
        {
            InitializeComponent();
            Init_Data();
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
            giris git = new giris();
            git.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sunucu_isim sunucu = new sunucu_isim();
            string isim = sunucu_isim.isim;

            SqlConnection bag = new SqlConnection("Data Source = " + isim + "; initial catalog = hastane; integrated security = true;");




            SqlCommand komutt = new SqlCommand("select * from hasta_bilgi where kullanici_adi = '" + guna2TextBox1.Text + "' and kullanici_sifre = '" + guna2TextBox2.Text + "' ", bag);
            SqlDataAdapter adap = new SqlDataAdapter(komutt);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Save_Data();
                timer_kul git = new timer_kul();

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

        private void giris_kul_Load(object sender, EventArgs e)
        {

        }
        private void Init_Data()
        {
            if (Properties.Settings.Default.UserNameKul != string.Empty)
            {
                if (Properties.Settings.Default.RememberKul == true)
                {
                    guna2TextBox1.Text = Properties.Settings.Default.UserNameKul;
                    guna2TextBox2.Text = Properties.Settings.Default.PasswordKul;
                    guna2CustomCheckBox1.Checked = true;


                }
                else
                {
                    guna2TextBox1.Text = Properties.Settings.Default.UserNameKul;
                }
            }

        }
        private void Save_Data()
        {
            if (guna2CustomCheckBox1.Checked)
            {
                Properties.Settings.Default.UserNameKul = guna2TextBox1.Text;
                Properties.Settings.Default.PasswordKul = guna2TextBox2.Text;
                Properties.Settings.Default.RememberKul = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserNameKul = "";
                Properties.Settings.Default.PasswordKul = "";
                Properties.Settings.Default.RememberKul = false;
                Properties.Settings.Default.Save();
            }
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "Kullanıcı adı")
            {
                guna2TextBox1.Text = "";
                guna2TextBox1.ForeColor = Color.Black;
                guna2TextBox2.ForeColor = Color.LightGray;

            }
            
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "")
            {
                guna2TextBox1.Text = "Kullanıcı adı";
                guna2TextBox1.ForeColor = Color.LightGray;

            }
        }

        private void guna2TextBox2_Enter(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "Şifre")
            {
                guna2TextBox2.Text = "";
                guna2TextBox2.ForeColor = Color.Black;
                guna2TextBox2.PasswordChar = '*';

            }
        }
        char? none = null;
        private void guna2TextBox2_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "")
            {
                guna2TextBox2.Text = "Şifre";
                guna2TextBox2.ForeColor = Color.LightGray;
                guna2TextBox2.PasswordChar = Convert.ToChar(none);

            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            sunucu_isim ekle = new sunucu_isim();
            ekle.Show();
        }
    }
}
