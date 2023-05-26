namespace PharmacyStoreMangement
{
    partial class PgMedicine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.dgvMedicineInfo = new Guna.UI.WinForms.GunaDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtSearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnMedicineDlt = new Guna.UI.WinForms.GunaGradientButton();
            this.btnMedicineAdd = new Guna.UI.WinForms.GunaGradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textUprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMedicine = new System.Windows.Forms.TextBox();
            this.Medicine_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaShadowPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.label1);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Silver;
            this.gunaShadowPanel1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1157, 80);
            this.gunaShadowPanel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Medicines";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.dgvMedicineInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 817);
            this.panel1.TabIndex = 14;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AnimationHoverSpeed = 0.07F;
            this.btnRefresh.AnimationSpeed = 0.03F;
            this.btnRefresh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.FocusedColor = System.Drawing.Color.Empty;
            this.btnRefresh.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = null;
            this.btnRefresh.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRefresh.Location = new System.Drawing.Point(877, 317);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRefresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRefresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnHoverImage = null;
            this.btnRefresh.OnPressedColor = System.Drawing.Color.Black;
            this.btnRefresh.Size = new System.Drawing.Size(167, 39);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvMedicineInfo
            // 
            this.dgvMedicineInfo.AllowUserToAddRows = false;
            this.dgvMedicineInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMedicineInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicineInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicineInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicineInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedicineInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMedicineInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicineInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicineInfo.ColumnHeadersHeight = 27;
            this.dgvMedicineInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicine_Name,
            this.Type,
            this.Unit_Price});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicineInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMedicineInfo.EnableHeadersVisualStyles = false;
            this.dgvMedicineInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicineInfo.Location = new System.Drawing.Point(123, 362);
            this.dgvMedicineInfo.Name = "dgvMedicineInfo";
            this.dgvMedicineInfo.ReadOnly = true;
            this.dgvMedicineInfo.RowHeadersVisible = false;
            this.dgvMedicineInfo.RowHeadersWidth = 51;
            this.dgvMedicineInfo.RowTemplate.Height = 24;
            this.dgvMedicineInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicineInfo.Size = new System.Drawing.Size(939, 395);
            this.dgvMedicineInfo.TabIndex = 2;
            this.dgvMedicineInfo.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvMedicineInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicineInfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMedicineInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMedicineInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMedicineInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMedicineInfo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicineInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicineInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMedicineInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMedicineInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMedicineInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMedicineInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMedicineInfo.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvMedicineInfo.ThemeStyle.ReadOnly = true;
            this.dgvMedicineInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicineInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMedicineInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMedicineInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMedicineInfo.ThemeStyle.RowsStyle.Height = 24;
            this.dgvMedicineInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicineInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMedicineInfo.DoubleClick += new System.EventHandler(this.dgvMedicineInfo_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 210);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.gunaLabel1);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.btnMedicineDlt);
            this.panel3.Controls.Add(this.btnMedicineAdd);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textUprice);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textType);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtMedicine);
            this.panel3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(123, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 180);
            this.panel3.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(440, 103);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(207, 19);
            this.gunaLabel1.TabIndex = 41;
            this.gunaLabel1.Text = "Search By Medicine Name";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearch.LineColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.Location = new System.Drawing.Point(442, 128);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(356, 30);
            this.txtSearch.TabIndex = 35;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnMedicineDlt
            // 
            this.btnMedicineDlt.Animated = true;
            this.btnMedicineDlt.AnimationHoverSpeed = 0.07F;
            this.btnMedicineDlt.AnimationSpeed = 0.03F;
            this.btnMedicineDlt.BackColor = System.Drawing.Color.Transparent;
            this.btnMedicineDlt.BaseColor1 = System.Drawing.Color.SlateGray;
            this.btnMedicineDlt.BaseColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.btnMedicineDlt.BorderColor = System.Drawing.Color.Black;
            this.btnMedicineDlt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMedicineDlt.FocusedColor = System.Drawing.Color.Empty;
            this.btnMedicineDlt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicineDlt.ForeColor = System.Drawing.Color.White;
            this.btnMedicineDlt.Image = null;
            this.btnMedicineDlt.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMedicineDlt.Location = new System.Drawing.Point(218, 136);
            this.btnMedicineDlt.Name = "btnMedicineDlt";
            this.btnMedicineDlt.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnMedicineDlt.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnMedicineDlt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMedicineDlt.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMedicineDlt.OnHoverImage = null;
            this.btnMedicineDlt.OnPressedColor = System.Drawing.Color.Black;
            this.btnMedicineDlt.Size = new System.Drawing.Size(132, 22);
            this.btnMedicineDlt.TabIndex = 34;
            this.btnMedicineDlt.Text = "DELETE";
            this.btnMedicineDlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMedicineDlt.Click += new System.EventHandler(this.btnMedicineDlt_Click);
            // 
            // btnMedicineAdd
            // 
            this.btnMedicineAdd.Animated = true;
            this.btnMedicineAdd.AnimationHoverSpeed = 0.07F;
            this.btnMedicineAdd.AnimationSpeed = 0.03F;
            this.btnMedicineAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnMedicineAdd.BaseColor1 = System.Drawing.Color.SlateGray;
            this.btnMedicineAdd.BaseColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.btnMedicineAdd.BorderColor = System.Drawing.Color.Black;
            this.btnMedicineAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMedicineAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnMedicineAdd.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicineAdd.ForeColor = System.Drawing.Color.White;
            this.btnMedicineAdd.Image = null;
            this.btnMedicineAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMedicineAdd.Location = new System.Drawing.Point(218, 86);
            this.btnMedicineAdd.Name = "btnMedicineAdd";
            this.btnMedicineAdd.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnMedicineAdd.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnMedicineAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMedicineAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMedicineAdd.OnHoverImage = null;
            this.btnMedicineAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnMedicineAdd.Size = new System.Drawing.Size(132, 22);
            this.btnMedicineAdd.TabIndex = 33;
            this.btnMedicineAdd.Text = "ADD";
            this.btnMedicineAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMedicineAdd.Click += new System.EventHandler(this.btnMedicineAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Unit Price";
            // 
            // textUprice
            // 
            this.textUprice.Location = new System.Drawing.Point(39, 151);
            this.textUprice.Margin = new System.Windows.Forms.Padding(4);
            this.textUprice.Name = "textUprice";
            this.textUprice.Size = new System.Drawing.Size(132, 25);
            this.textUprice.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Medicine Type";
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(39, 86);
            this.textType.Margin = new System.Windows.Forms.Padding(4);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(132, 25);
            this.textType.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 19);
            this.label8.TabIndex = 28;
            this.label8.Text = "Medicine Name";
            // 
            // txtMedicine
            // 
            this.txtMedicine.Location = new System.Drawing.Point(39, 34);
            this.txtMedicine.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(132, 25);
            this.txtMedicine.TabIndex = 27;
            // 
            // Medicine_Name
            // 
            this.Medicine_Name.DataPropertyName = "Medicine_Name";
            this.Medicine_Name.HeaderText = "Medicine Name";
            this.Medicine_Name.MinimumWidth = 6;
            this.Medicine_Name.Name = "Medicine_Name";
            this.Medicine_Name.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "type";
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Unit_Price
            // 
            this.Unit_Price.DataPropertyName = "Unit_Price";
            this.Unit_Price.HeaderText = "Unit Price";
            this.Unit_Price.MinimumWidth = 6;
            this.Unit_Price.Name = "Unit_Price";
            this.Unit_Price.ReadOnly = true;
            // 
            // PgMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "PgMedicine";
            this.Size = new System.Drawing.Size(1157, 817);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textUprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMedicine;
        private Guna.UI.WinForms.GunaGradientButton btnMedicineAdd;
        private Guna.UI.WinForms.GunaLineTextBox txtSearch;
        private Guna.UI.WinForms.GunaGradientButton btnMedicineDlt;
        private Guna.UI.WinForms.GunaDataGridView dgvMedicineInfo;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Price;
    }
}
