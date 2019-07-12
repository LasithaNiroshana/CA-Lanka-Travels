namespace CA_Travels_Lanka
{
    partial class customerUC
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
            this.cusDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusAddBtn = new System.Windows.Forms.Button();
            this.cusEditBtn = new System.Windows.Forms.Button();
            this.cusSearchTxt = new System.Windows.Forms.TextBox();
            this.cusSearchBtn = new System.Windows.Forms.Button();
            this.cusDltBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cusDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cusDGV
            // 
            this.cusDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cusDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.cusDGV.Location = new System.Drawing.Point(80, 116);
            this.cusDGV.Name = "cusDGV";
            this.cusDGV.RowHeadersWidth = 51;
            this.cusDGV.RowTemplate.Height = 24;
            this.cusDGV.Size = new System.Drawing.Size(803, 334);
            this.cusDGV.TabIndex = 0;
            this.cusDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CusDGV_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NIC";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Address";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Phone No.";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Email";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // cusAddBtn
            // 
            this.cusAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cusAddBtn.FlatAppearance.BorderSize = 0;
            this.cusAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusAddBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusAddBtn.ForeColor = System.Drawing.Color.White;
            this.cusAddBtn.Location = new System.Drawing.Point(162, 483);
            this.cusAddBtn.Name = "cusAddBtn";
            this.cusAddBtn.Size = new System.Drawing.Size(100, 40);
            this.cusAddBtn.TabIndex = 1;
            this.cusAddBtn.Text = "ADD";
            this.cusAddBtn.UseVisualStyleBackColor = false;
            this.cusAddBtn.Click += new System.EventHandler(this.CusAddBtn_Click);
            // 
            // cusEditBtn
            // 
            this.cusEditBtn.BackColor = System.Drawing.Color.Olive;
            this.cusEditBtn.FlatAppearance.BorderSize = 0;
            this.cusEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusEditBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusEditBtn.ForeColor = System.Drawing.Color.White;
            this.cusEditBtn.Location = new System.Drawing.Point(416, 483);
            this.cusEditBtn.Name = "cusEditBtn";
            this.cusEditBtn.Size = new System.Drawing.Size(100, 40);
            this.cusEditBtn.TabIndex = 2;
            this.cusEditBtn.Text = "EDIT";
            this.cusEditBtn.UseVisualStyleBackColor = false;
            // 
            // cusSearchTxt
            // 
            this.cusSearchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusSearchTxt.Location = new System.Drawing.Point(586, 38);
            this.cusSearchTxt.Name = "cusSearchTxt";
            this.cusSearchTxt.Size = new System.Drawing.Size(193, 30);
            this.cusSearchTxt.TabIndex = 3;
            // 
            // cusSearchBtn
            // 
            this.cusSearchBtn.BackColor = System.Drawing.Color.Blue;
            this.cusSearchBtn.FlatAppearance.BorderSize = 0;
            this.cusSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusSearchBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusSearchBtn.ForeColor = System.Drawing.Color.White;
            this.cusSearchBtn.Location = new System.Drawing.Point(797, 33);
            this.cusSearchBtn.Name = "cusSearchBtn";
            this.cusSearchBtn.Size = new System.Drawing.Size(100, 40);
            this.cusSearchBtn.TabIndex = 4;
            this.cusSearchBtn.Text = "Search";
            this.cusSearchBtn.UseVisualStyleBackColor = false;
            // 
            // cusDltBtn
            // 
            this.cusDltBtn.BackColor = System.Drawing.Color.Red;
            this.cusDltBtn.FlatAppearance.BorderSize = 0;
            this.cusDltBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusDltBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusDltBtn.ForeColor = System.Drawing.Color.White;
            this.cusDltBtn.Location = new System.Drawing.Point(679, 483);
            this.cusDltBtn.Name = "cusDltBtn";
            this.cusDltBtn.Size = new System.Drawing.Size(100, 40);
            this.cusDltBtn.TabIndex = 5;
            this.cusDltBtn.Text = "DELETE";
            this.cusDltBtn.UseVisualStyleBackColor = false;
            // 
            // customerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cusDltBtn);
            this.Controls.Add(this.cusSearchBtn);
            this.Controls.Add(this.cusSearchTxt);
            this.Controls.Add(this.cusEditBtn);
            this.Controls.Add(this.cusAddBtn);
            this.Controls.Add(this.cusDGV);
            this.Name = "customerUC";
            this.Size = new System.Drawing.Size(960, 560);
            ((System.ComponentModel.ISupportInitialize)(this.cusDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cusDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button cusAddBtn;
        private System.Windows.Forms.Button cusEditBtn;
        private System.Windows.Forms.TextBox cusSearchTxt;
        private System.Windows.Forms.Button cusSearchBtn;
        private System.Windows.Forms.Button cusDltBtn;
    }
}
