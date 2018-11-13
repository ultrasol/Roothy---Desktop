namespace ROOTHY
{
    partial class raportahsilat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.vLabel1 = new VIBlend.WinForms.Controls.vLabel();
            this.dt_Tarih = new VIBlend.WinForms.Controls.vDatePicker();
            this.cmbYuk = new VIBlend.WinForms.Controls.vComboBox();
            this.cmbTahTur1 = new VIBlend.WinForms.Controls.vComboBox();
            this.cmbTahTur2 = new VIBlend.WinForms.Controls.vComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.vLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 55);
            this.panel1.TabIndex = 15;
            // 
            // vLabel1
            // 
            this.vLabel1.BackColor = System.Drawing.Color.Transparent;
            this.vLabel1.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.vLabel1.Ellipsis = false;
            this.vLabel1.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vLabel1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.vLabel1.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel1.Location = new System.Drawing.Point(206, 3);
            this.vLabel1.Multiline = true;
            this.vLabel1.Name = "vLabel1";
            this.vLabel1.Size = new System.Drawing.Size(316, 39);
            this.vLabel1.TabIndex = 0;
            this.vLabel1.Text = "TAHSİLAT RAPORU";
            this.vLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel1.UseMnemonics = true;
            this.vLabel1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // dt_Tarih
            // 
            this.dt_Tarih.BackColor = System.Drawing.Color.White;
            this.dt_Tarih.BorderColor = System.Drawing.Color.Black;
            this.dt_Tarih.Culture = new System.Globalization.CultureInfo("");
            this.dt_Tarih.DropDownMaximumSize = new System.Drawing.Size(1000, 1000);
            this.dt_Tarih.DropDownMinimumSize = new System.Drawing.Size(10, 10);
            this.dt_Tarih.DropDownResizeDirection = VIBlend.WinForms.Controls.SizingDirection.None;
            this.dt_Tarih.FormatValue = "";
            this.dt_Tarih.Location = new System.Drawing.Point(29, 166);
            this.dt_Tarih.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dt_Tarih.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dt_Tarih.Name = "dt_Tarih";
            this.dt_Tarih.ShowGrip = false;
            this.dt_Tarih.Size = new System.Drawing.Size(215, 23);
            this.dt_Tarih.TabIndex = 16;
            this.dt_Tarih.Text = "vDatePicker1";
            this.dt_Tarih.UseThemeBackColor = false;
            this.dt_Tarih.UseThemeDropDownArrowColor = true;
            this.dt_Tarih.Value = new System.DateTime(2016, 3, 23, 18, 27, 30, 70);
            this.dt_Tarih.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICEBLUE;
            // 
            // cmbYuk
            // 
            this.cmbYuk.BackColor = System.Drawing.Color.White;
            this.cmbYuk.DefaultText = "";
            this.cmbYuk.DisplayMember = "";
            this.cmbYuk.DropDownMaximumSize = new System.Drawing.Size(1000, 1000);
            this.cmbYuk.DropDownMinimumSize = new System.Drawing.Size(10, 10);
            this.cmbYuk.DropDownResizeDirection = VIBlend.WinForms.Controls.SizingDirection.Both;
            this.cmbYuk.DropDownWidth = 183;
            this.cmbYuk.Location = new System.Drawing.Point(260, 166);
            this.cmbYuk.Name = "cmbYuk";
            this.cmbYuk.RoundedCornersMaskListItem = ((byte)(15));
            this.cmbYuk.Size = new System.Drawing.Size(183, 23);
            this.cmbYuk.TabIndex = 17;
            this.cmbYuk.UseThemeBackColor = false;
            this.cmbYuk.UseThemeDropDownArrowColor = true;
            this.cmbYuk.ValueMember = "";
            this.cmbYuk.VIBlendScrollBarsTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICEBLUE;
            this.cmbYuk.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICEBLUE;
            // 
            // cmbTahTur1
            // 
            this.cmbTahTur1.BackColor = System.Drawing.Color.White;
            this.cmbTahTur1.DefaultText = "";
            this.cmbTahTur1.DisplayMember = "";
            this.cmbTahTur1.DropDownMaximumSize = new System.Drawing.Size(1000, 1000);
            this.cmbTahTur1.DropDownMinimumSize = new System.Drawing.Size(10, 10);
            this.cmbTahTur1.DropDownResizeDirection = VIBlend.WinForms.Controls.SizingDirection.Both;
            this.cmbTahTur1.DropDownWidth = 183;
            this.cmbTahTur1.Location = new System.Drawing.Point(449, 166);
            this.cmbTahTur1.Name = "cmbTahTur1";
            this.cmbTahTur1.RoundedCornersMaskListItem = ((byte)(15));
            this.cmbTahTur1.Size = new System.Drawing.Size(183, 23);
            this.cmbTahTur1.TabIndex = 18;
            this.cmbTahTur1.UseThemeBackColor = false;
            this.cmbTahTur1.UseThemeDropDownArrowColor = true;
            this.cmbTahTur1.ValueMember = "";
            this.cmbTahTur1.VIBlendScrollBarsTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICEBLUE;
            this.cmbTahTur1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICEBLUE;
            // 
            // cmbTahTur2
            // 
            this.cmbTahTur2.BackColor = System.Drawing.Color.White;
            this.cmbTahTur2.DefaultText = "";
            this.cmbTahTur2.DisplayMember = "";
            this.cmbTahTur2.DropDownMaximumSize = new System.Drawing.Size(1000, 1000);
            this.cmbTahTur2.DropDownMinimumSize = new System.Drawing.Size(10, 10);
            this.cmbTahTur2.DropDownResizeDirection = VIBlend.WinForms.Controls.SizingDirection.Both;
            this.cmbTahTur2.DropDownWidth = 183;
            this.cmbTahTur2.Location = new System.Drawing.Point(638, 166);
            this.cmbTahTur2.Name = "cmbTahTur2";
            this.cmbTahTur2.RoundedCornersMaskListItem = ((byte)(15));
            this.cmbTahTur2.Size = new System.Drawing.Size(183, 23);
            this.cmbTahTur2.TabIndex = 18;
            this.cmbTahTur2.UseThemeBackColor = false;
            this.cmbTahTur2.UseThemeDropDownArrowColor = true;
            this.cmbTahTur2.ValueMember = "";
            this.cmbTahTur2.VIBlendScrollBarsTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICEBLUE;
            this.cmbTahTur2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICEBLUE;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(813, 319);
            this.dataGridView1.TabIndex = 19;
            // 
            // raportahsilat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 551);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbTahTur2);
            this.Controls.Add(this.cmbTahTur1);
            this.Controls.Add(this.cmbYuk);
            this.Controls.Add(this.dt_Tarih);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "raportahsilat";
            this.Text = "raportahsilat";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private VIBlend.WinForms.Controls.vLabel vLabel1;
        private VIBlend.WinForms.Controls.vDatePicker dt_Tarih;
        private VIBlend.WinForms.Controls.vComboBox cmbYuk;
        private VIBlend.WinForms.Controls.vComboBox cmbTahTur1;
        private VIBlend.WinForms.Controls.vComboBox cmbTahTur2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}