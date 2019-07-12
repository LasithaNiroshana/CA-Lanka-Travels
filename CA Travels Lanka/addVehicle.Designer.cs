namespace CA_Travels_Lanka
{
    partial class addVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addVehicle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vehicleTxt = new System.Windows.Forms.TextBox();
            this.provinceCB = new System.Windows.Forms.ComboBox();
            this.typeTxt = new System.Windows.Forms.TextBox();
            this.ownerTxt = new System.Windows.Forms.TextBox();
            this.ownIdTxt = new System.Windows.Forms.TextBox();
            this.acRBtn = new System.Windows.Forms.RadioButton();
            this.nonacRBtn = new System.Windows.Forms.RadioButton();
            this.vehicleSubmitBtn = new System.Windows.Forms.Button();
            this.vehiResetBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 58);
            this.panel1.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.closeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.BackgroundImage")));
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Location = new System.Drawing.Point(404, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(34, 35);
            this.closeBtn.TabIndex = 15;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADD VEHICLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle No.     :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type                :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Owner Name  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Owner NIC     :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Condition        :";
            // 
            // vehicleTxt
            // 
            this.vehicleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleTxt.Location = new System.Drawing.Point(289, 104);
            this.vehicleTxt.Name = "vehicleTxt";
            this.vehicleTxt.Size = new System.Drawing.Size(138, 30);
            this.vehicleTxt.TabIndex = 6;
            // 
            // provinceCB
            // 
            this.provinceCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceCB.FormattingEnabled = true;
            this.provinceCB.Items.AddRange(new object[] {
            "wp",
            "up",
            "sp",
            "sb",
            "np",
            "nc",
            "nw",
            "ep",
            "cp"});
            this.provinceCB.Location = new System.Drawing.Point(235, 104);
            this.provinceCB.Name = "provinceCB";
            this.provinceCB.Size = new System.Drawing.Size(37, 33);
            this.provinceCB.TabIndex = 7;
            // 
            // typeTxt
            // 
            this.typeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTxt.Location = new System.Drawing.Point(225, 172);
            this.typeTxt.Name = "typeTxt";
            this.typeTxt.Size = new System.Drawing.Size(202, 30);
            this.typeTxt.TabIndex = 8;
            // 
            // ownerTxt
            // 
            this.ownerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerTxt.Location = new System.Drawing.Point(225, 245);
            this.ownerTxt.Multiline = true;
            this.ownerTxt.Name = "ownerTxt";
            this.ownerTxt.Size = new System.Drawing.Size(202, 77);
            this.ownerTxt.TabIndex = 9;
            // 
            // ownIdTxt
            // 
            this.ownIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownIdTxt.Location = new System.Drawing.Point(225, 349);
            this.ownIdTxt.Name = "ownIdTxt";
            this.ownIdTxt.Size = new System.Drawing.Size(202, 30);
            this.ownIdTxt.TabIndex = 10;
            // 
            // acRBtn
            // 
            this.acRBtn.AutoSize = true;
            this.acRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acRBtn.Location = new System.Drawing.Point(235, 420);
            this.acRBtn.Name = "acRBtn";
            this.acRBtn.Size = new System.Drawing.Size(53, 24);
            this.acRBtn.TabIndex = 11;
            this.acRBtn.TabStop = true;
            this.acRBtn.Text = "AC";
            this.acRBtn.UseVisualStyleBackColor = true;
            // 
            // nonacRBtn
            // 
            this.nonacRBtn.AutoSize = true;
            this.nonacRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonacRBtn.Location = new System.Drawing.Point(235, 460);
            this.nonacRBtn.Name = "nonacRBtn";
            this.nonacRBtn.Size = new System.Drawing.Size(89, 24);
            this.nonacRBtn.TabIndex = 12;
            this.nonacRBtn.TabStop = true;
            this.nonacRBtn.Text = "Non-AC";
            this.nonacRBtn.UseVisualStyleBackColor = true;
            // 
            // vehicleSubmitBtn
            // 
            this.vehicleSubmitBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.vehicleSubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vehicleSubmitBtn.FlatAppearance.BorderSize = 0;
            this.vehicleSubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicleSubmitBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleSubmitBtn.ForeColor = System.Drawing.Color.White;
            this.vehicleSubmitBtn.Location = new System.Drawing.Point(66, 521);
            this.vehicleSubmitBtn.Name = "vehicleSubmitBtn";
            this.vehicleSubmitBtn.Size = new System.Drawing.Size(100, 40);
            this.vehicleSubmitBtn.TabIndex = 13;
            this.vehicleSubmitBtn.Text = "Submit";
            this.vehicleSubmitBtn.UseVisualStyleBackColor = false;
            // 
            // vehiResetBtn
            // 
            this.vehiResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vehiResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vehiResetBtn.FlatAppearance.BorderSize = 0;
            this.vehiResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehiResetBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiResetBtn.ForeColor = System.Drawing.Color.White;
            this.vehiResetBtn.Location = new System.Drawing.Point(327, 521);
            this.vehiResetBtn.Name = "vehiResetBtn";
            this.vehiResetBtn.Size = new System.Drawing.Size(100, 40);
            this.vehiResetBtn.TabIndex = 14;
            this.vehiResetBtn.Text = "Reset";
            this.vehiResetBtn.UseVisualStyleBackColor = false;
            // 
            // addVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.vehiResetBtn);
            this.Controls.Add(this.vehicleSubmitBtn);
            this.Controls.Add(this.nonacRBtn);
            this.Controls.Add(this.acRBtn);
            this.Controls.Add(this.ownIdTxt);
            this.Controls.Add(this.ownerTxt);
            this.Controls.Add(this.typeTxt);
            this.Controls.Add(this.provinceCB);
            this.Controls.Add(this.vehicleTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addVehicle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vehicleTxt;
        private System.Windows.Forms.ComboBox provinceCB;
        private System.Windows.Forms.TextBox typeTxt;
        private System.Windows.Forms.TextBox ownerTxt;
        private System.Windows.Forms.TextBox ownIdTxt;
        private System.Windows.Forms.RadioButton acRBtn;
        private System.Windows.Forms.RadioButton nonacRBtn;
        private System.Windows.Forms.Button vehicleSubmitBtn;
        private System.Windows.Forms.Button vehiResetBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}