using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ROOTHY
{
    public partial class hesapkapama : Form
    {
        public hesapkapama()
        {
            InitializeComponent();
        }
        veri v = new veri();
        SqlConnection cnn = new SqlConnection("Server=94.73.170.5;Database=db7FC3D727C3;User=user7FC3D727C3;Password=RootHy.11;");
        private void hesapkapama_Load(object sender, EventArgs e)
        {
            v.FillCombo(vComboBox1, "Select sevkNo from fatura group by sevkno", "SevkNo", "SevkNo");
        }
        private void Doldur()
        {

            SqlCommand Cmm = new SqlCommand("Select SUM(odemetutari1 + odemeTutari2) from fatura where sevkNo = '" + vComboBox1.SelectedValue.ToString() + "' and(odemetipi1 = 1 or odemeTipi2 = 1) union all Select SUM(odemetutari1 + odemeTutari2) from fatura where sevkNo = '" + vComboBox1.SelectedValue.ToString() + "' and(odemetipi1 = 2 or odemeTipi2 = 2) union all Select SUM(odemetutari1 + odemeTutari2) from fatura where sevkNo = '" + vComboBox1.SelectedValue.ToString() + "' and(odemetipi1 = 3 or odemeTipi2 = 3) union all Select SUM(odemetutari1 + odemeTutari2) from fatura where sevkNo = '" + vComboBox1.SelectedValue.ToString() + "' and(odemetipi1 = 4 or odemeTipi2 = 4) union all Select SUM(odemetutari1 + odemeTutari2) from fatura where sevkNo = '" + vComboBox1.SelectedValue.ToString() + "' and(odemetipi1 = 7 or odemeTipi2 = 7) ", cnn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(Cmm);
            da.Fill(dt);
            txtNakit.Text = dt.Rows[0][0].ToString();
            txtKredi.Text = dt.Rows[1][0].ToString();
            txtAcikHes.Text = dt.Rows[2][0].ToString();
            txtSenet.Text = dt.Rows[3][0].ToString();
            txtIptal.Text = dt.Rows[4][0].ToString();

            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
            cnn.Open();
            SqlCommand cmm1 = new SqlCommand(" SELECT (sum(cast(Miktar as int))*-1) as 'MIKTAR'  FROM urunFatura INNER JOIN Fatura ON urunFatura.FaturaNo = Fatura.fisNo INNER JOIN Urun ON urunFatura.UrunKodu = Urun.kodu where(kodu = '253' or kodu = '169'or kodu = '198'or kodu = '201'or kodu = '207'or kodu = '22'or kodu = '251'or kodu = '253'or kodu = '255'or kodu = '26' or kodu = '400' or kodu = '405' or kodu = '408' or kodu = '461' or kodu = '463' or kodu = '465' or kodu = '34' or kodu = '33' ) and miktar < 0 and sevkNo = '" + vComboBox1.SelectedValue.ToString() + "' group by sevkNo union all SELECT  (sum(cast(Miktar as int))*-1) as 'MIKTAR' FROM urunFatura INNER JOIN Fatura ON urunFatura.FaturaNo = Fatura.fisNo INNER JOIN Urun ON urunFatura.UrunKodu = Urun.kodu where  kodu = '161' and miktar < 0 and sevkNo = '" + vComboBox1.SelectedValue.ToString() + "' group by sevkNo", cnn);
            DataTable dta = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter(cmm1);
            daa.Fill(dta);
            if (dta.Rows.Count < 1)
            {
                txtGidenPre.Text = "0";
                txtGidenKasa.Text = "0";
            }
            else if (dta.Rows.Count < 2)
            {
                txtGidenPre.Text = "0";
                txtGidenKasa.Text = dta.Rows[0][0].ToString();
            }
            else
            {
                txtGidenKasa.Text = dta.Rows[0][0].ToString();
                txtGidenPre.Text = dta.Rows[1][0].ToString();
            }
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
            cnn.Open();
            SqlCommand cmm2 = new SqlCommand("select * from Iadeler where sevkNo = '" + vComboBox1.SelectedValue.ToString() + "'", cnn);
            DataTable dta2 = new DataTable();
            SqlDataAdapter daa2 = new SqlDataAdapter(cmm2);
            daa2.Fill(dta2);
            if (dta2.Rows.Count < 1)
            {
                txtGelenCibil.Text = "0";
                txtGelenSise.Text = "0";
                txtGelenPre.Text = "0";
                txtGelenKasa.Text = "0";
            }
            else
            {
                txtGelenCibil.Text = dta2.Rows[0][2].ToString();
                txtGelenSise.Text = dta2.Rows[0][3].ToString();
                txtGelenPre.Text = dta2.Rows[0][5].ToString();
                txtGelenKasa.Text = dta2.Rows[0][4].ToString();
            }

        }
        private void HesapYap()
        {
            foreach (var item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    if (tbox.Text == "")
                    {
                        tbox.Text = "0";
                    }
                }
            }
            foreach (var item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    if (tbox.Text == "")
                    {
                        tbox.Text = "0";
                    }
                }
            }
            foreach (var item in groupBox3.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    if (tbox.Text == "")
                    {
                        tbox.Text = "0";
                    }
                }
            }

            int gidenkasa = Convert.ToInt32(txtGidenKasa.Text);
            int gelenkasa = Convert.ToInt32(txtGelenKasa.Text);
            int cibil = Convert.ToInt32(txtGelenCibil.Text);
            int sise = Convert.ToInt32(txtGelenSise.Text);
            int kasafarki = gidenkasa - gelenkasa;

            int gelenpre = Convert.ToInt32(txtGelenPre.Text);
            int gidenpre = Convert.ToInt32(txtGidenPre.Text);
            int prefark = gidenpre - gelenpre;
            if (kasafarki != 0 || prefark != 0)
            {
                txtIade.Text = ((kasafarki * 15) - (cibil * 6.60) - (sise * 0.35) - (prefark * 25)).ToString();
            }
            txtNakTop.Text = txtNakit.Text;
            txtGenTop.Text = (Convert.ToDecimal(txtNakTop.Text) + Convert.ToDecimal(txtIade.Text)).ToString();
        }

        private void vButton1_Click(object sender, EventArgs e)
        {
            Doldur();
            HesapYap();
        }

        private void vComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
