using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ROOTHY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
          
        }
        private void Form1_Load(object sender, EventArgs e)
        {
      
        }
        private void vCircularButton5_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
               
            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }

        }

        private void vLabel1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {

            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }


        }

        private void vButton2_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            canliekran newForm = new canliekran();
            newForm.TopLevel = false;
            panel4.Controls.Add(newForm);
            newForm.Show();
            newForm.Dock = DockStyle.Fill;
            newForm.BringToFront();
        }

        private void vButton3_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            hesapkapama newForm = new hesapkapama();
            newForm.TopLevel = false;
            panel4.Controls.Add(newForm);
            newForm.Show();
            newForm.Dock = DockStyle.Fill;
            newForm.BringToFront();
        }

        private void vButton1_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            xmlaktarim newForm = new xmlaktarim();
            newForm.TopLevel = false;
            panel4.Controls.Add(newForm);
            newForm.Show();
            newForm.Dock = DockStyle.Fill;
            newForm.BringToFront();
        }

        private void vCircularButton4_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            mainpage newForm = new mainpage();
            newForm.TopLevel = false;
            panel4.Controls.Add(newForm);
            newForm.Show();
            newForm.Dock = DockStyle.Fill;
            newForm.BringToFront();
        }

        private void vButton5_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            kasa newForm = new kasa();
            newForm.TopLevel = false;
            panel4.Controls.Add(newForm);
            newForm.Show();
            newForm.Dock = DockStyle.Fill;
            newForm.BringToFront();
        }

        private void vButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
