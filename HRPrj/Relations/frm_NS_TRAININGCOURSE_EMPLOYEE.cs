
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KPIPrj.BusinessLayer;
/*
' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Modify by: SONNT										
' Description: SONNT									
' Date Created: 6/10/2016								
' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
*/
namespace HRPrj.Relations
{
    public partial class frm_NS_TRAININGCOURSE_EMPLOYEE : HRPrj.Baseform.frmBaseDirectory
    {
        public frm_NS_TRAININGCOURSE_EMPLOYEE()
        {
            InitializeComponent();
        }
        int indexID;
        NS_TRAININGCOURSE_EMPLOYEEFactory gFactor = new NS_TRAININGCOURSE_EMPLOYEEFactory();
        NS_TRAININGCOURSE_EMPLOYEE gNS_TRAININGCOURSE_EMPLOYEE = new NS_TRAININGCOURSE_EMPLOYEE();
        DataView dvKhoaDaoTao = new DataView();
        DataView dvDanhMuc = new DataView();

        #region override
        public override void RefreshList()
        {
            try
            {
                ClearControl();
                dtMain = gFactor.GetAllBy(NS_TRAININGCOURSE_EMPLOYEE.NS_TRAININGCOURSE_EMPLOYEEFields.Manhanvien, gEmployee.Manhanvien);
                this.lblTK.Text = "Tổng bản ghi:" + dtMain.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                App.ShowError(ex);
            }
            base.RefreshList();
        }
        public override void FormatGrid()
        {
            try
            {
                grvDetail.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
                grvDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grvDetail.Columns["DaoTaoNhanVienID"].Visible = false;
                grvDetail.Columns["KhoaDaoTaoID"].Visible = false;
               // grvDetail.Columns["KhoaDaoTao"].HeaderText = App.GetTextToFormatGrid(lblKhoaDaoTao.Text);
                grvDetail.Columns["NoiDung"].HeaderText = App.GetTextToFormatGrid(lblNoiDung.Text);
                grvDetail.Columns["ThoiGian"].HeaderText = App.GetTextToFormatGrid(lblThoiGian.Text);
                grvDetail.Columns["TuNgay"].HeaderText = App.GetTextToFormatGrid(lblTuNgay.Text);
                grvDetail.Columns["DenNgay"].HeaderText = App.GetTextToFormatGrid(lblDenNgay.Text);
                grvDetail.Columns["Manhanvien"].HeaderText = App.GetTextToFormatGrid(lblManhanvien.Text);
                grvDetail.Columns["DanhMucID"].Visible = false;
                //grvDetail.Columns["DanhMuc"].HeaderText = App.GetTextToFormatGrid(lblDanhMuc.Text);
                grvDetail.Columns["GhiChu"].HeaderText = App.GetTextToFormatGrid(lblGhiChu.Text);
            }
            catch (Exception ex)
            {
                App.ShowError(ex);
            }
            base.FormatGrid();
        }
        public override void SelectRecord()
        {
            try
            {
                indexID = (int)grvDetail.CurrentRow.Cells["DaoTaoNhanVienID"].Value;

                if (grvDetail.CurrentRow.Cells["KhoaDaoTaoID"].Value != DBNull.Value) cboKhoaDaoTao.SelectedValue = Convert.ToInt32(grvDetail.CurrentRow.Cells["KhoaDaoTaoID"].Value);

                if (grvDetail.CurrentRow.Cells["NoiDung"].Value != DBNull.Value) txtNoiDung.Text = Convert.ToString(grvDetail.CurrentRow.Cells["NoiDung"].Value);

                if (grvDetail.CurrentRow.Cells["ThoiGian"].Value != DBNull.Value) txtThoiGian.Text = Convert.ToString(grvDetail.CurrentRow.Cells["ThoiGian"].Value);

                if (grvDetail.CurrentRow.Cells["TuNgay"].Value != DBNull.Value) dtpTuNgay.Value = Convert.ToDateTime(grvDetail.CurrentRow.Cells["TuNgay"].Value);

                if (grvDetail.CurrentRow.Cells["DenNgay"].Value != DBNull.Value) dtpDenNgay.Value = Convert.ToDateTime(grvDetail.CurrentRow.Cells["DenNgay"].Value);

                if (grvDetail.CurrentRow.Cells["Manhanvien"].Value != DBNull.Value) txtManhanvien.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Manhanvien"].Value);

                if (grvDetail.CurrentRow.Cells["DanhMucID"].Value != DBNull.Value) cboDanhMuc.SelectedValue = Convert.ToInt32(grvDetail.CurrentRow.Cells["DanhMucID"].Value);

                if (grvDetail.CurrentRow.Cells["GhiChu"].Value != DBNull.Value) txtGhiChu.Text = Convert.ToString(grvDetail.CurrentRow.Cells["GhiChu"].Value);
            }
            catch (Exception ex)
            {
                App.ShowError(ex);
            }

            base.SelectRecord();
        }
        public override void DeleteRecord()
        {
            try
            {
                NS_TRAININGCOURSE_EMPLOYEEKeys objNS_TRAININGCOURSE_EMPLOYEEKeys = new NS_TRAININGCOURSE_EMPLOYEEKeys(Convert.ToInt32(grvDetail.CurrentRow.Cells["NS_TRAININGCOURSE_EMPLOYEEID"].Value));
                gFactor.Delete(objNS_TRAININGCOURSE_EMPLOYEEKeys);
            }
            catch (Exception ex)
            {
                App.ShowError(ex);
            }
            base.DeleteRecord();
        }
        public override void UndoRecord()
        {
            try
            {

            }
            catch (Exception ex)
            {
                App.ShowError(ex);
            }
            base.UndoRecord();
        }
        public override void SaveRecord()
        {
            try
            {
                if (isInsert) gFactor.Insert(SetValue());
                else gFactor.Update(SetValue());
            }
            catch (Exception ex)
            {
                App.ShowError(ex);
            }
            base.SaveRecord();
        }
        public override void ClearControl()
        {
            try
            {
                txtNoiDung.Clear();
                txtThoiGian.Clear();
                dtpTuNgay.Value = DateTime.Now.Date;
                dtpDenNgay.Value = DateTime.Now.Date;
                txtManhanvien.Clear();
                txtGhiChu.Clear();
            }
            catch (Exception ex)
            {
                App.ShowError(ex);
            }
            base.ClearControl();
        }
        public override void LoadCombobox()
        {

            NS_TRAININGCOURSEFactory _KhoaDaoTaoFactor = new NS_TRAININGCOURSEFactory();
            dvKhoaDaoTao = new DataView(_KhoaDaoTaoFactor.GetAll());
            App.LoadCombo(cboKhoaDaoTao, "Ten", "KhoaDaoTaoID", dvKhoaDaoTao);
            base.LoadCombobox();
            NS_DMFIXFactory _DanhMucFactor = new NS_DMFIXFactory();
            dvDanhMuc = new DataView(_DanhMucFactor.GetAllBy(NS_DMFIX.NS_DMFIXFields.Type,"ĐT"));
            App.LoadCombo(cboDanhMuc, "Ten", "DanhMucID", dvDanhMuc);
            base.LoadCombobox();
        }
        /* Kiem tra du lieu dau vao */
        public override bool isValid()
        {
            try
            {
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtDaoTaoNhanVienID.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtDaoTaoNhanVienID","Loi nhap lieu")
                           txtDaoTaoNhanVienID.Focus();
                       }
               */
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtKhoaDaoTaoID.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtKhoaDaoTaoID","Loi nhap lieu")
                           txtKhoaDaoTaoID.Focus();
                       }
               */
                /*  if (txtNoiDung.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtNoiDung","Loi nhap lieu")
                         txtNoiDung.Focus();
                         return false;
                      } 
                  */
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtThoiGian.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtThoiGian","Loi nhap lieu")
                           txtThoiGian.Focus();
                       }
               */
                /*  if (txtManhanvien.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtManhanvien","Loi nhap lieu")
                         txtManhanvien.Focus();
                         return false;
                      } 
                  */
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtDanhMucID.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtDanhMucID","Loi nhap lieu")
                           txtDanhMucID.Focus();
                       }
               */
                /*  if (txtGhiChu.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtGhiChu","Loi nhap lieu")
                         txtGhiChu.Focus();
                         return false;
                      } 
                  */
            }
            catch (Exception ex)
            {
                App.ShowError(ex);
            }
            return base.isValid();
        }
        #endregion
        #region Function
        private NS_TRAININGCOURSE_EMPLOYEE SetValue()
        {
            NS_TRAININGCOURSE_EMPLOYEE NS_TRAININGCOURSE_EMPLOYEESetValue = new NS_TRAININGCOURSE_EMPLOYEE();
            try
            {
                NS_TRAININGCOURSE_EMPLOYEESetValue.DaoTaoNhanVienID = indexID;
                if (cboKhoaDaoTao.SelectedValue != null)
                    NS_TRAININGCOURSE_EMPLOYEESetValue.KhoaDaoTaoID = Convert.ToInt32(cboKhoaDaoTao.SelectedValue);
                else
                    NS_TRAININGCOURSE_EMPLOYEESetValue.KhoaDaoTaoID = 0;
                NS_TRAININGCOURSE_EMPLOYEESetValue.NoiDung = txtNoiDung.Text;
                NS_TRAININGCOURSE_EMPLOYEESetValue.ThoiGian = Convert.ToInt32(txtThoiGian.Text);
                NS_TRAININGCOURSE_EMPLOYEESetValue.TuNgay = dtpTuNgay.Value.Date;
                NS_TRAININGCOURSE_EMPLOYEESetValue.DenNgay = dtpDenNgay.Value.Date;
                NS_TRAININGCOURSE_EMPLOYEESetValue.Manhanvien = gEmployee.Manhanvien;
                if (cboDanhMuc.SelectedValue != null)
                    NS_TRAININGCOURSE_EMPLOYEESetValue.DanhMucID = Convert.ToInt32(cboDanhMuc.SelectedValue);
                else
                    NS_TRAININGCOURSE_EMPLOYEESetValue.DanhMucID = 0;
                NS_TRAININGCOURSE_EMPLOYEESetValue.GhiChu = txtGhiChu.Text;
            }
            catch (Exception ex)
            {
                App.ShowError(ex);
            }
            return NS_TRAININGCOURSE_EMPLOYEESetValue;
        }
        #endregion
        private void controls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.SelectNextControl((Control)sender, true, true, true, true);
        }

    }
}

