using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ROOTHY
{
    public partial class txtduzenle : Form
    {
       public OpenFileDialog file = new OpenFileDialog();
        public string DosyaYolu;
        public string DosyaAdi;
       

        public txtduzenle()
        {
            InitializeComponent();
        }


        public void txticindensil()
        {

            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            file.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            file.Title = "txt Dosyası Seçiniz...";
            file.ShowDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = file.FileName;
                string DosyaAdi = file.SafeFileName;
                vButton1.Enabled = true;
               
                comboBox1.Enabled = true;
            }
            
           


        }

        private void xmldonustur_Click(object sender, EventArgs e)
        {
        }

        private void txtsec_Click_1(object sender, EventArgs e)
        {
           
            txticindensil();
            label2.Text = file.FileName;
           
        }

        private void vButton1_Click(object sender, EventArgs e)
        {

            StringBuilder newFile = new StringBuilder();
            string temp = "";
            string[] file2 = File.ReadAllLines(file.FileName);
            string sil = "'";
            string tag1 = "<" + comboBox1.Text + ">";
            string tag2 = "</" + comboBox1.Text + ">";
            foreach (string line in file2)
            {
                if (line.Contains(sil))
                {
                    temp = line.Replace(sil, "");
                    newFile.Append(temp + "\r\n");
                    continue;
                }
                newFile.Append(line + "\r\n");
            }

            File.WriteAllText(file.FileName, tag1 + newFile.ToString() + tag2);

            MessageBox.Show(file.SafeFileName + "\t dosyası xml dönüştürüldü.");
        }

        
    }
}
