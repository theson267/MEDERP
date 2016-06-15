
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
    public partial class frm_NS_ALLOWANCE_EMPLOYEE : HRPrj.Baseform.frmBaseDirectory
    {
        public frm_NS_ALLOWANCE_EMPLOYEE()
        {
            InitializeComponent();
        }
        int indexID;
        NS_ALLOWANCE_EMPLOYEEFactory gFactor = new NS_ALLOWANCE_EMPLOYEEFactory();
        NS_ALLOWANCE_EMPLOYEE gNS_ALLOWANCE_EMPLOYEE = new NS_ALLOWANCE_EMPLOYEE();
        DataView dvPhuCap = new DataView();

        #region override
        public override void RefreshList()
        {
            try
            {
                ClearControl();
                dtMain = gFactor.GetAllBy(NS_ALLOWANCE_EMPLOYEE.NS_ALLOWANCE_EMPLOYEEFields.Manhanvien, gEmployee.Manhanvien);
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
                grvDetail.Columns["PhuCapNhanVienID"].Visible = false;
                grvDetail.Columns["Manhanvien"].HeaderText = App.GetTextToFormatGrid(lblManhanvien.Text);
                grvDetail.Columns["PhuCapID"].Visible = false;
               // grvDetail.Columns["PhuCap"].HeaderText = App.GetTextToFormatGrid(lblPhuCap.Text);
                grvDetail.Columns["DienGiai"].HeaderText = App.GetTextToFormatGrid(lblDienGiai.Text);
                grvDetail.Columns["SoTien"].HeaderText = App.GetTextToFormatGrid(lblSoTien.Text);
                grvDetail.Columns["NguoiTao"].HeaderText = App.GetTextToFormatGrid(lblNguoiTao.Text);
                grvDetail.Columns["NgayTao"].HeaderText = App.GetTextToFormatGrid(lblNgayTao.Text);
                grvDetail.Columns["NguoiSua"].HeaderText = App.GetTextToFormatGrid(lblNguoiSua.Text);
                grvDetail.Columns["NgaySua"].HeaderText = App.GetTextToFormatGrid(lblNgaySua.Text);
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
                indexID = (int)grvDetail.CurrentRow.Cells["PhuCapNhanVienID"].Value;

                if (grvDetail.CurrentRow.Cells["Manhanvien"].Value != DBNull.Value) txtManhanvien.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Manhanvien"].Value);

                if (grvDetail.CurrentRow.Cells["PhuCapID"].Value != DBNull.Value) cboPhuCap.SelectedValue = Convert.ToInt32(grvDetail.CurrentRow.Cells["PhuCapID"].Value);

                if (grvDetail.CurrentRow.Cells["DienGiai"].Value != DBNull.Value) txtDienGiai.Text = Convert.ToString(grvDetail.CurrentRow.Cells["DienGiai"].Value);

                if (grvDetail.CurrentRow.Cells["SoTien"].Value != DBNull.Value) txtSoTien.Text = Convert.ToString(grvDetail.CurrentRow.Cells["SoTien"].Value);

                if (grvDetail.CurrentRow.Cells["NguoiTao"].Value != DBNull.Value) txtNguoiTao.Text = Convert.ToString(grvDetail.CurrentRow.Cells["NguoiTao"].Value);

                if (grvDetail.CurrentRow.Cells["NgayTao"].Value != DBNull.Value) dtpNgayTao.Value = Convert.ToDateTime(grvDetail.CurrentRow.Cells["NgayTao"].Value);

                if (grvDetail.CurrentRow.Cells["NguoiSua"].Value != DBNull.Value) txtNguoiSua.Text = Convert.ToString(grvDetail.CurrentRow.Cells["NguoiSua"].Value);

                if (grvDetail.CurrentRow.Cells["NgaySua"].Value != DBNull.Value) dtpNgaySua.Value = Convert.ToDateTime(grvDetail.CurrentRow.Cells["NgaySua"].Value);
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
                NS_ALLOWANCE_EMPLOYEEKeys objNS_ALLOWANCE_EMPLOYEEKeys = new NS_ALLOWANCE_EMPLOYEEKeys(Convert.ToInt32(grvDetail.CurrentRow.Cells["NS_ALLOWANCE_EMPLOYEEID"].Value));
                gFactor.Delete(objNS_ALLOWANCE_EMPLOYEEKeys);
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
                txtManhanvien.Clear();
                txtDienGiai.Clear();
                txtSoTien.Clear();
                txtNguoiTao.Clear();
                dtpNgayTao.Value = DateTime.Now.Date;
                txtNguoiSua.Clear();
                dtpNgaySua.Value = DateTime.Now.Date;
            }
            catch (Exception ex)
            {
                App.ShowError(ex);
            }
            base.ClearControl();
        }
        public override void LoadCombobox()
        {

            NS_ALLOWANCEFactory _PhuCapFactor = new NS_ALLOWANCEFactory();
            dvPhuCap = new DataView(_PhuCapFactor.GetAll());
            App.LoadCombo(cboPhuCap, "TenPhuCap", "PhuCapID", dvPhuCap);
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
                           int v = Convert.ToInt32(txtPhuCapNhanVienID.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtPhuCapNhanVienID","Loi nhap lieu")
                           txtPhuCapNhanVienID.Focus();
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
                           int v = Convert.ToInt32(txtPhuCapID.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtPhuCapID","Loi nhap lieu")
                           txtPhuCapID.Focus();
                       }
               */
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtDienGiai.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtDienGiai","Loi nhap lieu")
                           txtDienGiai.Focus();
                       }
               */
                /*  if (txtNguoiTao.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtNguoiTao","Loi nhap lieu")
                         txtNguoiTao.Focus();
                         return false;
                      } 
                  */
                /*  if (txtNguoiSua.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtNguoiSua","Loi nhap lieu")
                         txtNguoiSua.Focus();
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
        private NS_ALLOWANCE_EMPLOYEE SetValue()
        {
            NS_ALLOWANCE_EMPLOYEE NS_ALLOWANCE_EMPLOYEESetValue = new NS_ALLOWANCE_EMPLOYEE();
            try
            {
                NS_ALLOWANCE_EMPLOYEESetValue.PhuCapNhanVienID = indexID;
                NS_ALLOWANCE_EMPLOYEESetValue.Manhanvien = gEmployee.Manhanvien ;
                if (cboPhuCap.SelectedValue != null)
                    NS_ALLOWANCE_EMPLOYEESetValue.PhuCapID = Convert.ToInt32(cboPhuCap.SelectedValue);
                else
                    NS_ALLOWANCE_EMPLOYEESetValue.PhuCapID = 0;
                NS_ALLOWANCE_EMPLOYEESetValue.DienGiai = Convert.ToInt32(txtDienGiai.Text);
                NS_ALLOWANCE_EMPLOYEESetValue.SoTien = double.Parse(txtSoTien.Text.ToString());
                NS_ALLOWANCE_EMPLOYEESetValue.NguoiTao = txtNguoiTao.Text;
                NS_ALLOWANCE_EMPLOYEESetValue.NgayTao = dtpNgayTao.Value.Date;
                NS_ALLOWANCE_EMPLOYEESetValue.NguoiSua = txtNguoiSua.Text;
                NS_ALLOWANCE_EMPLOYEESetValue.NgaySua = dtpNgaySua.Value.Date;
            }
            catch (Exception ex)
            {
                App.ShowError(ex);
            }
            return NS_ALLOWANCE_EMPLOYEESetValue;
        }
        #endregion
        private void controls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.SelectNextControl((Control)sender, true, true, true, true);
        }

    }
}

