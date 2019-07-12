namespace CA_Travels_Lanka
{
    partial class vehiclesUC
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
            this.vehicleDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiAddBtn = new System.Windows.Forms.Button();
            this.vehiEditBtn = new System.Windows.Forms.Button();
            this.vehiDltBtn = new System.Windows.Forms.Button();
            this.vehiSearchBtn = new System.Windows.Forms.Button();
            this.vehiSearchTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleDGV
            // 
            this.vehicleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.vehicleDGV.Location = new System.Drawing.Point(31, 110);
            this.vehicleDGV.Name = "vehicleDGV";
            this.vehicleDGV.RowHeadersWidth = 51;
            this.vehicleDGV.RowTemplate.Height = 24;
            this.vehicleDGV.Size = new System.Drawing.Size(895, 341);
            this.vehicleDGV.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Vehicle No.";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Type";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Owner Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Owner NIC";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Condition(AC/Non AC)";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // vehiAddBtn
            // 
            this.vehiAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.vehiAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vehiAddBtn.FlatAppearance.BorderSize = 0;
            this.vehiAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehiAddBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiAddBtn.ForeColor = System.Drawing.Color.White;
            this.vehiAddBtn.Location = new System.Drawing.Point(541, 480);
            this.vehiAddBtn.Name = "vehiAddBtn";
            this.vehiAddBtn.Size = new System.Drawing.Size(100, 40);
            this.vehiAddBtn.TabIndex = 1;
            this.vehiAddBtn.Text = "ADD";
            this.vehiAddBtn.UseVisualStyleBackColor = false;
            this.vehiAddBtn.Click += new System.EventHandler(this.VehiAddBtn_Click);
            // 
            // vehiEditBtn
            // 
            this.vehiEditBtn.BackColor = System.Drawing.Color.Olive;
            this.vehiEditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vehiEditBtn.FlatAppearance.BorderSize = 0;
            this.vehiEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehiEditBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiEditBtn.ForeColor = System.Drawing.Color.White;
            this.vehiEditBtn.Location = new System.Drawing.Point(660, 480);
            this.vehiEditBtn.Name = "vehiEditBtn";
            this.vehiEditBtn.Size = new System.Drawing.Size(100, 40);
            this.vehiEditBtn.TabIndex = 2;
            this.vehiEditBtn.Text = "EDIT";
            this.vehiEditBtn.UseVisualStyleBackColor = false;
            // 
            // vehiDltBtn
            // 
            this.vehiDltBtn.BackColor = System.Drawing.Color.Red;
            this.vehiDltBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vehiDltBtn.FlatAppearance.BorderSize = 0;
            this.vehiDltBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehiDltBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiDltBtn.ForeColor = System.Drawing.Color.White;
            this.vehiDltBtn.Location = new System.Drawing.Point(783, 480);
            this.vehiDltBtn.Name = "vehiDltBtn";
            this.vehiDltBtn.Size = new System.Drawing.Size(100, 40);
            this.vehiDltBtn.TabIndex = 3;
            this.vehiDltBtn.Text = "CLEAR";
            this.vehiDltBtn.UseVisualStyleBackColor = false;
            // 
            // vehiSearchBtn
            // 
            this.vehiSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.vehiSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vehiSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehiSearchBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiSearchBtn.ForeColor = System.Drawing.Color.White;
            this.vehiSearchBtn.Location = new System.Drawing.Point(783, 40);
            this.vehiSearchBtn.Name = "vehiSearchBtn";
            this.vehiSearchBtn.Size = new System.Drawing.Size(100, 40);
            this.vehiSearchBtn.TabIndex = 4;
            this.vehiSearchBtn.Text = "Search";
            this.vehiSearchBtn.UseVisualStyleBackColor = false;
            // 
            // vehiSearchTxt
            // 
            this.vehiSearchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiSearchTxt.Location = new System.Drawing.Point(577, 45);
            this.vehiSearchTxt.Name = "vehiSearchTxt";
            this.vehiSearchTxt.Size = new System.Drawing.Size(183, 30);
            this.vehiSearchTxt.TabIndex = 5;
            // 
            // vehiclesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.vehiSearchTxt);
            this.Controls.Add(this.vehiSearchBtn);
            this.Controls.Add(this.vehiDltBtn);
            this.Controls.Add(this.vehiEditBtn);
            this.Controls.Add(this.vehiAddBtn);
            this.Controls.Add(this.vehicleDGV);
            this.Name = "vehiclesUC";
            this.Size = new System.Drawing.Size(960, 560);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vehicleDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button vehiAddBtn;
        private System.Windows.Forms.Button vehiEditBtn;
        private System.Windows.Forms.Button vehiDltBtn;
        private System.Windows.Forms.Button vehiSearchBtn;
        private System.Windows.Forms.TextBox vehiSearchTxt;
    }
}
