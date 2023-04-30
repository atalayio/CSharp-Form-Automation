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
    public partial class anasayfa_kul : Form
    {
        public anasayfa_kul()
        {
            InitializeComponent();
            picturebox1.Visible = false;
            guna2PictureBox2.Visible = false;
            guna2PictureBox3.Visible = false;
            
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            randevu ekle = new randevu();
            ekle.Dock = DockStyle.Fill;
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();

            picturebox1.Visible = true;
            guna2PictureBox2.Visible = false;
            guna2PictureBox3.Visible = false;
            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            giris_kul git = new giris_kul();
            git.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            abone_menu ekle = new abone_menu();
            ekle.Dock = DockStyle.Fill;
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();




            picturebox1.Visible = false;
            guna2PictureBox2.Visible = true;
            guna2PictureBox3.Visible = false;
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            picturebox1.Visible = false;
            guna2PictureBox2.Visible = false;
            guna2PictureBox3.Visible = true;

            panel2.Controls.Clear();
            doktor_kul_bilgi ekle = new doktor_kul_bilgi();
            ekle.Dock = DockStyle.Fill;
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();

        }

        

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/atalayxd/");
        }

        private void anasayfa_kul_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/emin-atalay-345846204/"); 
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            Process.Start("https://mailto:eminatalay@outlook.com");
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/ahmet-emir-özen-b4383a203/");
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            Process.Start("https://mailto:ahmetemir58@hotmail.com");
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/emirrozenn/?hl=tr");
        }
    }
    
}
