using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UM;
namespace HRPrj.Baseform
{
    public partial class frmBaseDirectoryKPI : UM.frmNewBase 
    {
        DataView dvMain;
        public DataTable dtMain = new DataTable();
        private DataTable TableFilterData;
        private DataGridViewColumnCollection TableColumnCollection;
        public bool isInsert;
        public frmBaseDirectoryKPI()
        {
            InitializeComponent();
        }
        #region virtual
        public virtual void RefreshList()
        {
           
        }
        public virtual void FormatGrid()
        {
            
        }
        public virtual void SelectRecord()
        {
        }
        public virtual void AddNewRecord()
        {
            ClearControl();
            isInsert = true;
        }
        public virtual void UpdateRecord()
        {
            isInsert = false;
        }
        public virtual void DeleteRecord()
        {
        }
        public virtual void UndoRecord()
        {
        }
        public virtual void SaveRecord()
        {
        }
        public virtual void ClearControl()
        {
           
        }
        public virtual void LoadCombobox()
        {

        }
        public virtual bool isValid()
        {
            return true;
        }
        #endregion
        #region Function
        private void SetStatusSelectRecord(bool iSelect)
        {
            tsbSave.Enabled = !iSelect;
            tsbUndo.Enabled = !iSelect;
            tsbAddNew.Enabled = iSelect;
            tsbEdit.Enabled = iSelect;
            tsbDelete.Enabled = iSelect;
            tsbFilter.Enabled = iSelect;
            tsbUnFilter.Enabled = iSelect;
            mnuSave.Enabled = !iSelect;
            mnuUndo.Enabled = !iSelect;
            mnuAddNew.Enabled = iSelect;
            mnuEditRecord.Enabled = iSelect;
            mnuDelete.Enabled = iSelect;
            mnuFilter.Enabled = iSelect;
            mnuUnFilter.Enabled = iSelect;
        }
        private void Filter()
        {
            dvMain = new DataView(dtMain);

            try
            {
                // Build the RowFilter statement according to the user restriction 
                foreach (DataRow FilterRow in TableFilterData.Rows)
                {
                    if (FilterRow["Operation"].ToString() == "") continue;
                    if (dvMain.RowFilter == string.Empty)
                    {
                        if (FilterRow["Operation"].ToString() == "LIKE")

                            dvMain.RowFilter = FilterRow["ColumnName"].ToString() + " " + FilterRow["Operation"].ToString() + " '%" + FilterRow["ColumnData"].ToString() + "%' ";
                        else
                            dvMain.RowFilter = FilterRow["ColumnName"].ToString() + " " + FilterRow["Operation"].ToString() + " '" + FilterRow["ColumnData"].ToString() + "' ";

                    }

                    else
                    {
                        if (FilterRow["Operation"].ToString() == "LIKE")
                            dvMain.RowFilter += " AND " + FilterRow["ColumnName"].ToString() + " " + FilterRow["Operation"].ToString() + " '%" + FilterRow["ColumnData"].ToString() + "%'";
                        else
                            dvMain.RowFilter += " AND " + FilterRow["ColumnName"].ToString() + " " + FilterRow["Operation"].ToString() + " '" + FilterRow["ColumnData"].ToString() + "'";

                    }
                }
                FormatGrid();
            }


            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void tsb_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.ButtonItem tsbtmp = default(DevComponents.DotNetBar.ButtonItem);
            tsbtmp = (DevComponents.DotNetBar.ButtonItem)sender;
            if (tsbtmp.Name == tsbAddNew.Name)
            {
                AddNewRecord();
                SetStatusSelectRecord(false);
            }
            else if (tsbtmp.Name == tsbEdit.Name)
            {
                //if (grvDetail.Rows.Count <= 0 || grvDetail.CurrentRow.Index < 0)
                //{
                //    tssLabel.Text = "Chưa chọn bản ghi cần chỉnh sửa!";
                //    return;
                //}
                UpdateRecord();
                SetStatusSelectRecord(false);
            }
            else if (tsbtmp.Name == tsbDelete.Name)
            {
                //if (grvDetail.Rows.Count <= 0 || grvDetail.CurrentRow == null)
                //{
                //    tssLabel.Text = "Chưa chọn bản ghi cần xóa!";
                //    return;
                //}
                DialogResult dlgResult = MessageBox.Show("Bạn có chắc chắn xóa bản ghi đã chọn không?", App.TitleMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.No) return;
                DeleteRecord();
                SetStatusSelectRecord(false);
                RefreshList();
            }
            else if (tsbtmp.Name == tsbSave.Name)
            {
                if (!isValid()) return;
                SaveRecord();
                SetStatusSelectRecord(true);
                RefreshList();
            }
            else if (tsbtmp.Name == tsbUndo.Name)
            {
                UndoRecord();
                SetStatusSelectRecord(true);
                RefreshList();
            }
            else if (tsbtmp.Name == tsbClose.Name)
            {
                if (MessageBox.Show("Xác nhận thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else if (tsbtmp.Name == tsbFilter.Name)
            {
                //frmFilter DataFilter = new frmFilter();

                ////Set the Column Collection to the filter Table
                //DataFilter.SetSourceColumns(TableColumnCollection);

                //DataFilter.ShowDialog();

                //////The TableFilterData Table contains the user restriction
                //TableFilterData = DataFilter.GetFilterDataTable();

                //Filter();
            }
            else if (tsbtmp.Name == tsbUnFilter.Name)
            {
                //UnFilter();
                SetStatusSelectRecord(true);
                RefreshList();
            }

        }
        private void frmBaseDirectory_Load(object sender, EventArgs e)
        {
            //if (DesignMode) return;
            //CheckRight();
            LoadInfomation();
            LoadCombobox();
        }
        private void LoadInfomation()
        {
            if (isFullControl)
            {
                SetStatusSelectRecord(true);
            }
            SetStatusSelectRecord(true);
            RefreshList();
        }
        public override void SetRight()
        {
            if (!isReadOnly && !isFullControl)
            {
                panelDetail.Visible = false;
                panelMaster.Visible = false;
                return;
            }
            if (!isFullControl)
            {
                tsbAddNew.Enabled = false;
                tsbDelete.Enabled = false;
                tsbEdit.Enabled = false;
            }
            base.SetRight();
        }

        private void grvDetail_Click(object sender, DataGridViewCellEventArgs e)
        {
            SelectRecord();
        }
    }
}
