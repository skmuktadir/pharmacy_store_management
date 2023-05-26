namespace PharmacyStoreMangement
{
    partial class FormAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenubar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.BtnTransaction = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnSalesPerson = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnMedicines = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnOverview = new Guna.UI.WinForms.GunaAdvenceButton();
            this.imgSlide = new System.Windows.Forms.PictureBox();
            this.gunaAnimateWindow1 = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenubar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.Lavender;
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlAdmin.Location = new System.Drawing.Point(180, 0);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Padding = new System.Windows.Forms.Padding(0, 6, 6, 6);
            this.pnlAdmin.Size = new System.Drawing.Size(857, 669);
            this.pnlAdmin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "TNM Ltd.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenubar
            // 
            this.panelMenubar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenubar.Controls.Add(this.label3);
            this.panelMenubar.Controls.Add(this.gunaImageButton2);
            this.panelMenubar.Controls.Add(this.BtnTransaction);
            this.panelMenubar.Controls.Add(this.BtnSalesPerson);
            this.panelMenubar.Controls.Add(this.BtnMedicines);
            this.panelMenubar.Controls.Add(this.label1);
            this.panelMenubar.Controls.Add(this.pictureBox1);
            this.panelMenubar.Controls.Add(this.BtnOverview);
            this.panelMenubar.Controls.Add(this.imgSlide);
            this.panelMenubar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenubar.Location = new System.Drawing.Point(0, 0);
            this.panelMenubar.Name = "panelMenubar";
            this.panelMenubar.Size = new System.Drawing.Size(180, 669);
            this.panelMenubar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 621);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Log Out";
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.Image")));
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaImageButton2.Location = new System.Drawing.Point(58, 584);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = null;
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton2.Size = new System.Drawing.Size(58, 42);
            this.gunaImageButton2.TabIndex = 11;
            this.gunaImageButton2.Click += new System.EventHandler(this.gunaImageButton2_Click);
            // 
            // BtnTransaction
            // 
            this.BtnTransaction.AnimationHoverSpeed = 0.07F;
            this.BtnTransaction.AnimationSpeed = 0.03F;
            this.BtnTransaction.BackColor = System.Drawing.Color.Transparent;
            this.BtnTransaction.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnTransaction.BorderColor = System.Drawing.Color.Black;
            this.BtnTransaction.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.BtnTransaction.CheckedBaseColor = System.Drawing.Color.Lavender;
            this.BtnTransaction.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnTransaction.CheckedForeColor = System.Drawing.Color.Teal;
            this.BtnTransaction.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnTransaction.CheckedImage")));
            this.BtnTransaction.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnTransaction.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnTransaction.FocusedColor = System.Drawing.Color.Empty;
            this.BtnTransaction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnTransaction.ForeColor = System.Drawing.Color.White;
            this.BtnTransaction.Image = ((System.Drawing.Image)(resources.GetObject("BtnTransaction.Image")));
            this.BtnTransaction.ImageOffsetX = 10;
            this.BtnTransaction.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnTransaction.LineColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnTransaction.Location = new System.Drawing.Point(17, 285);
            this.BtnTransaction.Name = "BtnTransaction";
            this.BtnTransaction.OnHoverBaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnTransaction.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnTransaction.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnTransaction.OnHoverImage = null;
            this.BtnTransaction.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnTransaction.OnPressedColor = System.Drawing.Color.Black;
            this.BtnTransaction.Radius = 22;
            this.BtnTransaction.Size = new System.Drawing.Size(163, 43);
            this.BtnTransaction.TabIndex = 5;
            this.BtnTransaction.Text = "   Transaction";
            this.BtnTransaction.UseTransfarantBackground = true;
            this.BtnTransaction.CheckedChanged += new System.EventHandler(this.gunaAdvenceButton1_CheckedChanged);
            this.BtnTransaction.Click += new System.EventHandler(this.BtnTransaction_Click);
            // 
            // BtnSalesPerson
            // 
            this.BtnSalesPerson.AnimationHoverSpeed = 0.07F;
            this.BtnSalesPerson.AnimationSpeed = 0.03F;
            this.BtnSalesPerson.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalesPerson.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSalesPerson.BorderColor = System.Drawing.Color.Black;
            this.BtnSalesPerson.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.BtnSalesPerson.CheckedBaseColor = System.Drawing.Color.Lavender;
            this.BtnSalesPerson.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnSalesPerson.CheckedForeColor = System.Drawing.Color.Teal;
            this.BtnSalesPerson.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnSalesPerson.CheckedImage")));
            this.BtnSalesPerson.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnSalesPerson.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSalesPerson.FocusedColor = System.Drawing.Color.Empty;
            this.BtnSalesPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSalesPerson.ForeColor = System.Drawing.Color.White;
            this.BtnSalesPerson.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalesPerson.Image")));
            this.BtnSalesPerson.ImageOffsetX = 10;
            this.BtnSalesPerson.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnSalesPerson.LineColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSalesPerson.Location = new System.Drawing.Point(17, 221);
            this.BtnSalesPerson.Name = "BtnSalesPerson";
            this.BtnSalesPerson.OnHoverBaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSalesPerson.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSalesPerson.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSalesPerson.OnHoverImage = null;
            this.BtnSalesPerson.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnSalesPerson.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSalesPerson.Radius = 22;
            this.BtnSalesPerson.Size = new System.Drawing.Size(163, 43);
            this.BtnSalesPerson.TabIndex = 4;
            this.BtnSalesPerson.Text = "   Salesperson";
            this.BtnSalesPerson.UseTransfarantBackground = true;
            this.BtnSalesPerson.CheckedChanged += new System.EventHandler(this.gunaAdvenceButton1_CheckedChanged);
            this.BtnSalesPerson.Click += new System.EventHandler(this.BtnSalesPerson_Click);
            // 
            // BtnMedicines
            // 
            this.BtnMedicines.AnimationHoverSpeed = 0.07F;
            this.BtnMedicines.AnimationSpeed = 0.03F;
            this.BtnMedicines.BackColor = System.Drawing.Color.Transparent;
            this.BtnMedicines.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMedicines.BorderColor = System.Drawing.Color.Black;
            this.BtnMedicines.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.BtnMedicines.CheckedBaseColor = System.Drawing.Color.Lavender;
            this.BtnMedicines.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnMedicines.CheckedForeColor = System.Drawing.Color.Teal;
            this.BtnMedicines.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnMedicines.CheckedImage")));
            this.BtnMedicines.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnMedicines.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnMedicines.FocusedColor = System.Drawing.Color.Empty;
            this.BtnMedicines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnMedicines.ForeColor = System.Drawing.Color.White;
            this.BtnMedicines.Image = ((System.Drawing.Image)(resources.GetObject("BtnMedicines.Image")));
            this.BtnMedicines.ImageOffsetX = 10;
            this.BtnMedicines.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnMedicines.LineColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMedicines.Location = new System.Drawing.Point(17, 157);
            this.BtnMedicines.Name = "BtnMedicines";
            this.BtnMedicines.OnHoverBaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMedicines.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnMedicines.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnMedicines.OnHoverImage = null;
            this.BtnMedicines.OnHoverLineColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMedicines.OnPressedColor = System.Drawing.Color.Black;
            this.BtnMedicines.Radius = 22;
            this.BtnMedicines.Size = new System.Drawing.Size(163, 43);
            this.BtnMedicines.TabIndex = 3;
            this.BtnMedicines.Text = "   Medicines";
            this.BtnMedicines.UseTransfarantBackground = true;
            this.BtnMedicines.CheckedChanged += new System.EventHandler(this.gunaAdvenceButton1_CheckedChanged);
            this.BtnMedicines.Click += new System.EventHandler(this.BtnMedicines_Click);
            // 
            // BtnOverview
            // 
            this.BtnOverview.AnimationHoverSpeed = 0.07F;
            this.BtnOverview.AnimationSpeed = 0.03F;
            this.BtnOverview.BackColor = System.Drawing.Color.Transparent;
            this.BtnOverview.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnOverview.BorderColor = System.Drawing.Color.Black;
            this.BtnOverview.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.BtnOverview.Checked = true;
            this.BtnOverview.CheckedBaseColor = System.Drawing.Color.Lavender;
            this.BtnOverview.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnOverview.CheckedForeColor = System.Drawing.Color.Teal;
            this.BtnOverview.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnOverview.CheckedImage")));
            this.BtnOverview.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnOverview.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnOverview.FocusedColor = System.Drawing.Color.Empty;
            this.BtnOverview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnOverview.ForeColor = System.Drawing.Color.White;
            this.BtnOverview.Image = ((System.Drawing.Image)(resources.GetObject("BtnOverview.Image")));
            this.BtnOverview.ImageOffsetX = 10;
            this.BtnOverview.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnOverview.LineColor = System.Drawing.Color.Silver;
            this.BtnOverview.Location = new System.Drawing.Point(17, 93);
            this.BtnOverview.Name = "BtnOverview";
            this.BtnOverview.OnHoverBaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnOverview.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnOverview.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnOverview.OnHoverImage = null;
            this.BtnOverview.OnHoverLineColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnOverview.OnPressedColor = System.Drawing.Color.Black;
            this.BtnOverview.Radius = 22;
            this.BtnOverview.Size = new System.Drawing.Size(163, 43);
            this.BtnOverview.TabIndex = 2;
            this.BtnOverview.Text = "   Overview";
            this.BtnOverview.UseTransfarantBackground = true;
            this.BtnOverview.CheckedChanged += new System.EventHandler(this.gunaAdvenceButton1_CheckedChanged);
            this.BtnOverview.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // imgSlide
            // 
            this.imgSlide.Image = ((System.Drawing.Image)(resources.GetObject("imgSlide.Image")));
            this.imgSlide.Location = new System.Drawing.Point(120, 68);
            this.imgSlide.Name = "imgSlide";
            this.imgSlide.Size = new System.Drawing.Size(61, 101);
            this.imgSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSlide.TabIndex = 1;
            this.imgSlide.TabStop = false;
            // 
            // gunaAnimateWindow1
            // 
            this.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
            this.gunaAnimateWindow1.Interval = 100;
            this.gunaAnimateWindow1.TargetControl = null;
            // 
            // FormAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1037, 669);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.panelMenubar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenubar.ResumeLayout(false);
            this.panelMenubar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenubar;
        private Guna.UI.WinForms.GunaAdvenceButton BtnMedicines;
        private Guna.UI.WinForms.GunaAdvenceButton BtnOverview;
        private System.Windows.Forms.PictureBox imgSlide;
        private Guna.UI.WinForms.GunaAnimateWindow gunaAnimateWindow1;
        private Guna.UI.WinForms.GunaAdvenceButton BtnTransaction;
        private Guna.UI.WinForms.GunaAdvenceButton BtnSalesPerson;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
    }
}