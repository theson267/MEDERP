
/*
' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Modify by: SONNT										
' Description: SONNT									
' Date Created: 6/10/2016								
' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
*/
namespace HRPrj.Relations
{
    partial class frm_NS_CONTRACT_EMPLOYEE
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
            this.lblTenHopDong = new System.Windows.Forms.Label();
            this.lblSoHopDong = new System.Windows.Forms.Label();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.lblNguoiTao = new System.Windows.Forms.Label();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.lblNguoiSua = new System.Windows.Forms.Label();
            this.lblNgaySua = new System.Windows.Forms.Label();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.txtTenHopDong = new System.Windows.Forms.TextBox();
            this.txtSoHopDong = new System.Windows.Forms.TextBox();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.txtNguoiTao = new System.Windows.Forms.TextBox();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.txtNguoiSua = new System.Windows.Forms.TextBox();
            this.dtpNgaySua = new System.Windows.Forms.DateTimePicker();
            this.GroupMaster = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dtMain)).BeginInit();
            this.panelMaster.SuspendLayout();
            this.panelDetail.SuspendLayout();
            this.GroupMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMaster
            // 
            this.panelMaster.Controls.Add(this.GroupMaster);
            this.panelMaster.Size = new System.Drawing.Size(466, 94);
            // 
            // panelDetail
            // 
            this.panelDetail.Size = new System.Drawing.Size(466, 314);
            // 
            // groupPanel1
            // 
            this.groupPanel1.Size = new System.Drawing.Size(466, 289);
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
            this.lblManhanvien.Location = new System.Drawing.Point(2, 212);
            this.lblManhanvien.Name = "lblManhanvien";
            this.lblManhanvien.Size = new System.Drawing.Size(75, 13);
            this.lblManhanvien.TabIndex = 0;
            this.lblManhanvien.Text = "Mã nhân viên:";
            // 
            // lblTenHopDong
            // 
            this.lblTenHopDong.AutoSize = true;
            this.lblTenHopDong.BackColor = System.Drawing.Color.Transparent;
            this.lblTenHopDong.Location = new System.Drawing.Point(2, 38);
            this.lblTenHopDong.Name = "lblTenHopDong";
            this.lblTenHopDong.Size = new System.Drawing.Size(78, 13);
            this.lblTenHopDong.TabIndex = 1;
            this.lblTenHopDong.Text = "Tên hợp đồng:";
            // 
            // lblSoHopDong
            // 
            this.lblSoHopDong.AutoSize = true;
            this.lblSoHopDong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoHopDong.Location = new System.Drawing.Point(2, 64);
            this.lblSoHopDong.Name = "lblSoHopDong";
            this.lblSoHopDong.Size = new System.Drawing.Size(72, 13);
            this.lblSoHopDong.TabIndex = 2;
            this.lblSoHopDong.Text = "Số hợp đồng:";
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.BackColor = System.Drawing.Color.Transparent;
            this.lblDanhMuc.Location = new System.Drawing.Point(2, 12);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(79, 13);
            this.lblDanhMuc.TabIndex = 3;
            this.lblDanhMuc.Text = "Loại hợp đồng:";
            // 
            // lblNguoiTao
            // 
            this.lblNguoiTao.AutoSize = true;
            this.lblNguoiTao.BackColor = System.Drawing.Color.Transparent;
            this.lblNguoiTao.Location = new System.Drawing.Point(2, 238);
            this.lblNguoiTao.Name = "lblNguoiTao";
            this.lblNguoiTao.Size = new System.Drawing.Size(56, 13);
            this.lblNguoiTao.TabIndex = 4;
            this.lblNguoiTao.Text = "Người tạo:";
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayTao.Location = new System.Drawing.Point(2, 264);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(53, 13);
            this.lblNgayTao.TabIndex = 5;
            this.lblNgayTao.Text = "Ngày tạo:";
            // 
            // lblNguoiSua
            // 
            this.lblNguoiSua.AutoSize = true;
            this.lblNguoiSua.BackColor = System.Drawing.Color.Transparent;
            this.lblNguoiSua.Location = new System.Drawing.Point(2, 290);
            this.lblNguoiSua.Name = "lblNguoiSua";
            this.lblNguoiSua.Size = new System.Drawing.Size(58, 13);
            this.lblNguoiSua.TabIndex = 6;
            this.lblNguoiSua.Text = "Người sửa:";
            // 
            // lblNgaySua
            // 
            this.lblNgaySua.AutoSize = true;
            this.lblNgaySua.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySua.Location = new System.Drawing.Point(2, 316);
            this.lblNgaySua.Name = "lblNgaySua";
            this.lblNgaySua.Size = new System.Drawing.Size(55, 13);
            this.lblNgaySua.TabIndex = 7;
            this.lblNgaySua.Text = "Ngày sửa:";
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.Location = new System.Drawing.Point(87, 209);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.Size = new System.Drawing.Size(150, 20);
            this.txtManhanvien.TabIndex = 8;
            // 
            // txtTenHopDong
            // 
            this.txtTenHopDong.Location = new System.Drawing.Point(87, 35);
            this.txtTenHopDong.Name = "txtTenHopDong";
            this.txtTenHopDong.Size = new System.Drawing.Size(360, 20);
            this.txtTenHopDong.TabIndex = 9;
            // 
            // txtSoHopDong
            // 
            this.txtSoHopDong.Location = new System.Drawing.Point(87, 61);
            this.txtSoHopDong.Name = "txtSoHopDong";
            this.txtSoHopDong.Size = new System.Drawing.Size(360, 20);
            this.txtSoHopDong.TabIndex = 10;
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(87, 9);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(360, 21);
            this.cboDanhMuc.TabIndex = 11;
            // 
            // txtNguoiTao
            // 
            this.txtNguoiTao.Location = new System.Drawing.Point(87, 235);
            this.txtNguoiTao.Name = "txtNguoiTao";
            this.txtNguoiTao.Size = new System.Drawing.Size(150, 20);
            this.txtNguoiTao.TabIndex = 12;
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTao.Location = new System.Drawing.Point(87, 261);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(86, 20);
            this.dtpNgayTao.TabIndex = 13;
            // 
            // txtNguoiSua
            // 
            this.txtNguoiSua.Location = new System.Drawing.Point(87, 287);
            this.txtNguoiSua.Name = "txtNguoiSua";
            this.txtNguoiSua.Size = new System.Drawing.Size(150, 20);
            this.txtNguoiSua.TabIndex = 14;
            // 
            // dtpNgaySua
            // 
            this.dtpNgaySua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySua.Location = new System.Drawing.Point(87, 313);
            this.dtpNgaySua.Name = "dtpNgaySua";
            this.dtpNgaySua.Size = new System.Drawing.Size(86, 20);
            this.dtpNgaySua.TabIndex = 15;
            // 
            // GroupMaster
            // 
            this.GroupMaster.CanvasColor = System.Drawing.SystemColors.Control;
            this.GroupMaster.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GroupMaster.Controls.Add(this.lblManhanvien);
            this.GroupMaster.Controls.Add(this.lblTenHopDong);
            this.GroupMaster.Controls.Add(this.lblSoHopDong);
            this.GroupMaster.Controls.Add(this.lblDanhMuc);
            this.GroupMaster.Controls.Add(this.lblNguoiTao);
            this.GroupMaster.Controls.Add(this.lblNgayTao);
            this.GroupMaster.Controls.Add(this.lblNguoiSua);
            this.GroupMaster.Controls.Add(this.lblNgaySua);
            this.GroupMaster.Controls.Add(this.txtManhanvien);
            this.GroupMaster.Controls.Add(this.txtTenHopDong);
            this.GroupMaster.Controls.Add(this.txtSoHopDong);
            this.GroupMaster.Controls.Add(this.cboDanhMuc);
            this.GroupMaster.Controls.Add(this.txtNguoiTao);
            this.GroupMaster.Controls.Add(this.dtpNgayTao);
            this.GroupMaster.Controls.Add(this.txtNguoiSua);
            this.GroupMaster.Controls.Add(this.dtpNgaySua);
            this.GroupMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupMaster.Location = new System.Drawing.Point(0, 0);
            this.GroupMaster.Name = "GroupMaster";
            this.GroupMaster.Size = new System.Drawing.Size(466, 94);
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
            // frm_NS_CONTRACT_EMPLOYEE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 427);
            this.Name = "frm_NS_CONTRACT_EMPLOYEE";
            this.Text = "Danh sách hợp đồng";
            ((System.ComponentModel.ISupportInitialize)(this.dtMain)).EndInit();
            this.panelMaster.ResumeLayout(false);
            this.panelDetail.ResumeLayout(false);
            this.GroupMaster.ResumeLayout(false);
            this.GroupMaster.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Label lblManhanvien;
        private System.Windows.Forms.TextBox txtManhanvien;
        private System.Windows.Forms.Label lblTenHopDong;
        private System.Windows.Forms.TextBox txtTenHopDong;
        private System.Windows.Forms.Label lblSoHopDong;
        private System.Windows.Forms.TextBox txtSoHopDong;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.Label lblNguoiTao;
        private System.Windows.Forms.TextBox txtNguoiTao;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.Label lblNguoiSua;
        private System.Windows.Forms.TextBox txtNguoiSua;
        private System.Windows.Forms.Label lblNgaySua;
        private System.Windows.Forms.DateTimePicker dtpNgaySua;
        private DevComponents.DotNetBar.Controls.GroupPanel GroupMaster;
    }
}
