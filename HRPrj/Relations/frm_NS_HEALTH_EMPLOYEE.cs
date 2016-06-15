
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
' Date Created: 6/11/2016								
' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
*/
namespace HRPrj.Relations
{
    public partial class frm_NS_HEALTH_EMPLOYEE : Baseform.frmBaseDirectory
    {
        public frm_NS_HEALTH_EMPLOYEE()
        {
            InitializeComponent();
        }
        int indexID;
        NS_HEALTH_EMPLOYEEFactory gFactor = new NS_HEALTH_EMPLOYEEFactory();
        NS_HEALTH_EMPLOYEE gNS_HEALTH_EMPLOYEE = new NS_HEALTH_EMPLOYEE();

        #region override
        public override void RefreshList()
        {
            try
            {
                ClearControl();
                dtMain = gFactor.GetAllBy(NS_HEALTH_EMPLOYEE.NS_HEALTH_EMPLOYEEFields.Manhanvien, gEmployee.Manhanvien);
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
                grvDetail.Columns["ID"].Visible = false;
                grvDetail.Columns["Manhanvien"].HeaderText = App.GetTextToFormatGrid(lblManhanvien.Text);
                grvDetail.Columns["Ngay"].HeaderText = App.GetTextToFormatGrid(lblNgay.Text);
                grvDetail.Columns["Chieucao"].HeaderText = App.GetTextToFormatGrid(lblChieucao.Text);
                grvDetail.Columns["Cannang"].HeaderText = App.GetTextToFormatGrid(lblCannang.Text);
                grvDetail.Columns["Vongnguc"].HeaderText = App.GetTextToFormatGrid(lblVongnguc.Text);
                grvDetail.Columns["Huyetap"].HeaderText = App.GetTextToFormatGrid(lblHuyetap.Text);
                grvDetail.Columns["Mach"].HeaderText = App.GetTextToFormatGrid(lblMach.Text);
                grvDetail.Columns["Nhiptho"].HeaderText = App.GetTextToFormatGrid(lblNhiptho.Text);
                grvDetail.Columns["Thiluc"].HeaderText = App.GetTextToFormatGrid(lblThiluc.Text);
                grvDetail.Columns["Chandoanhinhanh"].HeaderText = App.GetTextToFormatGrid(lblChandoanhinhanh.Text);
                grvDetail.Columns["Dientamdo"].HeaderText = App.GetTextToFormatGrid(lblDientamdo.Text);
                grvDetail.Columns["TaiMuiHong"].HeaderText = App.GetTextToFormatGrid(lblTaiMuiHong.Text);
                grvDetail.Columns["Dalieu"].HeaderText = App.GetTextToFormatGrid(lblDalieu.Text);
                grvDetail.Columns["Vandong"].HeaderText = App.GetTextToFormatGrid(lblVandong.Text);
                grvDetail.Columns["Noitiet"].HeaderText = App.GetTextToFormatGrid(lblNoitiet.Text);
                grvDetail.Columns["Tamthan"].HeaderText = App.GetTextToFormatGrid(lblTamthan.Text);
                grvDetail.Columns["Thankinh"].HeaderText = App.GetTextToFormatGrid(lblThankinh.Text);
                grvDetail.Columns["Tieuhoa"].HeaderText = App.GetTextToFormatGrid(lblTieuhoa.Text);
                grvDetail.Columns["Hohap"].HeaderText = App.GetTextToFormatGrid(lblHohap.Text);
                grvDetail.Columns["Tuanhoan"].HeaderText = App.GetTextToFormatGrid(lblTuanhoan.Text);
                grvDetail.Columns["Than_Tietnieu_Sinhduc"].HeaderText = App.GetTextToFormatGrid(lblThan_Tietnieu_Sinhduc.Text);
                grvDetail.Columns["Sanphukhoa"].HeaderText = App.GetTextToFormatGrid(lblSanphukhoa.Text);
                grvDetail.Columns["Ranghammat"].HeaderText = App.GetTextToFormatGrid(lblRanghammat.Text);
                grvDetail.Columns["XNnuoctieu"].HeaderText = App.GetTextToFormatGrid(lblXNnuoctieu.Text);
                grvDetail.Columns["XNmau"].HeaderText = App.GetTextToFormatGrid(lblXNmau.Text);
                grvDetail.Columns["Ketluan"].HeaderText = App.GetTextToFormatGrid(lblKetluan.Text);
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
                indexID = (int)grvDetail.CurrentRow.Cells["ID"].Value;

                if (grvDetail.CurrentRow.Cells["Manhanvien"].Value != DBNull.Value) txtManhanvien.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Manhanvien"].Value);

                if (grvDetail.CurrentRow.Cells["Ngay"].Value != DBNull.Value) dtpNgay.Value = Convert.ToDateTime(grvDetail.CurrentRow.Cells["Ngay"].Value);

                if (grvDetail.CurrentRow.Cells["Chieucao"].Value != DBNull.Value) txtChieucao.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Chieucao"].Value);

                if (grvDetail.CurrentRow.Cells["Cannang"].Value != DBNull.Value) txtCannang.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Cannang"].Value);

                if (grvDetail.CurrentRow.Cells["Vongnguc"].Value != DBNull.Value) txtVongnguc.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Vongnguc"].Value);

                if (grvDetail.CurrentRow.Cells["Huyetap"].Value != DBNull.Value) txtHuyetap.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Huyetap"].Value);

                if (grvDetail.CurrentRow.Cells["Mach"].Value != DBNull.Value) txtMach.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Mach"].Value);

                if (grvDetail.CurrentRow.Cells["Nhiptho"].Value != DBNull.Value) txtNhiptho.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Nhiptho"].Value);

                if (grvDetail.CurrentRow.Cells["Thiluc"].Value != DBNull.Value) txtThiluc.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Thiluc"].Value);

                if (grvDetail.CurrentRow.Cells["Chandoanhinhanh"].Value != DBNull.Value) txtChandoanhinhanh.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Chandoanhinhanh"].Value);

                if (grvDetail.CurrentRow.Cells["Dientamdo"].Value != DBNull.Value) txtDientamdo.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Dientamdo"].Value);

                if (grvDetail.CurrentRow.Cells["TaiMuiHong"].Value != DBNull.Value) txtTaiMuiHong.Text = Convert.ToString(grvDetail.CurrentRow.Cells["TaiMuiHong"].Value);

                if (grvDetail.CurrentRow.Cells["Dalieu"].Value != DBNull.Value) txtDalieu.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Dalieu"].Value);

                if (grvDetail.CurrentRow.Cells["Vandong"].Value != DBNull.Value) txtVandong.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Vandong"].Value);

                if (grvDetail.CurrentRow.Cells["Noitiet"].Value != DBNull.Value) txtNoitiet.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Noitiet"].Value);

                if (grvDetail.CurrentRow.Cells["Tamthan"].Value != DBNull.Value) txtTamthan.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Tamthan"].Value);

                if (grvDetail.CurrentRow.Cells["Thankinh"].Value != DBNull.Value) txtThankinh.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Thankinh"].Value);

                if (grvDetail.CurrentRow.Cells["Tieuhoa"].Value != DBNull.Value) txtTieuhoa.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Tieuhoa"].Value);

                if (grvDetail.CurrentRow.Cells["Hohap"].Value != DBNull.Value) txtHohap.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Hohap"].Value);

                if (grvDetail.CurrentRow.Cells["Tuanhoan"].Value != DBNull.Value) txtTuanhoan.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Tuanhoan"].Value);

                if (grvDetail.CurrentRow.Cells["Than_Tietnieu_Sinhduc"].Value != DBNull.Value) txtThan_Tietnieu_Sinhduc.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Than_Tietnieu_Sinhduc"].Value);

                if (grvDetail.CurrentRow.Cells["Sanphukhoa"].Value != DBNull.Value) txtSanphukhoa.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Sanphukhoa"].Value);

                if (grvDetail.CurrentRow.Cells["Ranghammat"].Value != DBNull.Value) txtRanghammat.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Ranghammat"].Value);

                if (grvDetail.CurrentRow.Cells["XNnuoctieu"].Value != DBNull.Value) txtXNnuoctieu.Text = Convert.ToString(grvDetail.CurrentRow.Cells["XNnuoctieu"].Value);

                if (grvDetail.CurrentRow.Cells["XNmau"].Value != DBNull.Value) txtXNmau.Text = Convert.ToString(grvDetail.CurrentRow.Cells["XNmau"].Value);

                if (grvDetail.CurrentRow.Cells["Ketluan"].Value != DBNull.Value) txtKetluan.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Ketluan"].Value);
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
                NS_HEALTH_EMPLOYEEKeys objNS_HEALTH_EMPLOYEEKeys = new NS_HEALTH_EMPLOYEEKeys(Convert.ToInt32(grvDetail.CurrentRow.Cells["NS_HEALTH_EMPLOYEEID"].Value));
                gFactor.Delete(objNS_HEALTH_EMPLOYEEKeys);
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
                dtpNgay.Value = DateTime.Now.Date;
                txtChieucao.Clear();
                txtCannang.Clear();
                txtVongnguc.Clear();
                txtHuyetap.Clear();
                txtMach.Clear();
                txtNhiptho.Clear();
                txtThiluc.Clear();
                txtChandoanhinhanh.Clear();
                txtDientamdo.Clear();
                txtTaiMuiHong.Clear();
                txtDalieu.Clear();
                txtVandong.Clear();
                txtNoitiet.Clear();
                txtTamthan.Clear();
                txtThankinh.Clear();
                txtTieuhoa.Clear();
                txtHohap.Clear();
                txtTuanhoan.Clear();
                txtThan_Tietnieu_Sinhduc.Clear();
                txtSanphukhoa.Clear();
                txtRanghammat.Clear();
                txtXNnuoctieu.Clear();
                txtXNmau.Clear();
                txtKetluan.Clear();
            }
            catch (Exception ex)
            {
                App.ShowError(ex);
            }
            base.ClearControl();
        }
        public override void LoadCombobox()
        {

        }
        /* Kiem tra du lieu dau vao */
        public override bool isValid()
        {
            try
            {
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtID.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtID","Loi nhap lieu")
                           txtID.Focus();
                       }
               */
                /*  if (txtManhanvien.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtManhanvien","Loi nhap lieu")
                         txtManhanvien.Focus();
                         return false;
                      } 
                  */
                /*  if (txtChieucao.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtChieucao","Loi nhap lieu")
                         txtChieucao.Focus();
                         return false;
                      } 
                  */
                /*  if (txtCannang.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtCannang","Loi nhap lieu")
                         txtCannang.Focus();
                         return false;
                      } 
                  */
                /*  if (txtVongnguc.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtVongnguc","Loi nhap lieu")
                         txtVongnguc.Focus();
                         return false;
                      } 
                  */
                /*  if (txtHuyetap.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtHuyetap","Loi nhap lieu")
                         txtHuyetap.Focus();
                         return false;
                      } 
                  */
                /*  if (txtMach.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtMach","Loi nhap lieu")
                         txtMach.Focus();
                         return false;
                      } 
                  */
                /*  if (txtNhiptho.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtNhiptho","Loi nhap lieu")
                         txtNhiptho.Focus();
                         return false;
                      } 
                  */
                /*  if (txtThiluc.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtThiluc","Loi nhap lieu")
                         txtThiluc.Focus();
                         return false;
                      } 
                  */
                /*  if (txtChandoanhinhanh.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtChandoanhinhanh","Loi nhap lieu")
                         txtChandoanhinhanh.Focus();
                         return false;
                      } 
                  */
                /*  if (txtDientamdo.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtDientamdo","Loi nhap lieu")
                         txtDientamdo.Focus();
                         return false;
                      } 
                  */
                /*  if (txtTaiMuiHong.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtTaiMuiHong","Loi nhap lieu")
                         txtTaiMuiHong.Focus();
                         return false;
                      } 
                  */
                /*  if (txtDalieu.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtDalieu","Loi nhap lieu")
                         txtDalieu.Focus();
                         return false;
                      } 
                  */
                /*  if (txtVandong.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtVandong","Loi nhap lieu")
                         txtVandong.Focus();
                         return false;
                      } 
                  */
                /*  if (txtNoitiet.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtNoitiet","Loi nhap lieu")
                         txtNoitiet.Focus();
                         return false;
                      } 
                  */
                /*  if (txtTamthan.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtTamthan","Loi nhap lieu")
                         txtTamthan.Focus();
                         return false;
                      } 
                  */
                /*  if (txtThankinh.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtThankinh","Loi nhap lieu")
                         txtThankinh.Focus();
                         return false;
                      } 
                  */
                /*  if (txtTieuhoa.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtTieuhoa","Loi nhap lieu")
                         txtTieuhoa.Focus();
                         return false;
                      } 
                  */
                /*  if (txtHohap.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtHohap","Loi nhap lieu")
                         txtHohap.Focus();
                         return false;
                      } 
                  */
                /*  if (txtTuanhoan.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtTuanhoan","Loi nhap lieu")
                         txtTuanhoan.Focus();
                         return false;
                      } 
                  */
                /*  if (txtThan_Tietnieu_Sinhduc.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtThan_Tietnieu_Sinhduc","Loi nhap lieu")
                         txtThan_Tietnieu_Sinhduc.Focus();
                         return false;
                      } 
                  */
                /*  if (txtSanphukhoa.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtSanphukhoa","Loi nhap lieu")
                         txtSanphukhoa.Focus();
                         return false;
                      } 
                  */
                /*  if (txtRanghammat.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtRanghammat","Loi nhap lieu")
                         txtRanghammat.Focus();
                         return false;
                      } 
                  */
                /*  if (txtXNnuoctieu.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtXNnuoctieu","Loi nhap lieu")
                         txtXNnuoctieu.Focus();
                         return false;
                      } 
                  */
                /*  if (txtXNmau.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtXNmau","Loi nhap lieu")
                         txtXNmau.Focus();
                         return false;
                      } 
                  */
                /*  if (txtKetluan.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtKetluan","Loi nhap lieu")
                         txtKetluan.Focus();
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
        private NS_HEALTH_EMPLOYEE SetValue()
        {
            NS_HEALTH_EMPLOYEE NS_HEALTH_EMPLOYEESetValue = new NS_HEALTH_EMPLOYEE();
            try
            {
                NS_HEALTH_EMPLOYEESetValue.ID = indexID;
                NS_HEALTH_EMPLOYEESetValue.Manhanvien = txtManhanvien.Text;
                NS_HEALTH_EMPLOYEESetValue.Ngay = dtpNgay.Value.Date;
                NS_HEALTH_EMPLOYEESetValue.Chieucao = txtChieucao.Text;
                NS_HEALTH_EMPLOYEESetValue.Cannang = txtCannang.Text;
                NS_HEALTH_EMPLOYEESetValue.Vongnguc = txtVongnguc.Text;
                NS_HEALTH_EMPLOYEESetValue.Huyetap = txtHuyetap.Text;
                NS_HEALTH_EMPLOYEESetValue.Mach = txtMach.Text;
                NS_HEALTH_EMPLOYEESetValue.Nhiptho = txtNhiptho.Text;
                NS_HEALTH_EMPLOYEESetValue.Thiluc = txtThiluc.Text;
                NS_HEALTH_EMPLOYEESetValue.Chandoanhinhanh = txtChandoanhinhanh.Text;
                NS_HEALTH_EMPLOYEESetValue.Dientamdo = txtDientamdo.Text;
                NS_HEALTH_EMPLOYEESetValue.TaiMuiHong = txtTaiMuiHong.Text;
                NS_HEALTH_EMPLOYEESetValue.Dalieu = txtDalieu.Text;
                NS_HEALTH_EMPLOYEESetValue.Vandong = txtVandong.Text;
                NS_HEALTH_EMPLOYEESetValue.Noitiet = txtNoitiet.Text;
                NS_HEALTH_EMPLOYEESetValue.Tamthan = txtTamthan.Text;
                NS_HEALTH_EMPLOYEESetValue.Thankinh = txtThankinh.Text;
                NS_HEALTH_EMPLOYEESetValue.Tieuhoa = txtTieuhoa.Text;
                NS_HEALTH_EMPLOYEESetValue.Hohap = txtHohap.Text;
                NS_HEALTH_EMPLOYEESetValue.Tuanhoan = txtTuanhoan.Text;
                NS_HEALTH_EMPLOYEESetValue.Than_Tietnieu_Sinhduc = txtThan_Tietnieu_Sinhduc.Text;
                NS_HEALTH_EMPLOYEESetValue.Sanphukhoa = txtSanphukhoa.Text;
                NS_HEALTH_EMPLOYEESetValue.Ranghammat = txtRanghammat.Text;
                NS_HEALTH_EMPLOYEESetValue.XNnuoctieu = txtXNnuoctieu.Text;
                NS_HEALTH_EMPLOYEESetValue.XNmau = txtXNmau.Text;
                NS_HEALTH_EMPLOYEESetValue.Ketluan = txtKetluan.Text;
            }
            catch (Exception ex)
            {
                App.ShowError(ex);
            }
            return NS_HEALTH_EMPLOYEESetValue;
        }
        #endregion
        private void controls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.SelectNextControl((Control)sender, true, true, true, true);
        }

    }
}

