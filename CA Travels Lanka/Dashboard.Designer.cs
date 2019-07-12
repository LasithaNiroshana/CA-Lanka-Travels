namespace CA_Travels_Lanka
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.paymentBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.vehiclesBtn = new System.Windows.Forms.Button();
            this.packagesBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.reservationBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profileBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timeLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.titleLbl = new System.Windows.Forms.Label();
            this.homeUC1 = new CA_Travels_Lanka.homeUC();
            this.packagesUC1 = new CA_Travels_Lanka.packagesUC();
            this.reservationUC1 = new CA_Travels_Lanka.reservationUC();
            this.customerUC1 = new CA_Travels_Lanka.customerUC();
            this.vehiclesUC1 = new CA_Travels_Lanka.vehiclesUC();
            this.paymentUC1 = new CA_Travels_Lanka.paymentUC();
            this.sidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.sidePanel.Controls.Add(this.dateLbl);
            this.sidePanel.Controls.Add(this.timeLbl);
            this.sidePanel.Controls.Add(this.paymentBtn);
            this.sidePanel.Controls.Add(this.homeBtn);
            this.sidePanel.Controls.Add(this.vehiclesBtn);
            this.sidePanel.Controls.Add(this.packagesBtn);
            this.sidePanel.Controls.Add(this.customerBtn);
            this.sidePanel.Controls.Add(this.reservationBtn);
            this.sidePanel.Location = new System.Drawing.Point(0, 78);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(240, 562);
            this.sidePanel.TabIndex = 0;
            // 
            // paymentBtn
            // 
            this.paymentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.paymentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.paymentBtn.FlatAppearance.BorderSize = 0;
            this.paymentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.paymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentBtn.ForeColor = System.Drawing.Color.White;
            this.paymentBtn.Image = ((System.Drawing.Image)(resources.GetObject("paymentBtn.Image")));
            this.paymentBtn.Location = new System.Drawing.Point(0, 321);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Size = new System.Drawing.Size(240, 60);
            this.paymentBtn.TabIndex = 7;
            this.paymentBtn.Text = " Payment";
            this.paymentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.paymentBtn.UseVisualStyleBackColor = false;
            this.paymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.Location = new System.Drawing.Point(0, 0);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(240, 60);
            this.homeBtn.TabIndex = 2;
            this.homeBtn.Text = " Home";
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // vehiclesBtn
            // 
            this.vehiclesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.vehiclesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vehiclesBtn.FlatAppearance.BorderSize = 0;
            this.vehiclesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.vehiclesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehiclesBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiclesBtn.ForeColor = System.Drawing.Color.White;
            this.vehiclesBtn.Image = ((System.Drawing.Image)(resources.GetObject("vehiclesBtn.Image")));
            this.vehiclesBtn.Location = new System.Drawing.Point(0, 255);
            this.vehiclesBtn.Name = "vehiclesBtn";
            this.vehiclesBtn.Size = new System.Drawing.Size(240, 60);
            this.vehiclesBtn.TabIndex = 6;
            this.vehiclesBtn.Text = " Vehicles";
            this.vehiclesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vehiclesBtn.UseVisualStyleBackColor = false;
            this.vehiclesBtn.Click += new System.EventHandler(this.VehiclesBtn_Click);
            // 
            // packagesBtn
            // 
            this.packagesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.packagesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.packagesBtn.FlatAppearance.BorderSize = 0;
            this.packagesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.packagesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.packagesBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packagesBtn.ForeColor = System.Drawing.Color.White;
            this.packagesBtn.Image = ((System.Drawing.Image)(resources.GetObject("packagesBtn.Image")));
            this.packagesBtn.Location = new System.Drawing.Point(0, 66);
            this.packagesBtn.Name = "packagesBtn";
            this.packagesBtn.Size = new System.Drawing.Size(240, 60);
            this.packagesBtn.TabIndex = 3;
            this.packagesBtn.Text = " Packages";
            this.packagesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.packagesBtn.UseVisualStyleBackColor = false;
            this.packagesBtn.Click += new System.EventHandler(this.PackagesBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.customerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.customerBtn.FlatAppearance.BorderSize = 0;
            this.customerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.customerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBtn.ForeColor = System.Drawing.Color.White;
            this.customerBtn.Image = ((System.Drawing.Image)(resources.GetObject("customerBtn.Image")));
            this.customerBtn.Location = new System.Drawing.Point(-1, 198);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(240, 60);
            this.customerBtn.TabIndex = 5;
            this.customerBtn.Text = " Customer";
            this.customerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customerBtn.UseVisualStyleBackColor = false;
            this.customerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // reservationBtn
            // 
            this.reservationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.reservationBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reservationBtn.FlatAppearance.BorderSize = 0;
            this.reservationBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.reservationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationBtn.ForeColor = System.Drawing.Color.White;
            this.reservationBtn.Image = ((System.Drawing.Image)(resources.GetObject("reservationBtn.Image")));
            this.reservationBtn.Location = new System.Drawing.Point(0, 132);
            this.reservationBtn.Name = "reservationBtn";
            this.reservationBtn.Size = new System.Drawing.Size(240, 60);
            this.reservationBtn.TabIndex = 4;
            this.reservationBtn.Text = " Reservation";
            this.reservationBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reservationBtn.UseVisualStyleBackColor = false;
            this.reservationBtn.Click += new System.EventHandler(this.ReservationBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(200)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.profileBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 80);
            this.panel1.TabIndex = 1;
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Image = ((System.Drawing.Image)(resources.GetObject("profileBtn.Image")));
            this.profileBtn.Location = new System.Drawing.Point(1102, 12);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(40, 40);
            this.profileBtn.TabIndex = 2;
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.ProfileBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(1148, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 40);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(200)))), ((int)(((byte)(233)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(101, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // timeLbl
            // 
            this.timeLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.timeLbl.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.White;
            this.timeLbl.Location = new System.Drawing.Point(0, 411);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(240, 50);
            this.timeLbl.TabIndex = 2;
            this.timeLbl.Text = "00:00:00";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeLbl.Click += new System.EventHandler(this.TimeLbl_Click);
            // 
            // dateLbl
            // 
            this.dateLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.dateLbl.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.ForeColor = System.Drawing.Color.White;
            this.dateLbl.Location = new System.Drawing.Point(0, 474);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(240, 49);
            this.dateLbl.TabIndex = 3;
            this.dateLbl.Text = "12/07/2019";
            this.dateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.titleLbl.Location = new System.Drawing.Point(884, 41);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(112, 39);
            this.titleLbl.TabIndex = 4;
            this.titleLbl.Text = "Home";
            // 
            // homeUC1
            // 
            this.homeUC1.BackColor = System.Drawing.Color.White;
            this.homeUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.homeUC1.Location = new System.Drawing.Point(240, 78);
            this.homeUC1.Name = "homeUC1";
            this.homeUC1.Size = new System.Drawing.Size(960, 560);
            this.homeUC1.TabIndex = 7;
            // 
            // packagesUC1
            // 
            this.packagesUC1.BackColor = System.Drawing.Color.White;
            this.packagesUC1.Location = new System.Drawing.Point(240, 78);
            this.packagesUC1.Name = "packagesUC1";
            this.packagesUC1.Size = new System.Drawing.Size(960, 560);
            this.packagesUC1.TabIndex = 6;
            // 
            // reservationUC1
            // 
            this.reservationUC1.BackColor = System.Drawing.Color.White;
            this.reservationUC1.Location = new System.Drawing.Point(240, 78);
            this.reservationUC1.Name = "reservationUC1";
            this.reservationUC1.Size = new System.Drawing.Size(960, 560);
            this.reservationUC1.TabIndex = 5;
            // 
            // customerUC1
            // 
            this.customerUC1.BackColor = System.Drawing.Color.White;
            this.customerUC1.Location = new System.Drawing.Point(240, 80);
            this.customerUC1.Name = "customerUC1";
            this.customerUC1.Size = new System.Drawing.Size(960, 560);
            this.customerUC1.TabIndex = 4;
            // 
            // vehiclesUC1
            // 
            this.vehiclesUC1.BackColor = System.Drawing.Color.White;
            this.vehiclesUC1.Location = new System.Drawing.Point(240, 80);
            this.vehiclesUC1.Name = "vehiclesUC1";
            this.vehiclesUC1.Size = new System.Drawing.Size(960, 560);
            this.vehiclesUC1.TabIndex = 3;
            // 
            // paymentUC1
            // 
            this.paymentUC1.BackColor = System.Drawing.Color.White;
            this.paymentUC1.Location = new System.Drawing.Point(240, 80);
            this.paymentUC1.Name = "paymentUC1";
            this.paymentUC1.Size = new System.Drawing.Size(960, 560);
            this.paymentUC1.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 640);
            this.Controls.Add(this.homeUC1);
            this.Controls.Add(this.packagesUC1);
            this.Controls.Add(this.reservationUC1);
            this.Controls.Add(this.customerUC1);
            this.Controls.Add(this.vehiclesUC1);
            this.Controls.Add(this.paymentUC1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.sidePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button paymentBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button vehiclesBtn;
        private System.Windows.Forms.Button packagesBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button reservationBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Timer timer1;
        private paymentUC paymentUC1;
        private vehiclesUC vehiclesUC1;
        private customerUC customerUC1;
        private reservationUC reservationUC1;
        private packagesUC packagesUC1;
        private homeUC homeUC1;
        private System.Windows.Forms.Label titleLbl;
    }
}