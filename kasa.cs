using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROOTHY
{
    public partial class kasa : Form
    {
        public kasa()
        {
            InitializeComponent();
        }
        veri v = new veri();

        private void kasa_Load(object sender, EventArgs e)
        {
            v.FillCombo(comboBox1, "Select sevkNo from Fatura group by SevkNo", "SevkNo", "SevkNo");
            v.FillGrid(dataGridView1, "Select * from Iadeler where sevkNo ='" + comboBox1.SelectedValue.ToString() + "'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server=94.73.170.5;Database=db7FC3D727C3;User=user7FC3D727C3;Password=RootHy.11;");
            SqlCommand cmm = new SqlCommand("INSERT INTO [McFlyRoothy].[dbo].[Iadeler]([sevkNo] ,[cibil] ,[sise] ,[kasa],[premix]) VALUES ('" + comboBox1.SelectedValue.ToString() + "'," + txtCibil.Text + "," + txtSise.Text + "," + txtKasa.Text + "," + txtPremix.Text + ")", cnn);
            cnn.Open();
            cmm.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show(comboBox1.SelectedValue.ToString() + " adlı Sevkiyata iade dönüşü Başarıyla girilmiştir.");
            v.FillGrid(dataGridView1, "Select * from Iadeler where sevkNo ='" + comboBox1.SelectedValue.ToString() + "'");
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            v.FillGrid(dataGridView1, "Select * from Iadeler where sevkNo ='" + comboBox1.SelectedValue.ToString() + "'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server=94.73.170.5;Database=db7FC3D727C3;User=user7FC3D727C3;Password=RootHy.11;");
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
            cnn.Open();
            SqlCommand cmm = new SqlCommand("Delete From Iadeler where ID =" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), cnn);
            cmm.ExecuteNonQuery();
            v.FillGrid(dataGridView1, "Select * from Iadeler where sevkNo ='" + comboBox1.SelectedValue.ToString() + "'");
        }

        private void txtPremix_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
       
        

       

        
      

        

        

       
    }
}
