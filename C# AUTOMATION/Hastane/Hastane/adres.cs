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
    public partial class adres : Form
    {
       
        public adres()
        {
            InitializeComponent();
        }
        void grid_doldur()
        {
            sunucu_isim sunucu = new sunucu_isim();
            string isim = sunucu_isim.isim;

            SqlConnection bag = new SqlConnection("Data Source = " + isim + "; initial catalog = hastane; integrated security = true;");




            SqlCommand komut = new SqlCommand("select * from doktor_adres", bag);
            SqlDataAdapter adap = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            adap.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
            bunifuDataGridView1.Refresh();
        }
        private void laboratuvar_Load(object sender, EventArgs e)
        {
            grid_doldur();
        }

        

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            adres_doktor ekle = new adres_doktor();
            ekle.Dock = DockStyle.Fill;
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            adres_temizlikci ekle = new adres_temizlikci();
            ekle.Dock = DockStyle.Fill;
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            adres_resepsiyon ekle = new adres_resepsiyon();
            ekle.Dock = DockStyle.Fill;
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
        }
    }
}
