
/*
' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Modify by: SONNT										
' Description: SONNT									
' Date Created: 6/10/2016								
' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
*/
namespace HRPrj.Relations
{
    partial class frm_NS_ALLOWANCE_EMPLOYEE
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
            this.lblPhuCap = new System.Windows.Forms.Label();
            this.lblDienGiai = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.lblNguoiTao = new System.Windows.Forms.Label();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.lblNguoiSua = new System.Windows.Forms.Label();
            this.lblNgaySua = new System.Windows.Forms.Label();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.cboPhuCap = new System.Windows.Forms.ComboBox();
            this.txtDienGiai = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
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
            this.panelMaster.Size = new System.Drawing.Size(733, 97);
            // 
            // panelDetail
            // 
            this.panelDetail.Size = new System.Drawing.Size(733, 322);
            // 
            // groupPanel1
            // 
            this.groupPanel1.Size = new System.Drawing.Size(733, 297);
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
            this.lblManhanvien.Location = new System.Drawing.Point(341, 221);
            this.lblManhanvien.Name = "lblManhanvien";
            this.lblManhanvien.Size = new System.Drawing.Size(75, 13);
            this.lblManhanvien.TabIndex = 0;
            this.lblManhanvien.Text = "Mã nhân viên:";
            // 
            // lblPhuCap
            // 
            this.lblPhuCap.AutoSize = true;
            this.lblPhuCap.BackColor = System.Drawing.Color.Transparent;
            this.lblPhuCap.Location = new System.Drawing.Point(0, 12);
            this.lblPhuCap.Name = "lblPhuCap";
            this.lblPhuCap.Size = new System.Drawing.Size(77, 13);
            this.lblPhuCap.TabIndex = 1;
            this.lblPhuCap.Text = "Chọn phụ cấp:";
            // 
            // lblDienGiai
            // 
            this.lblDienGiai.AutoSize = true;
            this.lblDienGiai.BackColor = System.Drawing.Color.Transparent;
            this.lblDienGiai.Location = new System.Drawing.Point(0, 38);
            this.lblDienGiai.Name = "lblDienGiai";
            this.lblDienGiai.Size = new System.Drawing.Size(51, 13);
            this.lblDienGiai.TabIndex = 2;
            this.lblDienGiai.Text = "Diễn giải:";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.BackColor = System.Drawing.Color.Transparent;
            this.lblSoTien.Location = new System.Drawing.Point(0, 64);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(43, 13);
            this.lblSoTien.TabIndex = 3;
            this.lblSoTien.Text = "Số tiền:";
            // 
            // lblNguoiTao
            // 
            this.lblNguoiTao.AutoSize = true;
            this.lblNguoiTao.BackColor = System.Drawing.Color.Transparent;
            this.lblNguoiTao.Location = new System.Drawing.Point(0, 133);
            this.lblNguoiTao.Name = "lblNguoiTao";
            this.lblNguoiTao.Size = new System.Drawing.Size(56, 13);
            this.lblNguoiTao.TabIndex = 4;
            this.lblNguoiTao.Text = "Người tạo:";
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayTao.Location = new System.Drawing.Point(0, 159);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(53, 13);
            this.lblNgayTao.TabIndex = 5;
            this.lblNgayTao.Text = "Ngày tạo:";
            // 
            // lblNguoiSua
            // 
            this.lblNguoiSua.AutoSize = true;
            this.lblNguoiSua.BackColor = System.Drawing.Color.Transparent;
            this.lblNguoiSua.Location = new System.Drawing.Point(0, 185);
            this.lblNguoiSua.Name = "lblNguoiSua";
            this.lblNguoiSua.Size = new System.Drawing.Size(58, 13);
            this.lblNguoiSua.TabIndex = 6;
            this.lblNguoiSua.Text = "Người sửa:";
            // 
            // lblNgaySua
            // 
            this.lblNgaySua.AutoSize = true;
            this.lblNgaySua.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySua.Location = new System.Drawing.Point(0, 211);
            this.lblNgaySua.Name = "lblNgaySua";
            this.lblNgaySua.Size = new System.Drawing.Size(55, 13);
            this.lblNgaySua.TabIndex = 7;
            this.lblNgaySua.Text = "Ngày sửa:";
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.Location = new System.Drawing.Point(425, 218);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.Size = new System.Drawing.Size(150, 20);
            this.txtManhanvien.TabIndex = 8;
            // 
            // cboPhuCap
            // 
            this.cboPhuCap.FormattingEnabled = true;
            this.cboPhuCap.Location = new System.Drawing.Point(84, 9);
            this.cboPhuCap.Name = "cboPhuCap";
            this.cboPhuCap.Size = new System.Drawing.Size(320, 21);
            this.cboPhuCap.TabIndex = 9;
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.Location = new System.Drawing.Point(84, 35);
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.Size = new System.Drawing.Size(320, 20);
            this.txtDienGiai.TabIndex = 10;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(84, 61);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(320, 20);
            this.txtSoTien.TabIndex = 11;
            // 
            // txtNguoiTao
            // 
            this.txtNguoiTao.Location = new System.Drawing.Point(84, 130);
            this.txtNguoiTao.Name = "txtNguoiTao";
            this.txtNguoiTao.Size = new System.Drawing.Size(150, 20);
            this.txtNguoiTao.TabIndex = 12;
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTao.Location = new System.Drawing.Point(84, 156);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(86, 20);
            this.dtpNgayTao.TabIndex = 13;
            // 
            // txtNguoiSua
            // 
            this.txtNguoiSua.Location = new System.Drawing.Point(84, 182);
            this.txtNguoiSua.Name = "txtNguoiSua";
            this.txtNguoiSua.Size = new System.Drawing.Size(150, 20);
            this.txtNguoiSua.TabIndex = 14;
            // 
            // dtpNgaySua
            // 
            this.dtpNgaySua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySua.Location = new System.Drawing.Point(84, 208);
            this.dtpNgaySua.Name = "dtpNgaySua";
            this.dtpNgaySua.Size = new System.Drawing.Size(86, 20);
            this.dtpNgaySua.TabIndex = 15;
            // 
            // GroupMaster
            // 
            this.GroupMaster.CanvasColor = System.Drawing.SystemColors.Control;
            this.GroupMaster.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GroupMaster.Controls.Add(this.lblManhanvien);
            this.GroupMaster.Controls.Add(this.lblPhuCap);
            this.GroupMaster.Controls.Add(this.lblDienGiai);
            this.GroupMaster.Controls.Add(this.lblSoTien);
            this.GroupMaster.Controls.Add(this.lblNguoiTao);
            this.GroupMaster.Controls.Add(this.lblNgayTao);
            this.GroupMaster.Controls.Add(this.lblNguoiSua);
            this.GroupMaster.Controls.Add(this.lblNgaySua);
            this.GroupMaster.Controls.Add(this.txtManhanvien);
            this.GroupMaster.Controls.Add(this.cboPhuCap);
            this.GroupMaster.Controls.Add(this.txtDienGiai);
            this.GroupMaster.Controls.Add(this.txtSoTien);
            this.GroupMaster.Controls.Add(this.txtNguoiTao);
            this.GroupMaster.Controls.Add(this.dtpNgayTao);
            this.GroupMaster.Controls.Add(this.txtNguoiSua);
            this.GroupMaster.Controls.Add(this.dtpNgaySua);
            this.GroupMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupMaster.Location = new System.Drawing.Point(0, 0);
            this.GroupMaster.Name = "GroupMaster";
            this.GroupMaster.Size = new System.Drawing.Size(733, 97);
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
            // frm_NS_ALLOWANCE_EMPLOYEE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 438);
            this.Name = "frm_NS_ALLOWANCE_EMPLOYEE";
            this.Text = "Phụ cấp nhân viên";
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
        private System.Windows.Forms.Label lblPhuCap;
        private System.Windows.Forms.ComboBox cboPhuCap;
        private System.Windows.Forms.Label lblDienGiai;
        private System.Windows.Forms.TextBox txtDienGiai;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.TextBox txtSoTien;
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
