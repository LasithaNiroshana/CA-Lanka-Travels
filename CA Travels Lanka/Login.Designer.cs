namespace CA_Travels_Lanka
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userLabel = new System.Windows.Forms.Label();
            this.pwLabel = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.pwTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(544, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 40);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(200)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 70);
            this.panel1.TabIndex = 1;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(74, 164);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(146, 35);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Username :";
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwLabel.Location = new System.Drawing.Point(74, 260);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(137, 35);
            this.pwLabel.TabIndex = 3;
            this.pwLabel.Text = "Password :";
            // 
            // userTxt
            // 
            this.userTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxt.Location = new System.Drawing.Point(242, 169);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(282, 30);
            this.userTxt.TabIndex = 4;
            // 
            // pwTxt
            // 
            this.pwTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwTxt.Location = new System.Drawing.Point(242, 265);
            this.pwTxt.Name = "pwTxt";
            this.pwTxt.PasswordChar = '*';
            this.pwTxt.Size = new System.Drawing.Size(282, 30);
            this.pwTxt.TabIndex = 5;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(242, 359);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(120, 40);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 440);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pwTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.pwLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox pwTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label1;
    }
}

