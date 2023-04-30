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
    public partial class abone_menu : Form
    {
        
        public abone_menu()
        {
            InitializeComponent();
        }

        private void guna2Button1_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.MediumSlateBlue;
            label3.ForeColor = Color.MediumSlateBlue;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
        }

        private void guna2Button2_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void guna2Button2_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.MediumSlateBlue;
        }

        private void guna2Button3_MouseHover(object sender, EventArgs e)
        {
            label8.ForeColor = Color.MediumSlateBlue;
            label9.ForeColor = Color.MediumSlateBlue;
        }

        private void guna2Button3_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
        }

        private void guna2Button4_MouseHover(object sender, EventArgs e)
        {
            label10.ForeColor = Color.MediumSlateBlue;
        }

        private void guna2Button4_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = Color.White;
        }

        private void guna2Button5_MouseHover(object sender, EventArgs e)
        {
            label11.ForeColor = Color.MediumSlateBlue;
            label12.ForeColor = Color.MediumSlateBlue;
        }

        private void guna2Button5_MouseLeave(object sender, EventArgs e)
        {
            label11.ForeColor = Color.White;
            label12.ForeColor = Color.White;
        }

        private void guna2Button6_MouseHover(object sender, EventArgs e)
        {
            label13.ForeColor = Color.MediumSlateBlue;
            label14.ForeColor = Color.MediumSlateBlue;
        }

        private void guna2Button6_MouseLeave(object sender, EventArgs e)
        {
            label14.ForeColor = Color.White;
            label13.ForeColor = Color.White;
        }

        private void guna2Button7_MouseHover(object sender, EventArgs e)
        {
            label15.ForeColor = Color.MediumSlateBlue;
            label16.ForeColor = Color.MediumSlateBlue;
        }

        private void guna2Button7_MouseLeave(object sender, EventArgs e)
        {
            label15.ForeColor = Color.White;
            label16.ForeColor = Color.White;
        }

        private void guna2Button8_MouseHover(object sender, EventArgs e)
        {
            label17.ForeColor = Color.MediumSlateBlue;
        }

        private void guna2Button8_MouseLeave(object sender, EventArgs e)
        {
            label17.ForeColor = Color.White;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            abone_menu_kopya ekle = new abone_menu_kopya();
            ekle.Dock = DockStyle.Fill;
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
        }

        private void abone_menu_Load(object sender, EventArgs e)
        {
            sunucu_isim sunucu = new sunucu_isim();
            string isim = sunucu_isim.isim;

            SqlConnection bag = new SqlConnection("Data Source = " + isim + "; initial catalog = hastane; integrated security = true;");




            bag.Open();
            SqlCommand doktor = new SqlCommand("select dbo.fn_AboneSayisi()", bag);
            label23.Text = doktor.ExecuteScalar().ToString();
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            abone_islem ekle = new abone_islem();
            ekle.Dock = DockStyle.Fill;
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
