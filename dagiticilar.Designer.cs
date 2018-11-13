namespace ROOTHY
{
    partial class dagiticilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dagiticilar));
            this.vDateTimePicker1 = new VIBlend.WinForms.Controls.vDateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DAĞITICI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vButton1 = new VIBlend.WinForms.Controls.vButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // vDateTimePicker1
            // 
            this.vDateTimePicker1.BackColor = System.Drawing.Color.White;
            this.vDateTimePicker1.BorderColor = System.Drawing.Color.Black;
            this.vDateTimePicker1.Culture = new System.Globalization.CultureInfo("");
            this.vDateTimePicker1.DefaultDateTimeFormat = VIBlend.WinForms.Controls.DefaultDateTimePatterns.ShortDatePattern;
            this.vDateTimePicker1.DropDownMaximumSize = new System.Drawing.Size(1000, 1000);
            this.vDateTimePicker1.DropDownMinimumSize = new System.Drawing.Size(10, 10);
            this.vDateTimePicker1.DropDownResizeDirection = VIBlend.WinForms.Controls.SizingDirection.None;
            this.vDateTimePicker1.FormatValue = "d";
            this.vDateTimePicker1.Location = new System.Drawing.Point(30, 102);
            this.vDateTimePicker1.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.vDateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.vDateTimePicker1.Name = "vDateTimePicker1";
            this.vDateTimePicker1.ShowGrip = false;
            this.vDateTimePicker1.Size = new System.Drawing.Size(194, 23);
            this.vDateTimePicker1.TabIndex = 0;
            this.vDateTimePicker1.Text = "vDateTimePicker1";
            this.vDateTimePicker1.UseThemeBackColor = false;
            this.vDateTimePicker1.UseThemeDropDownArrowColor = true;
            this.vDateTimePicker1.Value = new System.DateTime(2016, 3, 23, 16, 22, 43, 500);
            this.vDateTimePicker1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLUE;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DAĞITICI});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(30, 166);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(613, 335);
            this.dataGridView1.TabIndex = 1;
            // 
            // DAĞITICI
            // 
            this.DAĞITICI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DAĞITICI.DataPropertyName = "aracplaka";
            this.DAĞITICI.HeaderText = "DAĞITICI ";
            this.DAĞITICI.Name = "DAĞITICI";
            this.DAĞITICI.ReadOnly = true;
            this.DAĞITICI.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // vButton1
            // 
            this.vButton1.AllowAnimations = true;
            this.vButton1.BackColor = System.Drawing.Color.Transparent;
            this.vButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vButton1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vButton1.Image = ((System.Drawing.Image)(resources.GetObject("vButton1.Image")));
            this.vButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vButton1.Location = new System.Drawing.Point(532, 102);
            this.vButton1.Name = "vButton1";
            this.vButton1.RoundedCornersMask = ((byte)(15));
            this.vButton1.Size = new System.Drawing.Size(111, 42);
            this.vButton1.TabIndex = 2;
            this.vButton1.Text = "         SEÇ";
            this.vButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vButton1.UseVisualStyleBackColor = false;
            this.vButton1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLUE;
            // 
            // dagiticilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 513);
            this.Controls.Add(this.vButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.vDateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dagiticilar";
            this.Text = "dagiticilar";
            this.Load += new System.EventHandler(this.dagiticilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VIBlend.WinForms.Controls.vDateTimePicker vDateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAĞITICI;
        private VIBlend.WinForms.Controls.vButton vButton1;
    }
}