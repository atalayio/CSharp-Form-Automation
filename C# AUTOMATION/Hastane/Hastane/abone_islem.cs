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

    public partial class abone_islem : Form
    {
       
        public abone_islem()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sunucu_isim sunucu = new sunucu_isim();
            string isim = sunucu_isim.isim;

            SqlConnection bag = new SqlConnection("Data Source = " + isim + "; initial catalog = hastane; integrated security = true;");




            bag.Open();
            SqlCommand kmt = new SqlCommand("insert into abone (kullanici_adi,kullanici_soyad,tc_kimlik,dogum_tarihi,dogum_yeri,abone_turu)values(@kullanici_adi,@kullanici_soyad,@tc_kimlik,@dogum_tarihi,@dogum_yeri,@abone_turu)", bag);
            kmt.Parameters.Add("@kullanici_adi", SqlDbType.NVarChar).Value = bunifuTextBox1.Text;
            kmt.Parameters.Add("@kullanici_soyad", SqlDbType.NVarChar).Value = bunifuTextBox2.Text;
            kmt.Parameters.Add("@tc_kimlik", SqlDbType.VarChar).Value = bunifuTextBox3.Text;
            kmt.Parameters.Add("@dogum_tarihi", SqlDbType.DateTime).Value = bunifuDatePicker1.Text;
            kmt.Parameters.Add("@dogum_yeri", SqlDbType.NVarChar).Value = bunifuTextBox4.Text;
            kmt.Parameters.Add("@abone_turu", SqlDbType.NVarChar).Value = guna2ComboBox3.SelectedItem;
            












            kmt.ExecuteNonQuery();
            label4.Visible = true;

            grid_doldur();
        }
        void grid_doldur()
        {
            sunucu_isim sunucu = new sunucu_isim();
            string isim = sunucu_isim.isim;

            SqlConnection bag = new SqlConnection("Data Source = " + isim + "; initial catalog = hastane; integrated security = true;");




            SqlCommand cmd = new SqlCommand("select * from abone", bag);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adap.Fill(dt);

            bunifuDataGridView1.DataSource = dt;

            bunifuDataGridView1.Refresh();


        }
        private void abone_islem_Load(object sender, EventArgs e)
        {
            grid_doldur();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label14.Visible = false;
        }
    }
}
