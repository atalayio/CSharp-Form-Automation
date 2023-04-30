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
    public partial class adres_resepsiyon : Form
    {
        
        public adres_resepsiyon()
        {
            InitializeComponent();
        }
        void grid_doldur()
        {
            sunucu_isim sunucu = new sunucu_isim();
            string isim = sunucu_isim.isim;

            SqlConnection bag = new SqlConnection("Data Source = " + isim + "; initial catalog = hastane; integrated security = true;");




            SqlCommand komut = new SqlCommand("select * from resepsiyon_adres", bag);
            SqlDataAdapter adap = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            adap.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
            bunifuDataGridView1.Refresh();
        }
        private void adres_resepsiyon_Load(object sender, EventArgs e)
        {
            grid_doldur();
        }
    }
}
