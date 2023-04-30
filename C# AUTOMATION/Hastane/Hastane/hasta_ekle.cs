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
     
    
    public partial class hasta_ekle : Form
    {
       

        public hasta_ekle()
        {
            InitializeComponent();
        }







        void grid_doldur()
        {
            sunucu_isim sunucu = new sunucu_isim();
            string isim = sunucu_isim.isim;

            SqlConnection bag = new SqlConnection("Data Source = " + isim + "; initial catalog = hastane; integrated security = true;");




            SqlCommand cmd = new SqlCommand("select * from hasta_bilgi",bag);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adap.Fill(dt);

            bunifuDataGridView1.DataSource = dt;

            bunifuDataGridView1.Refresh();


        }


        private void hasta_ekle_Load(object sender, EventArgs e)
        {
            grid_doldur();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        

       

        private void panel1_ParentChanged(object sender, EventArgs e)
        {

        }

        

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            label2.Visible = false;
            label10.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sunucu_isim sunucu = new sunucu_isim();
            string isim = sunucu_isim.isim;

            SqlConnection bag = new SqlConnection("Data Source = " + isim + "; initial catalog = hastane; integrated security = true;");




            if (bag.State != ConnectionState.Open)
            {
                bag.Open();
            }


            SqlCommand kmt = new SqlCommand("insert into hasta_bilgi (kullanici_adi,kullanici_sifre,ad,soyad,tc,dogum_yeri,dogum_yili,cinsiyet)values(@kullanici_adi,@kullanici_sifre,@ad,@soyad,@tc,@dogum_yeri,@dogum_yili,@cinsiyet)", bag);
            kmt.Parameters.Add("@kullanici_adi", SqlDbType.NVarChar).Value = bunifuTextBox1.Text;
            kmt.Parameters.Add("@kullanici_sifre", SqlDbType.NVarChar).Value = bunifuTextBox2.Text;
            kmt.Parameters.Add("@ad", SqlDbType.NVarChar).Value = bunifuTextBox3.Text;
            kmt.Parameters.Add("@soyad", SqlDbType.NVarChar).Value = bunifuTextBox4.Text;
            kmt.Parameters.Add("@tc", SqlDbType.VarChar).Value = bunifuTextBox5.Text;
            kmt.Parameters.Add("@dogum_yeri", SqlDbType.NVarChar).Value = bunifuTextBox6.Text;
            kmt.Parameters.Add("@dogum_yili", SqlDbType.NVarChar).Value = bunifuTextBox7.Text;
            kmt.Parameters.Add("@cinsiyet", SqlDbType.NVarChar).Value = guna2ComboBox1.SelectedItem;


            bunifuTextBox1.Clear();
            bunifuTextBox2.Clear();
            bunifuTextBox3.Clear();
            bunifuTextBox4.Clear();
            bunifuTextBox5.Clear();
            bunifuTextBox6.Clear();
            bunifuTextBox7.Clear();


            kmt.ExecuteNonQuery();
            grid_doldur();

            label10.Visible = true;
            label2.Visible = true;
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void bunifuTextBox5_TextChanged(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void bunifuTextBox6_TextChanged(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void bunifuTextBox7_TextChanged(object sender, EventArgs e)
        {
            label10.Visible = false;
        }
    }
}
