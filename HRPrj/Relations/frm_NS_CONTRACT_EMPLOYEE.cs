
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
    public partial class frm_NS_CONTRACT_EMPLOYEE : HRPrj.Baseform.frmBaseDirectory
    {
        public frm_NS_CONTRACT_EMPLOYEE()
        {
            InitializeComponent();
        }
        int indexID;
        NS_CONTRACT_EMPLOYEEFactory gFactor = new NS_CONTRACT_EMPLOYEEFactory();
        NS_CONTRACT_EMPLOYEE gNS_CONTRACT_EMPLOYEE = new NS_CONTRACT_EMPLOYEE();
        DataView dvDanhMuc = new DataView();

        #region override
        public override void RefreshList()
        {
            try
            {
                ClearControl();
                dtMain = gFactor.GetAllBy(NS_CONTRACT_EMPLOYEE.NS_CONTRACT_EMPLOYEEFields.Manhanvien, gEmployee.Manhanvien);
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
                grvDetail.Columns["HopDongID"].Visible = false;
                grvDetail.Columns["Manhanvien"].HeaderText = App.GetTextToFormatGrid(lblManhanvien.Text);
                grvDetail.Columns["TenHopDong"].HeaderText = App.GetTextToFormatGrid(lblTenHopDong.Text);
                grvDetail.Columns["SoHopDong"].HeaderText = App.GetTextToFormatGrid(lblSoHopDong.Text);
                grvDetail.Columns["DanhMucID"].Visible = false;
                //grvDetail.Columns["DanhMuc"].HeaderText = App.GetTextToFormatGrid(lblDanhMuc.Text);
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
                indexID = (int)grvDetail.CurrentRow.Cells["HopDongID"].Value;

                if (grvDetail.CurrentRow.Cells["Manhanvien"].Value != DBNull.Value) txtManhanvien.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Manhanvien"].Value);

                if (grvDetail.CurrentRow.Cells["TenHopDong"].Value != DBNull.Value) txtTenHopDong.Text = Convert.ToString(grvDetail.CurrentRow.Cells["TenHopDong"].Value);

                if (grvDetail.CurrentRow.Cells["SoHopDong"].Value != DBNull.Value) txtSoHopDong.Text = Convert.ToString(grvDetail.CurrentRow.Cells["SoHopDong"].Value);

                if (grvDetail.CurrentRow.Cells["DanhMucID"].Value != DBNull.Value) cboDanhMuc.SelectedValue = Convert.ToInt32(grvDetail.CurrentRow.Cells["DanhMucID"].Value);

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
                NS_CONTRACT_EMPLOYEEKeys objNS_CONTRACT_EMPLOYEEKeys = new NS_CONTRACT_EMPLOYEEKeys(Convert.ToInt32(grvDetail.CurrentRow.Cells["NS_CONTRACT_EMPLOYEEID"].Value));
                gFactor.Delete(objNS_CONTRACT_EMPLOYEEKeys);
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
                txtTenHopDong.Clear();
                txtSoHopDong.Clear();
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

            NS_DMFIXFactory _DanhMucFactor = new NS_DMFIXFactory();
            dvDanhMuc = new DataView(_DanhMucFactor.GetAllBy(NS_DMFIX.NS_DMFIXFields.Type, "HĐ"));
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
                           int v = Convert.ToInt32(txtHopDongID.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtHopDongID","Loi nhap lieu")
                           txtHopDongID.Focus();
                       }
               */
                /*  if (txtManhanvien.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtManhanvien","Loi nhap lieu")
                         txtManhanvien.Focus();
                         return false;
                      } 
                  */
                /*  if (txtTenHopDong.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtTenHopDong","Loi nhap lieu")
                         txtTenHopDong.Focus();
                         return false;
                      } 
                  */
                /*  if (txtSoHopDong.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtSoHopDong","Loi nhap lieu")
                         txtSoHopDong.Focus();
                         return false;
                      } 
                  */
                /*  if (txtDanhMucID.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtDanhMucID","Loi nhap lieu")
                         txtDanhMucID.Focus();
                         return false;
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
        private NS_CONTRACT_EMPLOYEE SetValue()
        {
            NS_CONTRACT_EMPLOYEE NS_CONTRACT_EMPLOYEESetValue = new NS_CONTRACT_EMPLOYEE();
            try
            {
                NS_CONTRACT_EMPLOYEESetValue.HopDongID = indexID;
                NS_CONTRACT_EMPLOYEESetValue.Manhanvien = gEmployee.Manhanvien;
                NS_CONTRACT_EMPLOYEESetValue.TenHopDong = txtTenHopDong.Text;
                NS_CONTRACT_EMPLOYEESetValue.SoHopDong = txtSoHopDong.Text;
                if (cboDanhMuc.SelectedValue != null)
                    NS_CONTRACT_EMPLOYEESetValue.DanhMucID = cboDanhMuc.SelectedValue.ToString();
                else
                    NS_CONTRACT_EMPLOYEESetValue.DanhMucID = "0";
                NS_CONTRACT_EMPLOYEESetValue.NguoiTao = txtNguoiTao.Text;
                NS_CONTRACT_EMPLOYEESetValue.NgayTao = dtpNgayTao.Value.Date;
                NS_CONTRACT_EMPLOYEESetValue.NguoiSua = txtNguoiSua.Text;
                NS_CONTRACT_EMPLOYEESetValue.NgaySua = dtpNgaySua.Value.Date;
            }
            catch (Exception ex)
            {
                App.ShowError(ex);
            }
            return NS_CONTRACT_EMPLOYEESetValue;
        }
        #endregion
        private void controls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.SelectNextControl((Control)sender, true, true, true, true);
        }

    }
}

