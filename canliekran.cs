using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace ROOTHY
{
    public partial class canliekran : Form
    {
        public canliekran()
        {
            InitializeComponent();
        }
        veri v = new veri();
        int count = 0;
        
        private void canliekran_Load(object sender, EventArgs e)
        {
            v.FillCombo(comboBox1, "Select distinct sevkNo from fatura", "SevkNo", "SevkNo");
        }
        private void CanliekranGuncel()
        {
            v.FillGrid(dataGridView1, "Select musKodu,musAdi,fisNo,ToplamNet,odemeTutari1, CASE odemeTipi1 WHEN 0 THEN 'GİDİLMEDİ' WHEN 1 THEN 'PESIN' WHEN 2 THEN 'KREDİ KARTI' WHEN 3 THEN 'AÇIK HESAP' WHEN 4 THEN 'SENET' WHEN 5 THEN 'HAVALE' WHEN 6 THEN 'ÇEK' WHEN 7 THEN 'İPTAL' END AS[ODEMETİPİ1],odemeTutari2,CASE odemeTipi2 WHEN 0 THEN 'GİRİLMEDİ' WHEN 1 THEN 'PESIN' WHEN 2 THEN 'KREDİ KARTI' WHEN 3 THEN 'AÇIK HESAP' WHEN 4 THEN 'SENET' WHEN 5 THEN 'HAVALE' WHEN 6 THEN 'ÇEK' WHEN 7 THEN 'İPTAL' END AS[ODEMETİPİ2],tahTarih From  FATURA where sevkNo='" + comboBox1.SelectedValue.ToString() + "' order by fisNo");
            double tkredi = 0.00;
            double tnakit = 0.00;
            double tacik = 0.00;
            double tsenet = 0.00;
            double tcek = 0.00;
            double tiptal = 0.00;
            double thavale = 0.00;
            double fatGenTop = 0.00;
            int kredisay = 0;
            int nakitsay = 0;
            int aciksay = 0;
            int sensay = 0;
            int ceksay = 0;
            int iptalsay = 0;
            int havsay = 0;
            int gidilmedisay = 0;
            int parcasay = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                fatGenTop += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "GİDİLMEDİ")
                {
                    gidilmedisay++;
                    renk.BackColor = Color.CadetBlue;
                }
                else
                {
                    if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "GİRİLMEDİ")
                    {
                        if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "PESIN")
                        {
                            tnakit += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                            nakitsay++;
                            renk.BackColor = Color.Chartreuse;
                        }
                        else if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "KREDİ KARTI")
                        {
                            tkredi += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                            kredisay++;
                            renk.BackColor = Color.Chocolate;
                        }
                        else if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "AÇIK HESAP")
                        {
                            tacik += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                            aciksay++;
                            renk.BackColor = Color.Coral;
                        }
                        else if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "SENET")
                        {
                            tsenet += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                            sensay++;
                            renk.BackColor = Color.CornflowerBlue;
                        }

                        if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "İPTAL")
                        {
                            tiptal += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                            iptalsay++;
                            renk.BackColor = Color.Cyan;
                        }
                    }
                    else
                    {

                        if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "PESIN")
                        {
                            tnakit += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                            renk.BackColor = Color.Chartreuse;
                        }
                        if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "İPTAL")
                        {

                            tiptal += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);

                            renk.BackColor = Color.Chocolate;

                        }

                        if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "KREDİ KARTI")
                        {
                            tkredi += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                            renk.BackColor = Color.PaleVioletRed;
                        }
                        if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "AÇIK HESAP")
                        {
                            tacik += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                            renk.BackColor = Color.Coral;
                        }
                        if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "SENET")
                        {
                            tsenet += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                            renk.BackColor = Color.CornflowerBlue;
                        }
                        if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "SENET")
                        {
                            tsenet += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);

                            renk.BackColor = Color.PaleVioletRed;
                        }
                        if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "AÇIK HESAP")
                        {
                            tacik += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                            parcasay++;
                            renk.BackColor = Color.PaleVioletRed;
                        }
                        if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "PESIN")
                        {
                            tnakit += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                            parcasay++;
                            renk.BackColor = Color.PaleVioletRed;
                        }
                        if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "KREDİ KARTI")
                        {
                            tkredi += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                            parcasay++;
                            renk.BackColor = Color.PaleVioletRed;
                        }
                    }
                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;

            }

            if (count < dataGridView1.Rows.Count - gidilmedisay - 1)
            {
                //player.Play();
            }
            count = dataGridView1.Rows.Count - gidilmedisay - 1;
            lblKredi.Text = tkredi.ToString();
            lblAcikHesap.Text = tacik.ToString();
            lblNakit.Text = tnakit.ToString();
            //lblCek.Text = tcek.ToString();
            //lblHavale.Text = thavale.ToString();
            lblIptal.Text = tiptal.ToString();
            lblSenet.Text = tsenet.ToString();
            lblAcikSay.Text = aciksay.ToString();
            //lblCekSay.Text = ceksay.ToString();
            //lblHavaleSay.Text = havsay.ToString();
            lblParcali.Text = (parcasay).ToString();
            lblIptalSay.Text = iptalsay.ToString();
            lblKrediSay.Text = kredisay.ToString();
            lblNakSay.Text = nakitsay.ToString();
            lblSensay.Text = sensay.ToString();
            lblGidilmedi.Text = gidilmedisay.ToString();
            lblToplamSay.Text = (aciksay + ceksay + havsay + iptalsay + kredisay + nakitsay + sensay + gidilmedisay + parcasay).ToString();
            lblToplam.Text = (tkredi + tacik + tnakit + tcek + thavale + tsenet).ToString();
            lblFatGenTop.Text = fatGenTop.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CanliekranGuncel();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(v.getvalueDeger);
            v.GetValue("select COUNT(*) as SAYI from Fatura where odemeTipi1 <> 0");
            int value = Convert.ToInt32(v.getvalueDeger);
            if (value > index)
            {
                CanliekranGuncel();
            }
        }
    }
}
