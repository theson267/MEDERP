
/*
' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Modify by: SONNT										
' Description: SONNT									
' Date Created: 6/9/2016								
' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
*/
namespace HRPrj.Relations
{
    partial class frm_NS_DOCUMENTS_EMPLOYEE
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
            this.lblManhanvien = new System.Windows.Forms.Label();
            this.lblDocument = new System.Windows.Forms.Label();
            this.lblTenTaiLieu = new System.Windows.Forms.Label();
            this.lblNgayCap = new System.Windows.Forms.Label();
            this.lblAnh = new System.Windows.Forms.Label();
            this.lblNguoiTao = new System.Windows.Forms.Label();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.lblNguoiCapNhat = new System.Windows.Forms.Label();
            this.lblNgayCapNhat = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.cboDocument = new System.Windows.Forms.ComboBox();
            this.txtTenTaiLieu = new System.Windows.Forms.TextBox();
            this.dtpNgayCap = new System.Windows.Forms.DateTimePicker();
            this.txtNguoiTao = new System.Windows.Forms.TextBox();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.txtNguoiCapNhat = new System.Windows.Forms.TextBox();
            this.dtpNgayCapNhat = new System.Windows.Forms.DateTimePicker();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.GroupMaster = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lkChonAnh = new System.Windows.Forms.LinkLabel();
            this.picAnh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtMain)).BeginInit();
            this.panelMaster.SuspendLayout();
            this.panelDetail.SuspendLayout();
            this.GroupMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMaster
            // 
            this.panelMaster.Controls.Add(this.GroupMaster);
            this.panelMaster.Size = new System.Drawing.Size(743, 175);
            // 
            // panelDetail
            // 
            this.panelDetail.Size = new System.Drawing.Size(743, 359);
            // 
            // groupPanel1
            // 
            this.groupPanel1.Size = new System.Drawing.Size(743, 334);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // lblTK
            // 
            this.lblTK.Text = "Tổng bản ghi:0";
            // 
            // lblManhanvien
            // 
            this.lblManhanvien.AutoSize = true;
            this.lblManhanvien.BackColor = System.Drawing.Color.Transparent;
            this.lblManhanvien.Location = new System.Drawing.Point(0, 11);
            this.lblManhanvien.Name = "lblManhanvien";
            this.lblManhanvien.Size = new System.Drawing.Size(75, 13);
            this.lblManhanvien.TabIndex = 0;
            this.lblManhanvien.Text = "Mã nhân viên:";
            // 
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.BackColor = System.Drawing.Color.Transparent;
            this.lblDocument.Location = new System.Drawing.Point(0, 37);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(63, 13);
            this.lblDocument.TabIndex = 1;
            this.lblDocument.Text = "Loại tài liệu:";
            // 
            // lblTenTaiLieu
            // 
            this.lblTenTaiLieu.AutoSize = true;
            this.lblTenTaiLieu.BackColor = System.Drawing.Color.Transparent;
            this.lblTenTaiLieu.Location = new System.Drawing.Point(0, 64);
            this.lblTenTaiLieu.Name = "lblTenTaiLieu";
            this.lblTenTaiLieu.Size = new System.Drawing.Size(62, 13);
            this.lblTenTaiLieu.TabIndex = 2;
            this.lblTenTaiLieu.Text = "Tên tài liệu:";
            // 
            // lblNgayCap
            // 
            this.lblNgayCap.AutoSize = true;
            this.lblNgayCap.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayCap.Location = new System.Drawing.Point(0, 91);
            this.lblNgayCap.Name = "lblNgayCap";
            this.lblNgayCap.Size = new System.Drawing.Size(56, 13);
            this.lblNgayCap.TabIndex = 3;
            this.lblNgayCap.Text = "Ngày cấp:";
            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.BackColor = System.Drawing.Color.Transparent;
            this.lblAnh.Location = new System.Drawing.Point(382, 12);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(29, 13);
            this.lblAnh.TabIndex = 4;
            this.lblAnh.Text = "Ảnh:";
            // 
            // lblNguoiTao
            // 
            this.lblNguoiTao.AutoSize = true;
            this.lblNguoiTao.BackColor = System.Drawing.Color.Transparent;
            this.lblNguoiTao.Location = new System.Drawing.Point(113, 204);
            this.lblNguoiTao.Name = "lblNguoiTao";
            this.lblNguoiTao.Size = new System.Drawing.Size(56, 13);
            this.lblNguoiTao.TabIndex = 5;
            this.lblNguoiTao.Text = "Người tạo:";
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayTao.Location = new System.Drawing.Point(119, 243);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(53, 13);
            this.lblNgayTao.TabIndex = 6;
            this.lblNgayTao.Text = "Ngày tạo:";
            // 
            // lblNguoiCapNhat
            // 
            this.lblNguoiCapNhat.AutoSize = true;
            this.lblNguoiCapNhat.BackColor = System.Drawing.Color.Transparent;
            this.lblNguoiCapNhat.Location = new System.Drawing.Point(165, 354);
            this.lblNguoiCapNhat.Name = "lblNguoiCapNhat";
            this.lblNguoiCapNhat.Size = new System.Drawing.Size(83, 13);
            this.lblNguoiCapNhat.TabIndex = 7;
            this.lblNguoiCapNhat.Text = "Người cập nhật:";
            // 
            // lblNgayCapNhat
            // 
            this.lblNgayCapNhat.AutoSize = true;
            this.lblNgayCapNhat.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayCapNhat.Location = new System.Drawing.Point(165, 380);
            this.lblNgayCapNhat.Name = "lblNgayCapNhat";
            this.lblNgayCapNhat.Size = new System.Drawing.Size(80, 13);
            this.lblNgayCapNhat.TabIndex = 8;
            this.lblNgayCapNhat.Text = "Ngày cập nhật:";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.BackColor = System.Drawing.Color.Transparent;
            this.lblTinhTrang.Location = new System.Drawing.Point(0, 117);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(58, 13);
            this.lblTinhTrang.TabIndex = 9;
            this.lblTinhTrang.Text = "Tình trạng:";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.BackColor = System.Drawing.Color.Transparent;
            this.lblGhiChu.Location = new System.Drawing.Point(0, 143);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(47, 13);
            this.lblGhiChu.TabIndex = 10;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.Enabled = false;
            this.txtManhanvien.Location = new System.Drawing.Point(86, 9);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.Size = new System.Drawing.Size(290, 20);
            this.txtManhanvien.TabIndex = 11;
            // 
            // cboDocument
            // 
            this.cboDocument.FormattingEnabled = true;
            this.cboDocument.Location = new System.Drawing.Point(86, 35);
            this.cboDocument.Name = "cboDocument";
            this.cboDocument.Size = new System.Drawing.Size(290, 21);
            this.cboDocument.TabIndex = 12;
            // 
            // txtTenTaiLieu
            // 
            this.txtTenTaiLieu.Location = new System.Drawing.Point(86, 61);
            this.txtTenTaiLieu.Name = "txtTenTaiLieu";
            this.txtTenTaiLieu.Size = new System.Drawing.Size(290, 20);
            this.txtTenTaiLieu.TabIndex = 13;
            // 
            // dtpNgayCap
            // 
            this.dtpNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCap.Location = new System.Drawing.Point(86, 87);
            this.dtpNgayCap.Name = "dtpNgayCap";
            this.dtpNgayCap.Size = new System.Drawing.Size(120, 20);
            this.dtpNgayCap.TabIndex = 14;
            // 
            // txtNguoiTao
            // 
            this.txtNguoiTao.Location = new System.Drawing.Point(199, 204);
            this.txtNguoiTao.Name = "txtNguoiTao";
            this.txtNguoiTao.Size = new System.Drawing.Size(290, 20);
            this.txtNguoiTao.TabIndex = 16;
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTao.Location = new System.Drawing.Point(199, 230);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(86, 20);
            this.dtpNgayTao.TabIndex = 17;
            // 
            // txtNguoiCapNhat
            // 
            this.txtNguoiCapNhat.Location = new System.Drawing.Point(251, 354);
            this.txtNguoiCapNhat.Name = "txtNguoiCapNhat";
            this.txtNguoiCapNhat.Size = new System.Drawing.Size(290, 20);
            this.txtNguoiCapNhat.TabIndex = 18;
            // 
            // dtpNgayCapNhat
            // 
            this.dtpNgayCapNhat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCapNhat.Location = new System.Drawing.Point(251, 380);
            this.dtpNgayCapNhat.Name = "dtpNgayCapNhat";
            this.dtpNgayCapNhat.Size = new System.Drawing.Size(86, 20);
            this.dtpNgayCapNhat.TabIndex = 19;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(86, 113);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(290, 20);
            this.txtTinhTrang.TabIndex = 20;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(86, 139);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(290, 20);
            this.txtGhiChu.TabIndex = 21;
            // 
            // GroupMaster
            // 
            this.GroupMaster.CanvasColor = System.Drawing.SystemColors.Control;
            this.GroupMaster.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GroupMaster.Controls.Add(this.lblNgayTao);
            this.GroupMaster.Controls.Add(this.lkChonAnh);
            this.GroupMaster.Controls.Add(this.txtNguoiTao);
            this.GroupMaster.Controls.Add(this.dtpNgayTao);
            this.GroupMaster.Controls.Add(this.picAnh);
            this.GroupMaster.Controls.Add(this.lblNguoiTao);
            this.GroupMaster.Controls.Add(this.lblManhanvien);
            this.GroupMaster.Controls.Add(this.lblDocument);
            this.GroupMaster.Controls.Add(this.lblTenTaiLieu);
            this.GroupMaster.Controls.Add(this.lblNgayCap);
            this.GroupMaster.Controls.Add(this.lblAnh);
            this.GroupMaster.Controls.Add(this.lblNguoiCapNhat);
            this.GroupMaster.Controls.Add(this.lblNgayCapNhat);
            this.GroupMaster.Controls.Add(this.lblTinhTrang);
            this.GroupMaster.Controls.Add(this.lblGhiChu);
            this.GroupMaster.Controls.Add(this.txtManhanvien);
            this.GroupMaster.Controls.Add(this.cboDocument);
            this.GroupMaster.Controls.Add(this.txtTenTaiLieu);
            this.GroupMaster.Controls.Add(this.dtpNgayCap);
            this.GroupMaster.Controls.Add(this.txtNguoiCapNhat);
            this.GroupMaster.Controls.Add(this.dtpNgayCapNhat);
            this.GroupMaster.Controls.Add(this.txtTinhTrang);
            this.GroupMaster.Controls.Add(this.txtGhiChu);
            this.GroupMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupMaster.Location = new System.Drawing.Point(0, 0);
            this.GroupMaster.Name = "GroupMaster";
            this.GroupMaster.Size = new System.Drawing.Size(743, 175);
            // 
            // 
            // 
            this.GroupMaster.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GroupMaster.Style.BackColorGradientAngle = 90;
            this.GroupMaster.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GroupMaster.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupMaster.Style.BorderBottomWidth = 1;
            this.GroupMaster.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GroupMaster.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupMaster.Style.BorderLeftWidth = 1;
            this.GroupMaster.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupMaster.Style.BorderRightWidth = 1;
            this.GroupMaster.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupMaster.Style.BorderTopWidth = 1;
            this.GroupMaster.Style.CornerDiameter = 4;
            this.GroupMaster.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GroupMaster.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GroupMaster.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GroupMaster.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GroupMaster.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GroupMaster.TabIndex = 1;
            // 
            // lkChonAnh
            // 
            this.lkChonAnh.AutoSize = true;
            this.lkChonAnh.Location = new System.Drawing.Point(419, 143);
            this.lkChonAnh.Name = "lkChonAnh";
            this.lkChonAnh.Size = new System.Drawing.Size(53, 13);
            this.lkChonAnh.TabIndex = 23;
            this.lkChonAnh.TabStop = true;
            this.lkChonAnh.Text = "Chọn ảnh";
            this.lkChonAnh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkChonAnh_LinkClicked);
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(417, 12);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(311, 147);
            this.picAnh.TabIndex = 22;
            this.picAnh.TabStop = false;
            // 
            // frm_NS_DOCUMENTS_EMPLOYEE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 553);
            this.Name = "frm_NS_DOCUMENTS_EMPLOYEE";
            this.Text = "Danh sách tài liệu nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dtMain)).EndInit();
            this.panelMaster.ResumeLayout(false);
            this.panelDetail.ResumeLayout(false);
            this.GroupMaster.ResumeLayout(false);
            this.GroupMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Label lblManhanvien;
        private System.Windows.Forms.TextBox txtManhanvien;
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.ComboBox cboDocument;
        private System.Windows.Forms.Label lblTenTaiLieu;
        private System.Windows.Forms.TextBox txtTenTaiLieu;
        private System.Windows.Forms.Label lblNgayCap;
        private System.Windows.Forms.DateTimePicker dtpNgayCap;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.Label lblNguoiTao;
        private System.Windows.Forms.TextBox txtNguoiTao;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.Label lblNguoiCapNhat;
        private System.Windows.Forms.TextBox txtNguoiCapNhat;
        private System.Windows.Forms.Label lblNgayCapNhat;
        private System.Windows.Forms.DateTimePicker dtpNgayCapNhat;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private DevComponents.DotNetBar.Controls.GroupPanel GroupMaster;
        private System.Windows.Forms.LinkLabel lkChonAnh;
        private System.Windows.Forms.PictureBox picAnh;
    }
}
