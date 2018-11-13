using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.XPath;

namespace ROOTHY
{
    public partial class xmlaktarim : Form
    {
        public xmlaktarim()
        {
            InitializeComponent();
        }

        string urunDosyaYolu = "";
        string urunDosyaAdi = "";

        SqlConnection cnn = new SqlConnection("Server=94.73.170.5;Database=db7FC3D727C3;User=user7FC3D727C3;Password=RootHy.11;");


        private void urunsil_Click(object sender, EventArgs e)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
            cnn.Open();
            SqlCommand cmm = new SqlCommand("Delete from Urun", cnn);
            cmm.ExecuteNonQuery();
            MessageBox.Show("Müşteri Tablosu Databaseden Silindi!!");
            cnn.Close();
        }

        private void urunaktar_Click(object sender, EventArgs e)
        {
            vProgressBar1.Maximum = dataGridView1.Rows.Count - 1;
            cnn.Open();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                SqlCommand cmm = new SqlCommand("INSERT INTO [McFlyRoothy].[dbo].[Urun]([kodu],[adi],[kdv],[tipi],[agirlik],[hacim],[fiyat],[unite],[altBirim],[birim0],[birim1],[birim2],[depozito])VALUES('" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[6].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[7].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[8].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[9].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[10].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[11].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[12].Value.ToString() + "' )", cnn);

                cmm.ExecuteNonQuery();

                Application.DoEvents();
                label1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                vProgressBar1.Value = i + 1;
            }
            MessageBox.Show("Bitti");
        }

        private void urunyukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "XML Dosyası |*.xml";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Fatura XML Dosyası Seçiniz..";

            if (file.ShowDialog() == DialogResult.OK)
            {
                urunDosyaYolu = file.FileName;
                urunDosyaAdi = file.SafeFileName;
            }
            DataSet ds = new DataSet();
            ds.ReadXml(urunDosyaYolu.ToString());
            DataTable dt = ds.Tables["URUN"];
            dataGridView1.DataSource = dt;
            DataGridViewCellStyle renk = new DataGridViewCellStyle();
            renk.BackColor = Color.PaleGreen;
        }

        string faturaDosyaAdi;
        string faturaDosyaYolu;
        SqlConnection cnn1 = new SqlConnection("Server=UMSERVER;Database=UMEDA2015; User= Sa;Password=Per102938;");

        private void faturasil_Click(object sender, EventArgs e)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
            cnn.Open();
            SqlCommand cmm = new SqlCommand("Delete from Fatura", cnn);
            cmm.ExecuteNonQuery();
            MessageBox.Show("Databaseden Fatura Tablosu Silindi");
            cnn.Close();
        }

        private void faturayukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "XML Dosyası |*.xml";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Fatura XML Dosyası Seçiniz..";

            if (file.ShowDialog() == DialogResult.OK)
            {
                faturaDosyaYolu = file.FileName;
                faturaDosyaAdi = file.SafeFileName;
            }
            DataSet ds = new DataSet();
            ds.ReadXml(faturaDosyaYolu.ToString());
            DataTable dt = ds.Tables["FIS"];
            dataGridView2.DataSource = dt;
            DataGridViewCellStyle renk = new DataGridViewCellStyle();
            renk.BackColor = Color.PaleGreen;
        }
       
        private void faturaaktar_Click(object sender, EventArgs e)
        {

            vProgressBar2.Maximum = dataGridView2.Rows.Count - 1;
            if (cnn.State == ConnectionState.Open) cnn.Close();
            if (cnn1.State == ConnectionState.Open) cnn1.Close();
            cnn.Open();
            cnn1.Open();
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                SqlCommand cmm = new SqlCommand("INSERT INTO [McFlyRoothy].[dbo].[Fatura]([fisTipi],[fisID],[fisNo],[irsTarih],[iptal],[tarih],[musKodu],[musAdi],[vergiDairesi],[vergiNumarasi],[depoKodu],[toplamBrut],[toplamIskonto],[toplamKDV],[toplamNet],[preselKodu],[dagiticiKodu],[aracKodu],[aracPlaka],[sevkNo],[vadeTarihi],[odemeTipi1],[odemeTipi2],[odemeTutari1],[odemeTutari2]) VALUES ('" + dataGridView2.Rows[i].Cells[0].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[3].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[4].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[5].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[6].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[7].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[8].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[9].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[10].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[12].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[13].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[14].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[15].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[16].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[17].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[18].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[19].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[20].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[21].Value.ToString() + "',0,0,0,0 )", cnn);
                string tarih3 = dataGridView2.Rows[i].Cells[3].Value.ToString().Replace('.', '-');
                DateTime date3 = Convert.ToDateTime(tarih3);
                string tarih5 = dataGridView2.Rows[i].Cells[5].Value.ToString().Replace('.', '-');
                DateTime date5 = Convert.ToDateTime(tarih5);
                string tarih21 = dataGridView2.Rows[i].Cells[21].Value.ToString().Replace('.', '-');
                DateTime date21 = Convert.ToDateTime(tarih21);
                SqlCommand cmm1 = new SqlCommand("INSERT INTO [McFlyRoothy].[dbo].[Fatura]([fisTipi],[fisID],[fisNo],[irsTarih],[iptal],[tarih],[musKodu],[musAdi],[vergiDairesi],[vergiNumarasi],[depoKodu],[toplamBrut],[toplamIskonto],[toplamKDV],[toplamNet],[preselKodu],[dagiticiKodu],[aracKodu],[aracPlaka],[sevkNo],[vadeTarihi],[OdemeTipi1],[OdemeTipi2],[odemeTutari1],[odemeTutari2]) VALUES ('" + dataGridView2.Rows[i].Cells[0].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[2].Value.ToString() + "','" + date3.ToString("yyyyMMdd") + "','" + dataGridView2.Rows[i].Cells[4].Value.ToString() + "','" + date5.ToString("yyyy-MM-dd") + "','" + dataGridView2.Rows[i].Cells[6].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[7].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[8].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[9].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[10].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[12].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[13].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[14].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[15].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[16].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[17].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[18].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[19].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[20].Value.ToString() + "','" + date21.ToString("yyyy-MM-dd") + "',0,0,0,0 )", cnn1);
                cmm.ExecuteNonQuery();
                cmm1.ExecuteNonQuery();
                Application.DoEvents();
                label2.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
                vProgressBar2.Value = i + 1;
            }
            MessageBox.Show("Bitti");
        }

        string kalemDosyaAdi;
        string kalemDosyaYolu;
        private void kalemsil_Click(object sender, EventArgs e)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
            cnn.Open();
            SqlCommand cmm = new SqlCommand("Delete from UrunFatura", cnn);
            cmm.ExecuteNonQuery();
            MessageBox.Show("Kalem Tablosu Databaseden Silindi!!");
            cnn.Close();
        }

        private void kalemyukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "XML Dosyası |*.xml";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Fatura XML Dosyası Seçiniz..";

            if (file.ShowDialog() == DialogResult.OK)
            {
                kalemDosyaYolu = file.FileName;
                kalemDosyaAdi = file.SafeFileName;

            }
            DataTable dt = new DataTable();
            dt.Columns.Add("Fatura No", typeof(string));
            dt.Columns.Add("UrunKodu", typeof(string));
            dt.Columns.Add("MIKTAR", typeof(string));

            XPathDocument XMLDokuman = new XPathDocument(kalemDosyaYolu);
            XPathNavigator nav = XMLDokuman.CreateNavigator();
            XPathNodeIterator nodes = nav.Select("deneme/FISLER/FIS");
            string fisno = "";
            string urunKodu = "";
            while (nodes.MoveNext())
            {
                XPathNodeIterator childNodes = nodes.Current.SelectChildren(XPathNodeType.Element);
                while (childNodes.MoveNext())
                {
                    if (childNodes.Current.Name == "FISNO")
                    {
                        fisno = childNodes.Current.Value;
                    }
                    if (childNodes.Current.Name == "KALEMLER")
                    {
                        XPathNodeIterator node = childNodes.Current.SelectChildren(XPathNodeType.Element);
                        while (node.MoveNext())
                        {
                            XPathNodeIterator node3 = node.Current.SelectChildren(XPathNodeType.Element);
                            if (node3.Current.Name == "KALEM")
                            {
                                XPathNodeIterator node4 = node3.Current.SelectChildren(XPathNodeType.Element);
                                while (node4.MoveNext())
                                {
                                    if (node4.Current.Name == "URUNKODU")
                                    {
                                        urunKodu = node4.Current.Value;
                                    }
                                    if (node4.Current.Name == "MIKTAR")
                                    {
                                        dt.Rows.Add(fisno.ToString(), urunKodu, node4.Current.Value);
                                    }
                                }
                            }
                        }
                    }
                }

            }
            dataGridView3.DataSource = dt;
        }

        private void kalemaktar_Click(object sender, EventArgs e)
        {
            vProgressBar3.Maximum = dataGridView1.Rows.Count - 1;
            cnn.Open();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                SqlCommand cmm = new SqlCommand("Insert into [McFlyRoothy].[dbo].[urunFatura]([FaturaNo],[UrunKodu],[Miktar]) VALUES('" + dataGridView3.Rows[i].Cells[0].Value.ToString() + "','" + dataGridView3.Rows[i].Cells[1].Value.ToString() + "'," + dataGridView3.Rows[i].Cells[2].Value.ToString() + ")", cnn);
                cmm.ExecuteNonQuery();
                Application.DoEvents();
                label3.Text = dataGridView3.Rows[i].Cells[0].Value.ToString() + "---" + dataGridView3.Rows[i].Cells[1].Value.ToString();
                vProgressBar3.Value = i + 1;
            }
            MessageBox.Show("Bitti");
        }


        string musteriDosyaAdi;
        string musteriDosyaYolu;

        private void musterisil_Click(object sender, EventArgs e)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
            cnn.Open();
            SqlCommand cmm = new SqlCommand("Delete from Musteri", cnn);
            cmm.ExecuteNonQuery();
            MessageBox.Show("Müşteri Tablosu Databaseden Silindi");
            cnn.Close();
        }

        private void musteriyukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "XML Dosyası |*.xml";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Fatura XML Dosyası Seçiniz..";

            if (file.ShowDialog() == DialogResult.OK)
            {
                musteriDosyaYolu = file.FileName;
                musteriDosyaAdi = file.SafeFileName;
            }
            DataSet ds = new DataSet();
            ds.ReadXml(musteriDosyaYolu.ToString());
            DataTable dt = ds.Tables["MUSTERI"];
            dataGridView4.DataSource = dt;
            DataGridViewCellStyle renk = new DataGridViewCellStyle();
            renk.BackColor = Color.PaleGreen;
        }

        private void musteriaktar_Click(object sender, EventArgs e)
        {
            vProgressBar4.Maximum = dataGridView4.Rows.Count - 1;

            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
            cnn.Open();
            for (int i = 0; i < dataGridView4.Rows.Count - 1; i++)
            {
                SqlCommand cmm = new SqlCommand("INSERT INTO [McFlyRoothy].[dbo].[Musteri] ([kodu],[kodu2],[MerkezKodu],[adi],[il],[ilce],[adres],[tipKodu],[tipAdi],[kanalKodu],[kanalAdi],[zincir],[zincirKodu],[zincirAdi],[postaKodu],[telefon],[faks],[vergiNo],[vergiDairesi],[ilgili],[mevsimsel],[vergisiz]) VALUES('" + dataGridView4.Rows[i].Cells[0].Value.ToString() + "','" + dataGridView4.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView4.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView4.Rows[i].Cells[3].Value.ToString() + "','" + dataGridView4.Rows[i].Cells[4].Value.ToString() + "','" + dataGridView4.Rows[i].Cells[5].Value.ToString() + "','" + dataGridView4.Rows[i].Cells[6].Value.ToString() + "','" + dataGridView4.Rows[i].Cells[7].Value.ToString() + "','" + dataGridView4.Rows[i].Cells[8].Value.ToString() + "','" + dataGridView4.Rows[i].Cells[9].Value.ToString() + "','" + dataGridView4.Rows[i].Cells[10].Value.ToString() + "','" + dataGridView4.Rows[i].Cells[11].Value.ToString() + "','" + dataGridView4.Rows[i].Cells[12].Value.ToString() + "','" + dataGridView4.Rows[i].Cells[13].Value.ToString() + "','" + dataGridView4.Rows[i].Cells[14].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[15].Value.ToString() + "','" + dataGridView4.Rows[i].Cells[16].Value.ToString() + "','" + dataGridView4.Rows[i].Cells[17].Value.ToString() + "','" + dataGridView4.Rows[i].Cells[18].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[19].Value.ToString() + "','" + dataGridView4.Rows[i].Cells[20].Value.ToString() + "','" + dataGridView4.Rows[i].Cells[21].Value.ToString() + "' )", cnn);
                cmm.ExecuteNonQuery();
                Application.DoEvents();
                label4.Text = dataGridView4.Rows[i].Cells[3].Value.ToString();
                vProgressBar4.Value = i + 1;
            }
            MessageBox.Show("Bitti");
            cnn.Close();
        }

        private void iskontosil_Click(object sender, EventArgs e)
        {

        }

        private void iskontoyukle_Click(object sender, EventArgs e)
        {

        }

        private void iskontoaktar_Click(object sender, EventArgs e)
        {

        }
    }
}
