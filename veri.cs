using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using VIBlend.WinForms.Controls;

namespace ROOTHY
{
    class veri
    {

        public string getvalueDeger;
        public void GetValue(string sorgu)
        {
            SqlCommand cmd = new SqlCommand(sorgu, cnn);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                getvalueDeger = dr[0].ToString();
            }
            dr.Close();
            cnn.Close();
        }
        SqlConnection cnn = new SqlConnection("Server=94.73.170.5;Database=db7FC3D727C3;User=user7FC3D727C3;Password=RootHy.11;");
        public void FillCombo(vComboBox cmb, string Sorgu, string DisplayMember, string ValueMember)
        {
            SqlDataAdapter da = new SqlDataAdapter(Sorgu, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb.DataSource = dt;
            cmb.ValueMember = dt.Columns[0].ToString();
            cmb.DisplayMember = DisplayMember;
            cmb.ValueMember = ValueMember;
        }
        public void FillGrid(DataGridView dgv, string sorgu)
        {
            SqlCommand cmm = new SqlCommand(sorgu, cnn);
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            dgv.DataSource = dt;
        }
    }
}
