namespace ROOTHY
{
    partial class txtduzenle
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
            this.txtsec = new VIBlend.WinForms.Controls.vButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vButton1 = new VIBlend.WinForms.Controls.vButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtsec
            // 
            this.txtsec.AllowAnimations = true;
            this.txtsec.BackColor = System.Drawing.Color.Transparent;
            this.txtsec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtsec.Location = new System.Drawing.Point(296, 54);
            this.txtsec.Name = "txtsec";
            this.txtsec.RoundedCornersMask = ((byte)(15));
            this.txtsec.Size = new System.Drawing.Size(137, 37);
            this.txtsec.TabIndex = 0;
            this.txtsec.Text = "TXT DOSYASI SEÇ";
            this.txtsec.UseVisualStyleBackColor = false;
            this.txtsec.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICEBLUE;
            this.txtsec.Click += new System.EventHandler(this.txtsec_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(52, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SEÇİLEN DOSYA;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(52, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // vButton1
            // 
            this.vButton1.AllowAnimations = true;
            this.vButton1.BackColor = System.Drawing.Color.Transparent;
            this.vButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vButton1.Enabled = false;
            this.vButton1.Location = new System.Drawing.Point(296, 98);
            this.vButton1.Name = "vButton1";
            this.vButton1.RoundedCornersMask = ((byte)(15));
            this.vButton1.Size = new System.Drawing.Size(137, 37);
            this.vButton1.TabIndex = 1;
            this.vButton1.Text = "XML DÖNÜŞTÜR";
            this.vButton1.UseVisualStyleBackColor = false;
            this.vButton1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICEBLUE;
            this.vButton1.Click += new System.EventHandler(this.vButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(64, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TAG EKLE : ";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "deneme",
            "xml"});
            this.comboBox1.Location = new System.Drawing.Point(146, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "deneme";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(478, 177);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsec);
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.Name = "txtduzenle";
            this.Text = "txtduzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private VIBlend.WinForms.Controls.vButton txtsec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private VIBlend.WinForms.Controls.vButton vButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}