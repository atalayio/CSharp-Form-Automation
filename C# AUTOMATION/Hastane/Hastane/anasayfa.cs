using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Hastane
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
            picturebox1.Visible = false;
            guna2PictureBox2.Visible = false;
            guna2PictureBox3.Visible = false;
            guna2PictureBox4.Visible = false;
            guna2PictureBox5.Visible = false;
            


        }
        public int pas;

        private void anasayfa_Load(object sender, EventArgs e)
        {
            pas = this.Location.X;
        }
        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            giris git = new giris();
            git.Show();
            this.Hide();
        }



        
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            picturebox1.Visible = true;
            guna2PictureBox2.Visible = false;
            guna2PictureBox3.Visible = false;
            guna2PictureBox4.Visible = false;
            guna2PictureBox5.Visible = false;
            

            panel2.Controls.Clear();
            hasta ekle = new hasta();
            ekle.Dock = DockStyle.Fill;
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();














        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            picturebox1.Visible = false;
            guna2PictureBox2.Visible = false;
            guna2PictureBox3.Visible = false;
            guna2PictureBox4.Visible = true;
            guna2PictureBox5.Visible = false;
            




            panel2.Controls.Clear();
            adres ekle = new adres();
            ekle.Dock = DockStyle.Fill;
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();




        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            



            picturebox1.Visible = false;
            guna2PictureBox2.Visible = true;
            guna2PictureBox3.Visible = false;
            guna2PictureBox4.Visible = false;
            guna2PictureBox5.Visible = false;
            




            panel2.Controls.Clear();
            abone ekle = new abone();
            ekle.Dock = DockStyle.Fill;
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();








        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            picturebox1.Visible = false;
            guna2PictureBox2.Visible = false;
            guna2PictureBox3.Visible = true;
            guna2PictureBox4.Visible = false;
            guna2PictureBox5.Visible = false;
            


            panel2.Controls.Clear();
            calisanlar ekle = new calisanlar();
            ekle.Dock = DockStyle.Fill;
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
        }

        private void picturebox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            picturebox1.Visible = false;
            guna2PictureBox2.Visible = false;
            guna2PictureBox3.Visible = false;
            guna2PictureBox4.Visible = false;
            guna2PictureBox5.Visible = true;
           



            panel2.Controls.Clear();
            randevu_tablo ekle = new randevu_tablo();
            ekle.Dock = DockStyle.Fill;
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void guna2Button11_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/atalayxd/");
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/emin-atalay-345846204/");
        }

       

        

        

        
        

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/ahmet-emir-özen-b4383a203/");
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            Process.Start("https://mailto:ahmetemir58@hotmail.com");
        }

        private void guna2Button10_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://mailto:eminatalay@outlook.com");
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/emirrozenn/?hl=tr");
        }

        
    }
}
