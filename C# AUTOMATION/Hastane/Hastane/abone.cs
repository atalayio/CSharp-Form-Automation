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

    public partial class abone : Form
    {




        public abone()
        {
            InitializeComponent();
            

        }
        
        void grid_doldur()
        {

            sunucu_isim sunucu = new sunucu_isim();
            string isim = sunucu_isim.isim;

            SqlConnection bag = new SqlConnection("Data Source = "+isim+"; initial catalog = hastane; integrated security = true;");
            SqlCommand komut = new SqlCommand("select * from abone", bag);
            SqlDataAdapter adap = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            adap.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
            bunifuDataGridView1.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sunucu_isim sunucu = new sunucu_isim();
            string isim = sunucu_isim.isim;
            SqlConnection bag = new SqlConnection("Data Source = " + isim + "; initial catalog = hastane; integrated security = true;");
            bag.Open();
            SqlCommand doktor = new SqlCommand("select dbo.fn_AboneSayisi()", bag);
            lbl_abone_sayi.Text = doktor.ExecuteScalar().ToString();
            
            grid_doldur();
        }
    }
}
