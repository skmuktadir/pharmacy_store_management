namespace PharmacyStoreMangement
{
    partial class Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            this.pnlPgMember = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenubar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.BtnDrugInfo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnInvoices = new Guna.UI.WinForms.GunaAdvenceButton();
            this.imgSlide = new System.Windows.Forms.PictureBox();
            this.gunaAnimateWindow1 = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenubar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPgMember
            // 
            this.pnlPgMember.BackColor = System.Drawing.Color.Lavender;
            this.pnlPgMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPgMember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlPgMember.Location = new System.Drawing.Point(180, 0);
            this.pnlPgMember.Name = "pnlPgMember";
            this.pnlPgMember.Padding = new System.Windows.Forms.Padding(0, 6, 6, 6);
            this.pnlPgMember.Size = new System.Drawing.Size(1341, 732);
            this.pnlPgMember.TabIndex = 5;
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
            this.panelMenubar.Controls.Add(this.BtnDrugInfo);
            this.panelMenubar.Controls.Add(this.label1);
            this.panelMenubar.Controls.Add(this.pictureBox1);
            this.panelMenubar.Controls.Add(this.BtnInvoices);
            this.panelMenubar.Controls.Add(this.imgSlide);
            this.panelMenubar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenubar.Location = new System.Drawing.Point(0, 0);
            this.panelMenubar.Name = "panelMenubar";
            this.panelMenubar.Size = new System.Drawing.Size(180, 732);
            this.panelMenubar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 694);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Log Out";
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.Image")));
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaImageButton2.Location = new System.Drawing.Point(26, 657);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = null;
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton2.Size = new System.Drawing.Size(58, 42);
            this.gunaImageButton2.TabIndex = 9;
            this.gunaImageButton2.Click += new System.EventHandler(this.gunaImageButton2_Click);
            // 
            // BtnDrugInfo
            // 
            this.BtnDrugInfo.AnimationHoverSpeed = 0.07F;
            this.BtnDrugInfo.AnimationSpeed = 0.03F;
            this.BtnDrugInfo.BackColor = System.Drawing.Color.Transparent;
            this.BtnDrugInfo.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDrugInfo.BorderColor = System.Drawing.Color.Black;
            this.BtnDrugInfo.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.BtnDrugInfo.CheckedBaseColor = System.Drawing.Color.Lavender;
            this.BtnDrugInfo.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnDrugInfo.CheckedForeColor = System.Drawing.Color.Teal;
            this.BtnDrugInfo.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnDrugInfo.CheckedImage")));
            this.BtnDrugInfo.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnDrugInfo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnDrugInfo.FocusedColor = System.Drawing.Color.Empty;
            this.BtnDrugInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDrugInfo.ForeColor = System.Drawing.Color.White;
            this.BtnDrugInfo.Image = ((System.Drawing.Image)(resources.GetObject("BtnDrugInfo.Image")));
            this.BtnDrugInfo.ImageOffsetX = 10;
            this.BtnDrugInfo.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnDrugInfo.LineColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDrugInfo.Location = new System.Drawing.Point(12, 258);
            this.BtnDrugInfo.Name = "BtnDrugInfo";
            this.BtnDrugInfo.OnHoverBaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDrugInfo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDrugInfo.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnDrugInfo.OnHoverImage = null;
            this.BtnDrugInfo.OnHoverLineColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDrugInfo.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDrugInfo.Radius = 22;
            this.BtnDrugInfo.Size = new System.Drawing.Size(163, 46);
            this.BtnDrugInfo.TabIndex = 3;
            this.BtnDrugInfo.Text = "   Drug Info";
            this.BtnDrugInfo.UseTransfarantBackground = true;
            this.BtnDrugInfo.CheckedChanged += new System.EventHandler(this.gunaAdvenceButton2_CheckedChanged);
            this.BtnDrugInfo.Click += new System.EventHandler(this.BtnDrugInfo_Click);
            // 
            // BtnInvoices
            // 
            this.BtnInvoices.AnimationHoverSpeed = 0.07F;
            this.BtnInvoices.AnimationSpeed = 0.03F;
            this.BtnInvoices.BackColor = System.Drawing.Color.Transparent;
            this.BtnInvoices.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnInvoices.BorderColor = System.Drawing.Color.Black;
            this.BtnInvoices.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.BtnInvoices.Checked = true;
            this.BtnInvoices.CheckedBaseColor = System.Drawing.Color.Lavender;
            this.BtnInvoices.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnInvoices.CheckedForeColor = System.Drawing.Color.Teal;
            this.BtnInvoices.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnInvoices.CheckedImage")));
            this.BtnInvoices.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnInvoices.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnInvoices.FocusedColor = System.Drawing.Color.Empty;
            this.BtnInvoices.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnInvoices.ForeColor = System.Drawing.Color.White;
            this.BtnInvoices.Image = ((System.Drawing.Image)(resources.GetObject("BtnInvoices.Image")));
            this.BtnInvoices.ImageOffsetX = 10;
            this.BtnInvoices.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnInvoices.LineColor = System.Drawing.Color.Silver;
            this.BtnInvoices.Location = new System.Drawing.Point(12, 180);
            this.BtnInvoices.Name = "BtnInvoices";
            this.BtnInvoices.OnHoverBaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnInvoices.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnInvoices.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnInvoices.OnHoverImage = null;
            this.BtnInvoices.OnHoverLineColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnInvoices.OnPressedColor = System.Drawing.Color.Black;
            this.BtnInvoices.Radius = 22;
            this.BtnInvoices.Size = new System.Drawing.Size(163, 46);
            this.BtnInvoices.TabIndex = 2;
            this.BtnInvoices.Text = "   Invoices";
            this.BtnInvoices.UseTransfarantBackground = true;
            this.BtnInvoices.CheckedChanged += new System.EventHandler(this.gunaAdvenceButton2_CheckedChanged);
            this.BtnInvoices.Click += new System.EventHandler(this.BtnInvoices_Click);
            // 
            // imgSlide
            // 
            this.imgSlide.Image = ((System.Drawing.Image)(resources.GetObject("imgSlide.Image")));
            this.imgSlide.Location = new System.Drawing.Point(108, 135);
            this.imgSlide.Name = "imgSlide";
            this.imgSlide.Size = new System.Drawing.Size(72, 142);
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
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 732);
            this.Controls.Add(this.pnlPgMember);
            this.Controls.Add(this.panelMenubar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenubar.ResumeLayout(false);
            this.panelMenubar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPgMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenubar;
        private Guna.UI.WinForms.GunaAdvenceButton BtnDrugInfo;
        private Guna.UI.WinForms.GunaAdvenceButton BtnInvoices;
        private System.Windows.Forms.PictureBox imgSlide;
        private Guna.UI.WinForms.GunaAnimateWindow gunaAnimateWindow1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
    }
}