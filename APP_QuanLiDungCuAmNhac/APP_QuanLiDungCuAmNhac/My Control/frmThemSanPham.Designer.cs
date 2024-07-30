
namespace APP_QuanLiDungCuAmNhac.My_Control
{
    partial class frmThemSanPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_SoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbo_MaLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbo_MaTH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_DonGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_MoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_ChonHinh = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox_HinhAnh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txt_Url = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Luu = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TrangThai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_MaLoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_MaTH = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenSP.DefaultText = "";
            this.txt_TenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenSP.Location = new System.Drawing.Point(204, 130);
            this.txt_TenSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.PasswordChar = '\0';
            this.txt_TenSP.PlaceholderText = "";
            this.txt_TenSP.SelectedText = "";
            this.txt_TenSP.Size = new System.Drawing.Size(202, 61);
            this.txt_TenSP.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tableLayoutPanel1.Controls.Add(this.txt_MaTH, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_MaLoai, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_TrangThai, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Url, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_TenSP, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbo_MaLoai, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbo_MaTH, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_SoLuong, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_DonGia, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_MoTa, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_ChonHinh, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_HinhAnh, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(50, 78);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.70861F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.29139F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(410, 526);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoLuong.DefaultText = "";
            this.txt_SoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoLuong.Location = new System.Drawing.Point(204, 201);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.PasswordChar = '\0';
            this.txt_SoLuong.PlaceholderText = "";
            this.txt_SoLuong.SelectedText = "";
            this.txt_SoLuong.Size = new System.Drawing.Size(202, 55);
            this.txt_SoLuong.TabIndex = 2;
            // 
            // cbo_MaLoai
            // 
            this.cbo_MaLoai.BackColor = System.Drawing.Color.Transparent;
            this.cbo_MaLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_MaLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_MaLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_MaLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_MaLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_MaLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_MaLoai.ItemHeight = 40;
            this.cbo_MaLoai.Location = new System.Drawing.Point(203, 3);
            this.cbo_MaLoai.Name = "cbo_MaLoai";
            this.cbo_MaLoai.Size = new System.Drawing.Size(204, 46);
            this.cbo_MaLoai.TabIndex = 3;
            // 
            // cbo_MaTH
            // 
            this.cbo_MaTH.BackColor = System.Drawing.Color.Transparent;
            this.cbo_MaTH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_MaTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_MaTH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_MaTH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_MaTH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_MaTH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_MaTH.ItemHeight = 40;
            this.cbo_MaTH.Location = new System.Drawing.Point(203, 58);
            this.cbo_MaTH.Name = "cbo_MaTH";
            this.cbo_MaTH.Size = new System.Drawing.Size(202, 46);
            this.cbo_MaTH.TabIndex = 4;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DonGia.DefaultText = "";
            this.txt_DonGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DonGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DonGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DonGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DonGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DonGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DonGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DonGia.Location = new System.Drawing.Point(204, 266);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.PasswordChar = '\0';
            this.txt_DonGia.PlaceholderText = "";
            this.txt_DonGia.SelectedText = "";
            this.txt_DonGia.Size = new System.Drawing.Size(202, 57);
            this.txt_DonGia.TabIndex = 5;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MoTa.DefaultText = "";
            this.txt_MoTa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MoTa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MoTa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MoTa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MoTa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MoTa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MoTa.Location = new System.Drawing.Point(204, 333);
            this.txt_MoTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.PasswordChar = '\0';
            this.txt_MoTa.PlaceholderText = "";
            this.txt_MoTa.SelectedText = "";
            this.txt_MoTa.Size = new System.Drawing.Size(202, 57);
            this.txt_MoTa.TabIndex = 6;
            // 
            // btn_ChonHinh
            // 
            this.btn_ChonHinh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChonHinh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChonHinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ChonHinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ChonHinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ChonHinh.ForeColor = System.Drawing.Color.White;
            this.btn_ChonHinh.Location = new System.Drawing.Point(3, 398);
            this.btn_ChonHinh.Name = "btn_ChonHinh";
            this.btn_ChonHinh.Size = new System.Drawing.Size(194, 60);
            this.btn_ChonHinh.TabIndex = 3;
            this.btn_ChonHinh.Text = "Chọn Hình Ảnh";
            this.btn_ChonHinh.Click += new System.EventHandler(this.btn_ChonHinh_Click);
            // 
            // pictureBox_HinhAnh
            // 
            this.pictureBox_HinhAnh.ImageRotate = 0F;
            this.pictureBox_HinhAnh.Location = new System.Drawing.Point(203, 398);
            this.pictureBox_HinhAnh.Name = "pictureBox_HinhAnh";
            this.pictureBox_HinhAnh.Size = new System.Drawing.Size(204, 125);
            this.pictureBox_HinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_HinhAnh.TabIndex = 7;
            this.pictureBox_HinhAnh.TabStop = false;
            // 
            // txt_Url
            // 
            this.txt_Url.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Url.DefaultText = "";
            this.txt_Url.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Url.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Url.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Url.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Url.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Url.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Url.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Url.Location = new System.Drawing.Point(4, 5);
            this.txt_Url.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.PasswordChar = '\0';
            this.txt_Url.PlaceholderText = "";
            this.txt_Url.SelectedText = "";
            this.txt_Url.Size = new System.Drawing.Size(192, 45);
            this.txt_Url.TabIndex = 8;
            // 
            // btn_Luu
            // 
            this.btn_Luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(172, 607);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(156, 53);
            this.btn_Luu.TabIndex = 9;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // txt_TrangThai
            // 
            this.txt_TrangThai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TrangThai.DefaultText = "";
            this.txt_TrangThai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TrangThai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TrangThai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TrangThai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TrangThai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TrangThai.Location = new System.Drawing.Point(4, 60);
            this.txt_TrangThai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.PasswordChar = '\0';
            this.txt_TrangThai.PlaceholderText = "";
            this.txt_TrangThai.SelectedText = "";
            this.txt_TrangThai.Size = new System.Drawing.Size(192, 45);
            this.txt_TrangThai.TabIndex = 9;
            // 
            // txt_MaLoai
            // 
            this.txt_MaLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaLoai.DefaultText = "";
            this.txt_MaLoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaLoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaLoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaLoai.Location = new System.Drawing.Point(4, 130);
            this.txt_MaLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MaLoai.Name = "txt_MaLoai";
            this.txt_MaLoai.PasswordChar = '\0';
            this.txt_MaLoai.PlaceholderText = "";
            this.txt_MaLoai.SelectedText = "";
            this.txt_MaLoai.Size = new System.Drawing.Size(192, 45);
            this.txt_MaLoai.TabIndex = 10;
            // 
            // txt_MaTH
            // 
            this.txt_MaTH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaTH.DefaultText = "";
            this.txt_MaTH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaTH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaTH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaTH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaTH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaTH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaTH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaTH.Location = new System.Drawing.Point(4, 201);
            this.txt_MaTH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MaTH.Name = "txt_MaTH";
            this.txt_MaTH.PasswordChar = '\0';
            this.txt_MaTH.PlaceholderText = "";
            this.txt_MaTH.SelectedText = "";
            this.txt_MaTH.Size = new System.Drawing.Size(192, 45);
            this.txt_MaTH.TabIndex = 11;
            // 
            // frmThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 661);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "frmThemSanPham";
            this.Text = "frmThemSanPham";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenSP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_MaLoai;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_MaTH;
        private Guna.UI2.WinForms.Guna2TextBox txt_SoLuong;
        private Guna.UI2.WinForms.Guna2TextBox txt_DonGia;
        private Guna.UI2.WinForms.Guna2TextBox txt_MoTa;
        private Guna.UI2.WinForms.Guna2Button btn_ChonHinh;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox_HinhAnh;
        private Guna.UI2.WinForms.Guna2TextBox txt_Url;
        private Guna.UI2.WinForms.Guna2Button btn_Luu;
        private Guna.UI2.WinForms.Guna2TextBox txt_TrangThai;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaTH;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaLoai;
    }
}