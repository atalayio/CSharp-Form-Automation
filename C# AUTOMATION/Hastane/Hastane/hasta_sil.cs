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

    public partial class hasta_sil : Form
    {
       


        public hasta_sil()
        {
            InitializeComponent();
        }

        void grid_doldur()
        {
            sunucu_isim sunucu = new sunucu_isim();
            string isim = sunucu_isim.isim;

            SqlConnection bag = new SqlConnection("Data Source = " + isim + "; initial catalog = hastane; integrated security = true;");




            SqlCommand komut = new SqlCommand("select * from hasta_bilgi", bag);
            SqlDataAdapter adap = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            adap.Fill(dt);

            bunifuDataGridView1.DataSource = dt;
            bunifuDataGridView1.Refresh();

        }

        

        private void hasta_sil_Load(object sender, EventArgs e)
        {
            grid_doldur();
        }

        

        

        

        

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili_indeks = bunifuDataGridView1.SelectedCells[0].RowIndex;
            bunifuTextBox1.Text = bunifuDataGridView1.Rows[secili_indeks].Cells[5].Value.ToString();
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

            SqlCommand kmt = new SqlCommand("delete from hasta_bilgi where tc='" + bunifuTextBox1.Text + "'", bag);

            DialogResult sonuc;

            sonuc = MessageBox.Show(bunifuTextBox1.Text + " TC NO'lu kaydı gerçekten silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (sonuc == DialogResult.Yes)
            {
                SqlDataAdapter adap = new SqlDataAdapter();
                adap.DeleteCommand = kmt;                  
                kmt.ExecuteNonQuery();
                
                bunifuTextBox1.Clear();
                grid_doldur();
                MessageBox.Show("Kayıt başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bunifuTextBox1.Clear();
                grid_doldur();
            }
        }
    }
}
