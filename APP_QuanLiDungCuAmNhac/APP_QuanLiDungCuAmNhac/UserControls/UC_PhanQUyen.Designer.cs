namespace APP_QuanLiDungCuAmNhac.UserControls
{
    partial class UC_PhanQUyen
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
            this.DGVPQ = new System.Windows.Forms.DataGridView();
            this.DM_ManHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QL_NhomNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVNhom = new System.Windows.Forms.DataGridView();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.CBBManHinh = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhom)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPQ
            // 
            this.DGVPQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVPQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DM_ManHinh,
            this.QL_NhomNguoiDung});
            this.DGVPQ.Location = new System.Drawing.Point(538, 95);
            this.DGVPQ.Name = "DGVPQ";
            this.DGVPQ.RowHeadersWidth = 51;
            this.DGVPQ.RowTemplate.Height = 24;
            this.DGVPQ.Size = new System.Drawing.Size(460, 402);
            this.DGVPQ.TabIndex = 0;
            this.DGVPQ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPQ_CellContentClick);
            this.DGVPQ.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPQ_CellEndEdit);
            this.DGVPQ.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPQ_CellValueChanged);
            this.DGVPQ.CurrentCellDirtyStateChanged += new System.EventHandler(this.DGVPQ_CurrentCellDirtyStateChanged);
            // 
            // DM_ManHinh
            // 
            this.DM_ManHinh.DataPropertyName = "DM_ManHinh";
            this.DM_ManHinh.HeaderText = "";
            this.DM_ManHinh.MinimumWidth = 6;
            this.DM_ManHinh.Name = "DM_ManHinh";
            this.DM_ManHinh.Visible = false;
            this.DM_ManHinh.Width = 125;
            // 
            // QL_NhomNguoiDung
            // 
            this.QL_NhomNguoiDung.DataPropertyName = "QL_NhomNguoiDung";
            this.QL_NhomNguoiDung.HeaderText = "";
            this.QL_NhomNguoiDung.MinimumWidth = 6;
            this.QL_NhomNguoiDung.Name = "QL_NhomNguoiDung";
            this.QL_NhomNguoiDung.Visible = false;
            this.QL_NhomNguoiDung.Width = 125;
            // 
            // DGVNhom
            // 
            this.DGVNhom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNhom.Location = new System.Drawing.Point(22, 95);
            this.DGVNhom.Name = "DGVNhom";
            this.DGVNhom.RowHeadersWidth = 51;
            this.DGVNhom.RowTemplate.Height = 24;
            this.DGVNhom.Size = new System.Drawing.Size(450, 401);
            this.DGVNhom.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.BorderRadius = 7;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(38, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(190, 49);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // CBBManHinh
            // 
            this.CBBManHinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBBManHinh.BackColor = System.Drawing.Color.Transparent;
            this.CBBManHinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBBManHinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBManHinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBBManHinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBBManHinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBBManHinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBBManHinh.ItemHeight = 30;
            this.CBBManHinh.Location = new System.Drawing.Point(263, 34);
            this.CBBManHinh.Name = "CBBManHinh";
            this.CBBManHinh.Size = new System.Drawing.Size(267, 36);
            this.CBBManHinh.TabIndex = 6;
            // 
            // UC_PhanQUyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CBBManHinh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.DGVNhom);
            this.Controls.Add(this.DGVPQ);
            this.Name = "UC_PhanQUyen";
            this.Size = new System.Drawing.Size(1045, 574);
            this.Load += new System.EventHandler(this.UC_PhanQUyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DM_ManHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QL_NhomNguoiDung;
        private System.Windows.Forms.DataGridView DGVNhom;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2ComboBox CBBManHinh;
    }
}
