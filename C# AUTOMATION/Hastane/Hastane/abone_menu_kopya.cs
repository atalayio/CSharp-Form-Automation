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
    public partial class abone_menu_kopya : Form
    {
        
        public abone_menu_kopya()
        {
            InitializeComponent();
        }



        private void abone_menu_kopya_Load(object sender, EventArgs e)
        {
            sunucu_isim sunucu = new sunucu_isim();
            string isim = sunucu_isim.isim;

            SqlConnection bag = new SqlConnection("Data Source = " + isim + "; initial catalog = hastane; integrated security = true;");




            bag.Open();
            SqlCommand doktor = new SqlCommand("select dbo.fn_AboneSayisi()", bag);
            label23.Text = doktor.ExecuteScalar().ToString();
        }



        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button15_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button16_MouseHover_1(object sender, EventArgs e)
        {
            label39.ForeColor = Color.MediumSlateBlue;
            label40.ForeColor = Color.MediumSlateBlue;

        }

        private void guna2Button16_MouseLeave_1(object sender, EventArgs e)
        {
            label39.ForeColor = Color.White;
            label40.ForeColor = Color.White;

        }

        private void guna2Button15_MouseHover(object sender, EventArgs e)
        {
            label35.ForeColor = Color.MediumSlateBlue;
           

        }

        private void guna2Button15_MouseLeave_1(object sender, EventArgs e)
        {
            label35.ForeColor = Color.White;
        }

        private void guna2Button14_MouseHover(object sender, EventArgs e)
        {
            label33.ForeColor = Color.MediumSlateBlue;
            label34.ForeColor = Color.MediumSlateBlue;
        }

        private void guna2Button14_MouseLeave_1(object sender, EventArgs e)
        {
            label33.ForeColor = Color.White;
            label34.ForeColor = Color.White;
        }

        private void guna2Button13_MouseHover(object sender, EventArgs e)
        {
            label32.ForeColor = Color.MediumSlateBlue;
            
        }

        private void guna2Button13_MouseLeave(object sender, EventArgs e)
        {
            label32.ForeColor = Color.White;
        }

        private void guna2Button12_MouseHover(object sender, EventArgs e)
        {
            label30.ForeColor = Color.MediumSlateBlue;
            label31.ForeColor = Color.MediumSlateBlue;
        }

        private void guna2Button12_MouseLeave(object sender, EventArgs e)
        {
            label30.ForeColor = Color.White;
            label31.ForeColor = Color.White;

        }

        private void guna2Button11_MouseHover(object sender, EventArgs e)
        {
            label29.ForeColor = Color.MediumSlateBlue;
            label28.ForeColor = Color.MediumSlateBlue;

        }

        private void guna2Button11_MouseLeave(object sender, EventArgs e)
        {
            label29.ForeColor = Color.White;
            label28.ForeColor = Color.White;
        }

        private void guna2Button10_MouseHover(object sender, EventArgs e)
        {
            label26.ForeColor = Color.MediumSlateBlue;
            label27.ForeColor = Color.MediumSlateBlue; 
        }

        private void guna2Button10_MouseLeave(object sender, EventArgs e)
        {

        }

        private void guna2Button9_MouseHover(object sender, EventArgs e)
        {
            label25.ForeColor = Color.MediumSlateBlue;
            
        }

        private void guna2Button9_MouseLeave(object sender, EventArgs e)
        {
            label25.ForeColor = Color.White;

        }
    }
}
