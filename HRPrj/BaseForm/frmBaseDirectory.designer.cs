namespace HRPrj.Baseform
{
    partial class frmBaseDirectory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseDirectory));
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMaster = new System.Windows.Forms.Panel();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.grvDetail = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.tsbAddNew = new DevComponents.DotNetBar.ButtonItem();
            this.tsbEdit = new DevComponents.DotNetBar.ButtonItem();
            this.tsbDelete = new DevComponents.DotNetBar.ButtonItem();
            this.tsbSave = new DevComponents.DotNetBar.ButtonItem();
            this.tsbUndo = new DevComponents.DotNetBar.ButtonItem();
            this.tsbFilter = new DevComponents.DotNetBar.ButtonItem();
            this.tsbUnFilter = new DevComponents.DotNetBar.ButtonItem();
            this.tsbClose = new DevComponents.DotNetBar.ButtonItem();
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.tssLabel = new DevComponents.DotNetBar.LabelItem();
            this.tssError = new DevComponents.DotNetBar.LabelItem();
            this.lblTK = new DevComponents.DotNetBar.LabelItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDetail.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.mnuDelete.Size = new System.Drawing.Size(191, 22);
            this.mnuDelete.Text = "Xóa một bản ghi";
            // 
            // mnuEditRecord
            // 
            this.mnuEditRecord.Name = "mnuEditRecord";
            this.mnuEditRecord.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuEditRecord.Size = new System.Drawing.Size(191, 22);
            this.mnuEditRecord.Text = "Sửa bản ghi";
            // 
            // mnuAddNew
            // 
            this.mnuAddNew.Name = "mnuAddNew";
            this.mnuAddNew.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuAddNew.Size = new System.Drawing.Size(191, 22);
            this.mnuAddNew.Text = "Thêm mới bản ghi";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 6);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuSave.Size = new System.Drawing.Size(191, 22);
            this.mnuSave.Text = "Lưu ";
            // 
            // mnuUndo
            // 
            this.mnuUndo.Name = "mnuUndo";
            this.mnuUndo.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.mnuUndo.Size = new System.Drawing.Size(191, 22);
            this.mnuUndo.Text = "Phục hồi";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(188, 6);
            // 
            // mnuFilter
            // 
            this.mnuFilter.Name = "mnuFilter";
            this.mnuFilter.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.mnuFilter.Size = new System.Drawing.Size(191, 22);
            this.mnuFilter.Text = "Tìm kiếm";
            // 
            // mnuUnFilter
            // 
            this.mnuUnFilter.Name = "mnuUnFilter";
            this.mnuUnFilter.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.mnuUnFilter.Size = new System.Drawing.Size(191, 22);
            this.mnuUnFilter.Text = "Hủy tìm kiếm";
            // 
            // panelMaster
            // 
            this.panelMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaster.Location = new System.Drawing.Point(0, 0);
            this.panelMaster.Name = "panelMaster";
            this.panelMaster.Size = new System.Drawing.Size(1011, 223);
            this.panelMaster.TabIndex = 7;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.groupPanel1);
            this.panelDetail.Controls.Add(this.bar1);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 0);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(1011, 244);
            this.panelDetail.TabIndex = 10;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.grvDetail);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 25);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1011, 219);
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
            this.groupPanel1.TabIndex = 13;
            // 
            // grvDetail
            // 
            this.grvDetail.AllowUserToAddRows = false;
            this.grvDetail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvDetail.DefaultCellStyle = dataGridViewCellStyle1;
            this.grvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grvDetail.Location = new System.Drawing.Point(0, 0);
            this.grvDetail.Name = "grvDetail";
            this.grvDetail.Size = new System.Drawing.Size(1005, 213);
            this.grvDetail.TabIndex = 3;
            this.grvDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDetail_Click);
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tsbAddNew,
            this.tsbEdit,
            this.tsbDelete,
            this.tsbSave,
            this.tsbUndo,
            this.tsbFilter,
            this.tsbUnFilter,
            this.tsbClose});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1011, 25);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 12;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // tsbAddNew
            // 
            this.tsbAddNew.Image = global::HRPrj.Properties.Resources.add1_16;
            this.tsbAddNew.Name = "tsbAddNew";
            this.tsbAddNew.Text = "F2-Thêm mới";
            this.tsbAddNew.Tooltip = "F2-Thêm mới";
            this.tsbAddNew.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::HRPrj.Properties.Resources.edit16;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Text = "F3-Sửa";
            this.tsbEdit.Tooltip = "F3-Sửa";
            this.tsbEdit.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::HRPrj.Properties.Resources.delete16;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Text = "F4-Xóa";
            this.tsbDelete.Tooltip = "F4-Xóa";
            this.tsbDelete.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::HRPrj.Properties.Resources.Save;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Text = "F5-Lưu";
            this.tsbSave.Tooltip = "F5-Lưu";
            this.tsbSave.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbUndo
            // 
            this.tsbUndo.Image = global::HRPrj.Properties.Resources.undo;
            this.tsbUndo.Name = "tsbUndo";
            this.tsbUndo.Text = "F6-Phục hồi";
            this.tsbUndo.Tooltip = "F6-Phục hồi";
            this.tsbUndo.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbFilter
            // 
            this.tsbFilter.Image = global::HRPrj.Properties.Resources.funnel;
            this.tsbFilter.Name = "tsbFilter";
            this.tsbFilter.Text = "F7-Lọc";
            this.tsbFilter.Tooltip = "F7-Lọc";
            this.tsbFilter.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbUnFilter
            // 
            this.tsbUnFilter.Image = global::HRPrj.Properties.Resources.unfunnel;
            this.tsbUnFilter.Name = "tsbUnFilter";
            this.tsbUnFilter.Text = "F8-Bỏ lọc";
            this.tsbUnFilter.Tooltip = "F8-Bỏ lọc";
            this.tsbUnFilter.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = global::HRPrj.Properties.Resources.close16;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Text = "F12 - Đóng";
            this.tsbClose.Tooltip = "F12 - Đóng";
            this.tsbClose.Click += new System.EventHandler(this.tsb_Click);
            // 
            // bar2
            // 
            this.bar2.AntiAlias = true;
            this.bar2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tssLabel,
            this.tssError,
            this.lblTK});
            this.bar2.Location = new System.Drawing.Point(0, 467);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(1011, 19);
            this.bar2.Stretch = true;
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar2.TabIndex = 11;
            this.bar2.TabStop = false;
            this.bar2.Text = "bar2";
            // 
            // tssLabel
            // 
            this.tssLabel.Name = "tssLabel";
            // 
            // tssError
            // 
            this.tssError.Name = "tssError";
            // 
            // lblTK
            // 
            this.lblTK.Name = "lblTK";
            this.lblTK.Text = "[Tổng]";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelDetail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 244);
            this.panel1.TabIndex = 12;
            // 
            // frmBaseDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bar2);
            this.Controls.Add(this.panelMaster);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaseDirectory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "frmBaseDirectory";
            this.Text = "frmBaseDirectory";
            this.Load += new System.EventHandler(this.frmBaseDirectory_Load);
            this.panelDetail.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuEditRecord;
        private System.Windows.Forms.ToolStripMenuItem mnuAddNew;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuFilter;
        private System.Windows.Forms.ToolStripMenuItem mnuUnFilter;
        public System.Windows.Forms.Panel panelMaster;
        public System.Windows.Forms.Panel panelDetail;
        private DevComponents.DotNetBar.Bar bar2;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelItem tssLabel;
        private DevComponents.DotNetBar.LabelItem tssError;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem tsbAddNew;
        private DevComponents.DotNetBar.ButtonItem tsbEdit;
        private DevComponents.DotNetBar.ButtonItem tsbDelete;
        private DevComponents.DotNetBar.ButtonItem tsbSave;
        private DevComponents.DotNetBar.ButtonItem tsbUndo;
        private DevComponents.DotNetBar.ButtonItem tsbFilter;
        private DevComponents.DotNetBar.ButtonItem tsbUnFilter;
        private DevComponents.DotNetBar.ButtonItem tsbClose;
        public DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        public DevComponents.DotNetBar.Controls.DataGridViewX grvDetail;
        public DevComponents.DotNetBar.LabelItem lblTK;
    }
}