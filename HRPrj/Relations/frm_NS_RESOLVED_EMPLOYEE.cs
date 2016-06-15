
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KPIPrj.BusinessLayer;
using System.IO;
/*
' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Modify by: SONNT										
' Description: SONNT									
' Date Created: 6/10/2016								
' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
*/
namespace HRPrj.Relations
{
    public partial class frm_NS_RESOLVED_EMPLOYEE : HRPrj.Baseform.frmBaseDirectory
    {
        public frm_NS_RESOLVED_EMPLOYEE()
        {
            InitializeComponent();
        }
        int indexID;
        NS_RESOLVED_EMPLOYEEFactory gFactor = new NS_RESOLVED_EMPLOYEEFactory();
        NS_RESOLVED_EMPLOYEE gNS_RESOLVED_EMPLOYEE = new NS_RESOLVED_EMPLOYEE();
        DataView dvDonVi = new DataView();
        DataView dvPhongBan = new DataView();
        DataView dvLoaiQuyetDinh = new DataView();
        #region override
        public override void RefreshList()
        {
            try
            {
                ClearControl();
                dtMain = gFactor.GetAllBy(NS_RESOLVED_EMPLOYEE.NS_RESOLVED_EMPLOYEEFields.Manhanvien, gEmployee.Manhanvien);
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
                grvDetail.Columns["Maquyetdinh"].Visible = false;
                grvDetail.Columns["Maloai"].HeaderText = App.GetTextToFormatGrid(lblMaloai.Text);
                grvDetail.Columns["Manhanvien"].HeaderText = App.GetTextToFormatGrid(lblManhanvien.Text);
                grvDetail.Columns["Soquyetdinh"].HeaderText = App.GetTextToFormatGrid(lblSoquyetdinh.Text);
                grvDetail.Columns["Lydo"].HeaderText = App.GetTextToFormatGrid(lblLydo.Text);
                grvDetail.Columns["Ngay"].HeaderText = App.GetTextToFormatGrid(lblNgay.Text);
                grvDetail.Columns["Ghichu"].HeaderText = App.GetTextToFormatGrid(lblGhichu.Text);
                grvDetail.Columns["Tungay"].HeaderText = App.GetTextToFormatGrid(lblTungay.Text);
                grvDetail.Columns["Denngay"].HeaderText = App.GetTextToFormatGrid(lblDenngay.Text);
                grvDetail.Columns["Maphong"].HeaderText = App.GetTextToFormatGrid(lblMaphong.Text);
                grvDetail.Columns["Madv"].HeaderText = App.GetTextToFormatGrid(lblMadv.Text);
                grvDetail.Columns["mavitri"].HeaderText = App.GetTextToFormatGrid(lblmavitri.Text);
                grvDetail.Columns["Mucdatduoc"].HeaderText = App.GetTextToFormatGrid(lblMucdatduoc.Text);
                grvDetail.Columns["Mamuc"].HeaderText = App.GetTextToFormatGrid(lblMamuc.Text);
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
                indexID = (int)grvDetail.CurrentRow.Cells["Maquyetdinh"].Value;

                if (grvDetail.CurrentRow.Cells["Maloai"].Value != DBNull.Value) cboLoaiQuyetDinh.ValueMember = Convert.ToString(grvDetail.CurrentRow.Cells["Maloai"].Value);

                if (grvDetail.CurrentRow.Cells["Manhanvien"].Value != DBNull.Value) txtManhanvien.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Manhanvien"].Value);

                if (grvDetail.CurrentRow.Cells["Soquyetdinh"].Value != DBNull.Value) txtSoquyetdinh.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Soquyetdinh"].Value);

                if (grvDetail.CurrentRow.Cells["Lydo"].Value != DBNull.Value) txtLydo.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Lydo"].Value);

                if (grvDetail.CurrentRow.Cells["Ngay"].Value != DBNull.Value) dtpNgay.Value = Convert.ToDateTime(grvDetail.CurrentRow.Cells["Ngay"].Value);

                if (grvDetail.CurrentRow.Cells["Ghichu"].Value != DBNull.Value) txtGhichu.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Ghichu"].Value);

                if (grvDetail.CurrentRow.Cells["Tungay"].Value != DBNull.Value) dtpTungay.Value = Convert.ToDateTime(grvDetail.CurrentRow.Cells["Tungay"].Value);

                if (grvDetail.CurrentRow.Cells["Denngay"].Value != DBNull.Value) dtpDenngay.Value = Convert.ToDateTime(grvDetail.CurrentRow.Cells["Denngay"].Value);

                if (grvDetail.CurrentRow.Cells["Maphong"].Value != DBNull.Value) cboPhongBan.SelectedValue = Convert.ToString(grvDetail.CurrentRow.Cells["Maphong"].Value);

                if (grvDetail.CurrentRow.Cells["Madv"].Value != DBNull.Value) cboMaDonVi.SelectedValue = Convert.ToString(grvDetail.CurrentRow.Cells["Madv"].Value);

                if (grvDetail.CurrentRow.Cells["mavitri"].Value != DBNull.Value) txtmavitri.Text = Convert.ToString(grvDetail.CurrentRow.Cells["mavitri"].Value);

                if (grvDetail.CurrentRow.Cells["Mucdatduoc"].Value != DBNull.Value) txtMucdatduoc.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Mucdatduoc"].Value);

                if (grvDetail.CurrentRow.Cells["Mamuc"].Value != DBNull.Value) txtMamuc.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Mamuc"].Value);
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
                NS_RESOLVED_EMPLOYEEKeys objNS_RESOLVED_EMPLOYEEKeys = new NS_RESOLVED_EMPLOYEEKeys(Convert.ToInt32(grvDetail.CurrentRow.Cells["NS_RESOLVED_EMPLOYEEID"].Value));
                gFactor.Delete(objNS_RESOLVED_EMPLOYEEKeys);
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
                txtSoquyetdinh.Clear();
                txtLydo.Clear();
                dtpNgay.Value = DateTime.Now.Date;
                txtGhichu.Clear();
                dtpTungay.Value = DateTime.Now.Date;
                dtpDenngay.Value = DateTime.Now.Date;
                txtmavitri.Clear();
                txtMucdatduoc.Clear();
                txtMamuc.Clear();
            }
            catch (Exception ex)
            {
                App.ShowError(ex);
            }
            base.ClearControl();
        }
        public override void LoadCombobox()
        {
            NS_BranchOfficeFactory fbr = new NS_BranchOfficeFactory();
            dvDonVi = new DataView(fbr.GetAll());
            
            App.LoadCombo(cboMaDonVi, "tenchinhanh", "machinhanh", dvDonVi);

            NS_DepartmentFactory fdp = new NS_DepartmentFactory();
            dvPhongBan = new DataView(fdp.GetAll());
            App.LoadCombo(cboPhongBan, "tenphongban", "maphongban", dvPhongBan);

            NS_RESOLVED_TYPEFactory frt = new NS_RESOLVED_TYPEFactory();
            dvLoaiQuyetDinh = new DataView(frt.GetAll());
            App.LoadCombo(cboLoaiQuyetDinh, "tenloai", "maloai", dvLoaiQuyetDinh);
        }
        /* Kiem tra du lieu dau vao */
        public override bool isValid()
        {
            try
            {
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtMaquyetdinh.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtMaquyetdinh","Loi nhap lieu")
                           txtMaquyetdinh.Focus();
                       }
               */
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtMaloai.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtMaloai","Loi nhap lieu")
                           txtMaloai.Focus();
                       }
               */
                /*  if (txtManhanvien.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtManhanvien","Loi nhap lieu")
                         txtManhanvien.Focus();
                         return false;
                      } 
                  */
                /*  if (txtSoquyetdinh.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtSoquyetdinh","Loi nhap lieu")
                         txtSoquyetdinh.Focus();
                         return false;
                      } 
                  */
                /*  if (txtLydo.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtLydo","Loi nhap lieu")
                         txtLydo.Focus();
                         return false;
                      } 
                  */
                /*  if (txtGhichu.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtGhichu","Loi nhap lieu")
                         txtGhichu.Focus();
                         return false;
                      } 
                  */
                /*  if (txtMaphong.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtMaphong","Loi nhap lieu")
                         txtMaphong.Focus();
                         return false;
                      } 
                  */
                /*  if (txtMadv.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtMadv","Loi nhap lieu")
                         txtMadv.Focus();
                         return false;
                      } 
                  */
                /*  if (txtmavitri.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtmavitri","Loi nhap lieu")
                         txtmavitri.Focus();
                         return false;
                      } 
                  */
                /*  if (txtMucdatduoc.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtMucdatduoc","Loi nhap lieu")
                         txtMucdatduoc.Focus();
                         return false;
                      } 
                  */
                /*  if (txtMamuc.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtMamuc","Loi nhap lieu")
                         txtMamuc.Focus();
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
        private NS_RESOLVED_EMPLOYEE SetValue()
        {
            NS_RESOLVED_EMPLOYEE NS_RESOLVED_EMPLOYEESetValue = new NS_RESOLVED_EMPLOYEE();
            try
            {
                NS_RESOLVED_EMPLOYEESetValue.Maquyetdinh = indexID;
                NS_RESOLVED_EMPLOYEESetValue.Maloai = Convert.ToInt32(cboLoaiQuyetDinh.SelectedValue.ToString());
                NS_RESOLVED_EMPLOYEESetValue.Manhanvien = txtManhanvien.Text;
                NS_RESOLVED_EMPLOYEESetValue.Soquyetdinh = txtSoquyetdinh.Text;
                NS_RESOLVED_EMPLOYEESetValue.Lydo = txtLydo.Text;
                NS_RESOLVED_EMPLOYEESetValue.Ngay = dtpNgay.Value.Date;
                NS_RESOLVED_EMPLOYEESetValue.Ghichu = txtGhichu.Text;
                NS_RESOLVED_EMPLOYEESetValue.Tungay = dtpTungay.Value.Date;
                NS_RESOLVED_EMPLOYEESetValue.Denngay = dtpDenngay.Value.Date;
                NS_RESOLVED_EMPLOYEESetValue.Maphong = cboPhongBan.SelectedValue.ToString();
                NS_RESOLVED_EMPLOYEESetValue.Madv = cboMaDonVi.SelectedValue.ToString();
                NS_RESOLVED_EMPLOYEESetValue.Mavitri = txtmavitri.Text;
                NS_RESOLVED_EMPLOYEESetValue.Mucdatduoc = txtMucdatduoc.Text;
                NS_RESOLVED_EMPLOYEESetValue.Mamuc = txtMamuc.Text;
            }
            catch (Exception ex)
            {
                App.ShowError(ex);
            }
            return NS_RESOLVED_EMPLOYEESetValue;
        }
        #endregion
        private void controls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.SelectNextControl((Control)sender, true, true, true, true);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageLocation"></param>
        /// <returns></returns>
       
    }
}

