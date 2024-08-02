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
            ((System.ComponentModel.ISupportInitialize)(this.DGVPQ)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPQ
            // 
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
            // UC_PhanQUyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DGVPQ);
            this.Name = "UC_PhanQUyen";
            this.Size = new System.Drawing.Size(1045, 574);
            this.Load += new System.EventHandler(this.UC_PhanQUyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPQ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DM_ManHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QL_NhomNguoiDung;
    }
}
