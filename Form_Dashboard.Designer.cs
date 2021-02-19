namespace Bayar.exe
{
    partial class Form_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnofficer = new Guna.UI.WinForms.GunaButton();
            this.labelofficer = new Guna.UI.WinForms.GunaLabel();
            this.btnpay = new Guna.UI.WinForms.GunaButton();
            this.btnpayments = new Guna.UI.WinForms.GunaButton();
            this.labelpay = new Guna.UI.WinForms.GunaLabel();
            this.labelstudents = new Guna.UI.WinForms.GunaLabel();
            this.labeldashboard = new Guna.UI.WinForms.GunaLabel();
            this.btnstudents = new Guna.UI.WinForms.GunaButton();
            this.btnclass = new Guna.UI.WinForms.GunaButton();
            this.btndashboard = new Guna.UI.WinForms.GunaButton();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(37, 18);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(116, 34);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Bayarin";
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.White;
            this.gunaLinePanel1.Controls.Add(this.btnofficer);
            this.gunaLinePanel1.Controls.Add(this.labelofficer);
            this.gunaLinePanel1.Controls.Add(this.btnpay);
            this.gunaLinePanel1.Controls.Add(this.btnpayments);
            this.gunaLinePanel1.Controls.Add(this.labelpay);
            this.gunaLinePanel1.Controls.Add(this.labelstudents);
            this.gunaLinePanel1.Controls.Add(this.labeldashboard);
            this.gunaLinePanel1.Controls.Add(this.btnstudents);
            this.gunaLinePanel1.Controls.Add(this.btnclass);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel1);
            this.gunaLinePanel1.Controls.Add(this.btndashboard);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(200, 673);
            this.gunaLinePanel1.TabIndex = 2;
            // 
            // btnofficer
            // 
            this.btnofficer.AnimationHoverSpeed = 0.07F;
            this.btnofficer.AnimationSpeed = 0.03F;
            this.btnofficer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnofficer.BorderColor = System.Drawing.Color.Black;
            this.btnofficer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnofficer.FocusedColor = System.Drawing.Color.Empty;
            this.btnofficer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnofficer.ForeColor = System.Drawing.Color.White;
            this.btnofficer.Image = ((System.Drawing.Image)(resources.GetObject("btnofficer.Image")));
            this.btnofficer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnofficer.Location = new System.Drawing.Point(16, 550);
            this.btnofficer.Name = "btnofficer";
            this.btnofficer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnofficer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnofficer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnofficer.OnHoverImage = null;
            this.btnofficer.OnPressedColor = System.Drawing.Color.Black;
            this.btnofficer.Size = new System.Drawing.Size(160, 42);
            this.btnofficer.TabIndex = 5;
            this.btnofficer.Text = "Petugas";
            this.btnofficer.Click += new System.EventHandler(this.btnofficer_Click);
            // 
            // labelofficer
            // 
            this.labelofficer.AutoSize = true;
            this.labelofficer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelofficer.Location = new System.Drawing.Point(12, 527);
            this.labelofficer.Name = "labelofficer";
            this.labelofficer.Size = new System.Drawing.Size(68, 20);
            this.labelofficer.TabIndex = 8;
            this.labelofficer.Text = "Pengurus";
            // 
            // btnpay
            // 
            this.btnpay.AnimationHoverSpeed = 0.07F;
            this.btnpay.AnimationSpeed = 0.03F;
            this.btnpay.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnpay.BorderColor = System.Drawing.Color.Black;
            this.btnpay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnpay.FocusedColor = System.Drawing.Color.Empty;
            this.btnpay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnpay.ForeColor = System.Drawing.Color.White;
            this.btnpay.Image = ((System.Drawing.Image)(resources.GetObject("btnpay.Image")));
            this.btnpay.ImageSize = new System.Drawing.Size(20, 20);
            this.btnpay.Location = new System.Drawing.Point(16, 411);
            this.btnpay.Name = "btnpay";
            this.btnpay.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnpay.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnpay.OnHoverForeColor = System.Drawing.Color.White;
            this.btnpay.OnHoverImage = null;
            this.btnpay.OnPressedColor = System.Drawing.Color.Black;
            this.btnpay.Size = new System.Drawing.Size(160, 42);
            this.btnpay.TabIndex = 3;
            this.btnpay.Text = "Bayar";
            // 
            // btnpayments
            // 
            this.btnpayments.AnimationHoverSpeed = 0.07F;
            this.btnpayments.AnimationSpeed = 0.03F;
            this.btnpayments.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnpayments.BorderColor = System.Drawing.Color.Black;
            this.btnpayments.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnpayments.FocusedColor = System.Drawing.Color.Empty;
            this.btnpayments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnpayments.ForeColor = System.Drawing.Color.White;
            this.btnpayments.Image = ((System.Drawing.Image)(resources.GetObject("btnpayments.Image")));
            this.btnpayments.ImageSize = new System.Drawing.Size(20, 20);
            this.btnpayments.Location = new System.Drawing.Point(16, 459);
            this.btnpayments.Name = "btnpayments";
            this.btnpayments.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnpayments.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnpayments.OnHoverForeColor = System.Drawing.Color.White;
            this.btnpayments.OnHoverImage = null;
            this.btnpayments.OnPressedColor = System.Drawing.Color.Black;
            this.btnpayments.Size = new System.Drawing.Size(160, 42);
            this.btnpayments.TabIndex = 4;
            this.btnpayments.Text = "Tagihan";
            // 
            // labelpay
            // 
            this.labelpay.AutoSize = true;
            this.labelpay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelpay.Location = new System.Drawing.Point(12, 388);
            this.labelpay.Name = "labelpay";
            this.labelpay.Size = new System.Drawing.Size(90, 20);
            this.labelpay.TabIndex = 7;
            this.labelpay.Text = "Pembayaran";
            // 
            // labelstudents
            // 
            this.labelstudents.AutoSize = true;
            this.labelstudents.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelstudents.Location = new System.Drawing.Point(12, 249);
            this.labelstudents.Name = "labelstudents";
            this.labelstudents.Size = new System.Drawing.Size(97, 20);
            this.labelstudents.TabIndex = 6;
            this.labelstudents.Text = "Data Sekolah";
            // 
            // labeldashboard
            // 
            this.labeldashboard.AutoSize = true;
            this.labeldashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labeldashboard.Location = new System.Drawing.Point(12, 158);
            this.labeldashboard.Name = "labeldashboard";
            this.labeldashboard.Size = new System.Drawing.Size(82, 20);
            this.labeldashboard.TabIndex = 0;
            this.labeldashboard.Text = "Dashboard";
            // 
            // btnstudents
            // 
            this.btnstudents.AnimationHoverSpeed = 0.07F;
            this.btnstudents.AnimationSpeed = 0.03F;
            this.btnstudents.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnstudents.BorderColor = System.Drawing.Color.Black;
            this.btnstudents.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnstudents.FocusedColor = System.Drawing.Color.Empty;
            this.btnstudents.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnstudents.ForeColor = System.Drawing.Color.White;
            this.btnstudents.Image = ((System.Drawing.Image)(resources.GetObject("btnstudents.Image")));
            this.btnstudents.ImageSize = new System.Drawing.Size(20, 20);
            this.btnstudents.Location = new System.Drawing.Point(16, 272);
            this.btnstudents.Name = "btnstudents";
            this.btnstudents.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnstudents.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnstudents.OnHoverForeColor = System.Drawing.Color.White;
            this.btnstudents.OnHoverImage = null;
            this.btnstudents.OnPressedColor = System.Drawing.Color.Black;
            this.btnstudents.Size = new System.Drawing.Size(160, 42);
            this.btnstudents.TabIndex = 1;
            this.btnstudents.Text = "Siswa";
            // 
            // btnclass
            // 
            this.btnclass.AnimationHoverSpeed = 0.07F;
            this.btnclass.AnimationSpeed = 0.03F;
            this.btnclass.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnclass.BorderColor = System.Drawing.Color.Black;
            this.btnclass.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnclass.FocusedColor = System.Drawing.Color.Empty;
            this.btnclass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnclass.ForeColor = System.Drawing.Color.White;
            this.btnclass.Image = ((System.Drawing.Image)(resources.GetObject("btnclass.Image")));
            this.btnclass.ImageSize = new System.Drawing.Size(20, 20);
            this.btnclass.Location = new System.Drawing.Point(16, 320);
            this.btnclass.Name = "btnclass";
            this.btnclass.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnclass.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnclass.OnHoverForeColor = System.Drawing.Color.White;
            this.btnclass.OnHoverImage = null;
            this.btnclass.OnPressedColor = System.Drawing.Color.Black;
            this.btnclass.Size = new System.Drawing.Size(160, 42);
            this.btnclass.TabIndex = 2;
            this.btnclass.Text = "Kelas";
            // 
            // btndashboard
            // 
            this.btndashboard.AnimationHoverSpeed = 0.07F;
            this.btndashboard.AnimationSpeed = 0.03F;
            this.btndashboard.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btndashboard.BorderColor = System.Drawing.Color.Black;
            this.btndashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btndashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btndashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.Image = ((System.Drawing.Image)(resources.GetObject("btndashboard.Image")));
            this.btndashboard.ImageSize = new System.Drawing.Size(20, 20);
            this.btndashboard.Location = new System.Drawing.Point(16, 181);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btndashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btndashboard.OnHoverForeColor = System.Drawing.Color.White;
            this.btndashboard.OnHoverImage = null;
            this.btndashboard.OnPressedColor = System.Drawing.Color.Black;
            this.btndashboard.Size = new System.Drawing.Size(160, 42);
            this.btndashboard.TabIndex = 0;
            this.btndashboard.Text = "Dashboard";
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(119)))), ((int)(((byte)(239)))));
            this.gunaLinePanel2.Controls.Add(this.gunaLabel3);
            this.gunaLinePanel2.Controls.Add(this.gunaLabel2);
            this.gunaLinePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(200, 0);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(1062, 80);
            this.gunaLinePanel2.TabIndex = 3;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(188, 18);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(105, 34);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Admin";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(93, 18);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(89, 34);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Role :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 593);
            this.panel1.TabIndex = 4;
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaLinePanel2);
            this.Controls.Add(this.gunaLinePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.Form_Dashboard_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel labeldashboard;
        private Guna.UI.WinForms.GunaButton btnofficer;
        private Guna.UI.WinForms.GunaButton btnpayments;
        private Guna.UI.WinForms.GunaButton btndashboard;
        private Guna.UI.WinForms.GunaButton btnpay;
        private Guna.UI.WinForms.GunaButton btnstudents;
        private Guna.UI.WinForms.GunaButton btnclass;
        private Guna.UI.WinForms.GunaLabel labelofficer;
        private Guna.UI.WinForms.GunaLabel labelpay;
        private Guna.UI.WinForms.GunaLabel labelstudents;
    }
}