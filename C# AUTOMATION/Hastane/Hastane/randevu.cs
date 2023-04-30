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
    public partial class randevu : Form
    {
       
        public randevu()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2ComboBox2.Items.Clear();

            if (guna2ComboBox1.SelectedItem == "Nöroloji")
            {
                guna2ComboBox2.Items.Add("Ahmet Teber");
                guna2ComboBox2.SelectedItem += ("Ahmet Teber");

            }
            else if (guna2ComboBox1.SelectedItem == "Gastroenteroloji")
            {
                guna2ComboBox2.Items.Add("Büşra Yılmaz");
                guna2ComboBox2.SelectedItem += ("Büşra Yılmaz");
            }
            else if (guna2ComboBox1.SelectedItem == "Göz Hastalıkları")
            {
                guna2ComboBox2.Items.Add("Ceren Kaya");
                guna2ComboBox2.SelectedItem += ("Ceren Kaya");
            }
            
            else if (guna2ComboBox1.SelectedItem == "Üroloji")
            {
                guna2ComboBox2.Items.Add("Murat Çelik");
                guna2ComboBox2.SelectedItem += ("Murat Çelik");
            }
            else if (guna2ComboBox1.SelectedItem == "Psikiyatri")
            {
                guna2ComboBox2.Items.Add("Kemal Şahin");
                guna2ComboBox2.SelectedItem += ("Kemal Şahin");
            }
            else if (guna2ComboBox1.SelectedItem == "İç Hastalıkları")
            {
                guna2ComboBox2.Items.Add("Süha Yıldız");
                guna2ComboBox2.SelectedItem += ("Süha Yıldız");
            }
            else if (guna2ComboBox1.SelectedItem == "Algoloji")
            {
                guna2ComboBox2.Items.Add("Emir Yıldırım");
                guna2ComboBox2.SelectedItem += ("Emir Yıldırım");
            }
            else if (guna2ComboBox1.SelectedItem == "Dermatoloji")
            {
                guna2ComboBox2.Items.Add("Aylin Öztürk");
                guna2ComboBox2.SelectedItem += ("Aylin Öztürk");
            }
            else if (guna2ComboBox1.SelectedItem == "Hermatoloji")
            {
                guna2ComboBox2.Items.Add("Seher Aydın");
                guna2ComboBox2.SelectedItem += ("Seher Aydın");
            }
            else if (guna2ComboBox1.SelectedItem == "Beslenme ve Diyet")
            {
                guna2ComboBox2.Items.Add("Batıkan Doğan");
                guna2ComboBox2.SelectedItem += ("Batıkan Doğan");
            }
            else if (guna2ComboBox1.SelectedItem == "Çocuk Hastalıkları")
            {
                guna2ComboBox2.Items.Add("Yavuz Özdemir");
                guna2ComboBox2.SelectedItem += ("Yavuz Özdemir");
            }
            else if (guna2ComboBox1.SelectedItem == "Kardiyoloji")
            {
                guna2ComboBox2.Items.Add("Hasan Kaya");
                guna2ComboBox2.SelectedItem += ("Hasan Kaya");
            }
            

            label12.Visible = false;
        }

        private void guna2ComboBox1_TextChanged(object sender, EventArgs e)
        {
            
            }

        private void randevu_Load(object sender, EventArgs e)
        {
            
            grid_doldur();
        }


        void grid_doldur()
        {
            sunucu_isim sunucu = new sunucu_isim();
            string isim = sunucu_isim.isim;

            SqlConnection bag = new SqlConnection("Data Source = " + isim + "; initial catalog = hastane; integrated security = true;");




            SqlCommand cmd = new SqlCommand("select * from hasta_bilgi", bag);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adap.Fill(dt);

            bunifuDataGridView1.DataSource = dt;

            bunifuDataGridView1.Refresh();


        }
        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label14.Visible = false;
        }

        private void guna2ComboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            label13.Visible = false;
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
            SqlCommand kmt = new SqlCommand("insert into randevu (tc_kimlik,kullanici_ad,kullanici_soyad,poliklinik,doktor,randevu_tarih,randevu_saati)values(@tc_kimlik,@kullanici_ad,@kullanici_soyad,@poliklinik,@doktor,@randevu_tarih,@randevu_saati)", bag);
            kmt.Parameters.Add("@tc_kimlik", SqlDbType.VarChar).Value = bunifuTextBox1.Text;
            kmt.Parameters.Add("@kullanici_ad", SqlDbType.NVarChar).Value = bunifuTextBox2.Text;
            kmt.Parameters.Add("@kullanici_soyad", SqlDbType.NVarChar).Value = bunifuTextBox3.Text;
            kmt.Parameters.Add("@poliklinik", SqlDbType.NVarChar).Value = guna2ComboBox1.SelectedItem;
            kmt.Parameters.Add("@doktor", SqlDbType.NVarChar).Value = guna2ComboBox2.SelectedItem;
            kmt.Parameters.Add("@randevu_tarih", SqlDbType.NVarChar).Value = bunifuDatePicker1.Text;
            kmt.Parameters.Add("@randevu_saati", SqlDbType.NVarChar).Value = guna2ComboBox3.Text;
            











            kmt.ExecuteNonQuery();

            grid_doldur();
            label1.Visible = true;
            label2.Visible = true;

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
