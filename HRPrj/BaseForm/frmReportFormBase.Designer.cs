namespace HRPrj.BaseForm
{
    partial class frmReportFormBase
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
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLoadReport = new System.Windows.Forms.ToolStripButton();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.crvReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cboNhanvien = new System.Windows.Forms.ComboBox();
            this.cboPhongban = new System.Windows.Forms.ComboBox();
            this.cboDonvi = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.grpInfo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grpDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.cboNhanvien);
            this.grpInfo.Controls.Add(this.cboPhongban);
            this.grpInfo.Controls.Add(this.cboDonvi);
            this.grpInfo.Controls.Add(this.Label3);
            this.grpInfo.Controls.Add(this.Label2);
            this.grpInfo.Controls.Add(this.Label1);
            this.grpInfo.Controls.Add(this.toolStrip1);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfo.Location = new System.Drawing.Point(0, 0);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(783, 127);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Tùy chọn lọc";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadReport});
            this.toolStrip1.Location = new System.Drawing.Point(3, 99);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(777, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLoadReport
            // 
            this.btnLoadReport.Image = global::HRPrj.Properties.Resources.chart16;
            this.btnLoadReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadReport.Name = "btnLoadReport";
            this.btnLoadReport.Size = new System.Drawing.Size(84, 22);
            this.btnLoadReport.Text = "Lấy dữ liệu";
            this.btnLoadReport.Click += new System.EventHandler(this.btnLoadReport_Click);
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.crvReport);
            this.grpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetail.Location = new System.Drawing.Point(0, 127);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(783, 439);
            this.grpDetail.TabIndex = 1;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "Báo cáo chi tiết";
            // 
            // crvReport
            // 
            this.crvReport.ActiveViewIndex = -1;
            this.crvReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReport.Location = new System.Drawing.Point(3, 16);
            this.crvReport.Name = "crvReport";
            this.crvReport.Size = new System.Drawing.Size(777, 420);
            this.crvReport.TabIndex = 0;
            // 
            // cboNhanvien
            // 
            this.cboNhanvien.FormattingEnabled = true;
            this.cboNhanvien.Location = new System.Drawing.Point(81, 71);
            this.cboNhanvien.Name = "cboNhanvien";
            this.cboNhanvien.Size = new System.Drawing.Size(361, 21);
            this.cboNhanvien.TabIndex = 5;
            // 
            // cboPhongban
            // 
            this.cboPhongban.FormattingEnabled = true;
            this.cboPhongban.Location = new System.Drawing.Point(81, 46);
            this.cboPhongban.Name = "cboPhongban";
            this.cboPhongban.Size = new System.Drawing.Size(361, 21);
            this.cboPhongban.TabIndex = 6;
            // 
            // cboDonvi
            // 
            this.cboDonvi.FormattingEnabled = true;
            this.cboDonvi.Location = new System.Drawing.Point(81, 19);
            this.cboDonvi.Name = "cboDonvi";
            this.cboDonvi.Size = new System.Drawing.Size(361, 21);
            this.cboDonvi.TabIndex = 7;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(7, 74);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(59, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Nhân viên:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(7, 50);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(62, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Phòng ban:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(41, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Đơn vị:";
            // 
            // frmReportFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 566);
            this.Controls.Add(this.grpDetail);
            this.Controls.Add(this.grpInfo);
            this.Name = "frmReportFormBase";
            this.TabText = "Lý lịch nhân viên";
            this.Text = "Lý lịch nhân viên";
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.GroupBox grpDetail;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvReport;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLoadReport;
        internal System.Windows.Forms.ComboBox cboNhanvien;
        internal System.Windows.Forms.ComboBox cboPhongban;
        internal System.Windows.Forms.ComboBox cboDonvi;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}