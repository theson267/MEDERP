
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KPIPrj.BusinessLayer;
using HRPrj;
/*
' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Modify by: SONNT										
' Description: SONNT									
' Date Created: 6/9/2016								
' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
*/
namespace HRPrj.Relations
{
    public partial class frm_NS_RELATION_DETAILS : HRPrj.Baseform.frmBaseDirectory
    {
        int indexID;
        NS_RELATION_DETAILSFactory gFactor = new NS_RELATION_DETAILSFactory();
        NS_RELATION_DETAILS gNS_RELATION_DETAILS = new NS_RELATION_DETAILS();

        public frm_NS_RELATION_DETAILS()
        {
            InitializeComponent();
        }

        #region override
        /// <summary>
        /// 
        /// </summary>
        public override void RefreshList()
        {
            try
            {
                ClearControl();
                dtMain = gFactor.GetAllBy(NS_RELATION_DETAILS.NS_RELATION_DETAILSFields.Manhanvien, gEmployee.Manhanvien);
                this.lblTK.Text = "Tổng bản ghi:" + dtMain.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                //App.ShowError(ex);
            }
            base.RefreshList();
        }
        /// <summary>
        /// 
        /// </summary>
        public override void FormatGrid()
        {
            try
            {
                grvDetail.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
                grvDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grvDetail.Columns["ID"].Visible = false;
                grvDetail.Columns["HoTen"].HeaderText = App.GetTextToFormatGrid(lblHoTen.Text);
                grvDetail.Columns["Ngaysinh"].HeaderText = App.GetTextToFormatGrid(lblNgaysinh.Text);
                grvDetail.Columns["Diachi"].HeaderText = App.GetTextToFormatGrid(lblDiachi.Text);
                grvDetail.Columns["Manghenghiep"].HeaderText = App.GetTextToFormatGrid(lblManghenghiep.Text);
                grvDetail.Columns["Dienthoai"].HeaderText = App.GetTextToFormatGrid(lblDienthoai.Text);
                grvDetail.Columns["Ghichu"].HeaderText = App.GetTextToFormatGrid(lblGhichu.Text);
                grvDetail.Columns["Manhanvien"].HeaderText = App.GetTextToFormatGrid(lblManhanvien.Text);
                grvDetail.Columns["Maquanhe"].HeaderText = App.GetTextToFormatGrid(lblMaquanhe.Text);
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

                if (grvDetail.CurrentRow.Cells["HoTen"].Value != DBNull.Value) txtHoTen.Text = Convert.ToString(grvDetail.CurrentRow.Cells["HoTen"].Value);

                if (grvDetail.CurrentRow.Cells["Ngaysinh"].Value != DBNull.Value) dtpNgaysinh.Value = Convert.ToDateTime(grvDetail.CurrentRow.Cells["Ngaysinh"].Value);

                if (grvDetail.CurrentRow.Cells["Diachi"].Value != DBNull.Value) txtDiachi.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Diachi"].Value);

                if (grvDetail.CurrentRow.Cells["Manghenghiep"].Value != DBNull.Value) txtManghenghiep.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Manghenghiep"].Value);

                if (grvDetail.CurrentRow.Cells["Dienthoai"].Value != DBNull.Value) txtDienthoai.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Dienthoai"].Value);

                if (grvDetail.CurrentRow.Cells["Ghichu"].Value != DBNull.Value) txtGhichu.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Ghichu"].Value);

                if (grvDetail.CurrentRow.Cells["Manhanvien"].Value != DBNull.Value) txtManhanvien.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Manhanvien"].Value);

                if (grvDetail.CurrentRow.Cells["Maquanhe"].Value != DBNull.Value) txtMaquanhe.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Maquanhe"].Value);
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
                NS_RELATION_DETAILSKeys objNS_RELATION_DETAILSKeys = new NS_RELATION_DETAILSKeys(Convert.ToInt32(grvDetail.CurrentRow.Cells["NS_RELATION_DETAILSID"].Value));
                gFactor.Delete(objNS_RELATION_DETAILSKeys);
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
                txtHoTen.Clear();
                dtpNgaysinh.Value = DateTime.Now.Date;
                txtDiachi.Clear();
                txtManghenghiep.Clear();
                txtDienthoai.Clear();
                txtGhichu.Clear();
                txtManhanvien.Clear();
                txtMaquanhe.Clear();
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
                /*  if (txtHoTen.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtHoTen","Loi nhap lieu")
                         txtHoTen.Focus();
                         return false;
                      } 
                  */
                /*  if (txtDiachi.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtDiachi","Loi nhap lieu")
                         txtDiachi.Focus();
                         return false;
                      } 
                  */
                /*  if (txtManghenghiep.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtManghenghiep","Loi nhap lieu")
                         txtManghenghiep.Focus();
                         return false;
                      } 
                  */
                /*  if (txtDienthoai.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtDienthoai","Loi nhap lieu")
                         txtDienthoai.Focus();
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
                           int v = Convert.ToInt32(txtMaquanhe.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtMaquanhe","Loi nhap lieu")
                           txtMaquanhe.Focus();
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
        private NS_RELATION_DETAILS SetValue()
        {
            NS_RELATION_DETAILS NS_RELATION_DETAILSSetValue = new NS_RELATION_DETAILS();
            try
            {
                NS_RELATION_DETAILSSetValue.ID = indexID;
                NS_RELATION_DETAILSSetValue.HoTen = txtHoTen.Text;
                NS_RELATION_DETAILSSetValue.Ngaysinh = dtpNgaysinh.Value.Date;
                NS_RELATION_DETAILSSetValue.Diachi = txtDiachi.Text;
                NS_RELATION_DETAILSSetValue.Manghenghiep = txtManghenghiep.Text;
                NS_RELATION_DETAILSSetValue.Dienthoai = txtDienthoai.Text;
                NS_RELATION_DETAILSSetValue.Ghichu = txtGhichu.Text;
                NS_RELATION_DETAILSSetValue.Manhanvien = txtManhanvien.Text;
                NS_RELATION_DETAILSSetValue.Maquanhe = Convert.ToInt32(txtMaquanhe.Text);
            }
            catch (Exception ex)
            {
                App.ShowError(ex);
            }
            return NS_RELATION_DETAILSSetValue;
        }
        #endregion
        private void controls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.SelectNextControl((Control)sender, true, true, true, true);
        }

    }
}

