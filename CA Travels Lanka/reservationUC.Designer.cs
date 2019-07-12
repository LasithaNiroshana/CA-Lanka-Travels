namespace CA_Travels_Lanka
{
    partial class reservationUC
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resSearchBtn = new System.Windows.Forms.Button();
            this.resAddBtn = new System.Windows.Forms.Button();
            this.resEditBtn = new System.Windows.Forms.Button();
            this.resDltBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(20, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(922, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Reservation ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Customer ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Package";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Vehicle No.";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Status(Ongoing/Pending)";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Starting Date";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ending Date";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(607, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 30);
            this.textBox1.TabIndex = 1;
            // 
            // resSearchBtn
            // 
            this.resSearchBtn.BackColor = System.Drawing.Color.Blue;
            this.resSearchBtn.FlatAppearance.BorderSize = 0;
            this.resSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resSearchBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resSearchBtn.ForeColor = System.Drawing.Color.White;
            this.resSearchBtn.Location = new System.Drawing.Point(792, 45);
            this.resSearchBtn.Name = "resSearchBtn";
            this.resSearchBtn.Size = new System.Drawing.Size(100, 40);
            this.resSearchBtn.TabIndex = 2;
            this.resSearchBtn.Text = "Search";
            this.resSearchBtn.UseVisualStyleBackColor = false;
            // 
            // resAddBtn
            // 
            this.resAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.resAddBtn.FlatAppearance.BorderSize = 0;
            this.resAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resAddBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resAddBtn.ForeColor = System.Drawing.Color.White;
            this.resAddBtn.Location = new System.Drawing.Point(198, 496);
            this.resAddBtn.Name = "resAddBtn";
            this.resAddBtn.Size = new System.Drawing.Size(100, 40);
            this.resAddBtn.TabIndex = 3;
            this.resAddBtn.Text = "ADD";
            this.resAddBtn.UseVisualStyleBackColor = false;
            this.resAddBtn.Click += new System.EventHandler(this.ResAddBtn_Click);
            // 
            // resEditBtn
            // 
            this.resEditBtn.BackColor = System.Drawing.Color.Olive;
            this.resEditBtn.FlatAppearance.BorderSize = 0;
            this.resEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resEditBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resEditBtn.ForeColor = System.Drawing.Color.White;
            this.resEditBtn.Location = new System.Drawing.Point(407, 496);
            this.resEditBtn.Name = "resEditBtn";
            this.resEditBtn.Size = new System.Drawing.Size(100, 40);
            this.resEditBtn.TabIndex = 4;
            this.resEditBtn.Text = "EDIT";
            this.resEditBtn.UseVisualStyleBackColor = false;
            // 
            // resDltBtn
            // 
            this.resDltBtn.BackColor = System.Drawing.Color.Red;
            this.resDltBtn.FlatAppearance.BorderSize = 0;
            this.resDltBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resDltBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resDltBtn.ForeColor = System.Drawing.Color.White;
            this.resDltBtn.Location = new System.Drawing.Point(627, 496);
            this.resDltBtn.Name = "resDltBtn";
            this.resDltBtn.Size = new System.Drawing.Size(100, 40);
            this.resDltBtn.TabIndex = 5;
            this.resDltBtn.Text = "CLEAR";
            this.resDltBtn.UseVisualStyleBackColor = false;
            // 
            // reservationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.resDltBtn);
            this.Controls.Add(this.resEditBtn);
            this.Controls.Add(this.resAddBtn);
            this.Controls.Add(this.resSearchBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "reservationUC";
            this.Size = new System.Drawing.Size(960, 560);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button resSearchBtn;
        private System.Windows.Forms.Button resAddBtn;
        private System.Windows.Forms.Button resEditBtn;
        private System.Windows.Forms.Button resDltBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
