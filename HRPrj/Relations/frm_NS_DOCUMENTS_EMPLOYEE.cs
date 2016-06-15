
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KPIPrj.BusinessLayer;
using HRPrj;
using System.IO;
/*
' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Modify by: SONNT										
' Description: SONNT									
' Date Created: 6/9/2016								
' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
*/
namespace HRPrj.Relations
{
    public partial class frm_NS_DOCUMENTS_EMPLOYEE : HRPrj.Baseform.frmBaseDirectory
    {
        public frm_NS_DOCUMENTS_EMPLOYEE()
        {
            InitializeComponent();
            
        }
        int indexID;
        NS_DOCUMENTS_EMPLOYEEFactory gFactor = new NS_DOCUMENTS_EMPLOYEEFactory();
        NS_DOCUMENTS_EMPLOYEE gNS_DOCUMENTS_EMPLOYEE = new NS_DOCUMENTS_EMPLOYEE();
        DataView dvDocument = new DataView();

        #region override
        public override void RefreshList()
        {
            try
            {
                ClearControl();
                dtMain = gFactor.GetAllBy(NS_DOCUMENTS_EMPLOYEE.NS_DOCUMENTS_EMPLOYEEFields.Manhanvien, gEmployee.Manhanvien);
                this.lblTK.Text = "Tổng bản ghi:" + dtMain.Rows.Count.ToString();
                txtManhanvien.Text = gEmployee.Manhanvien;
            }
            catch (Exception ex)
            {
                App.ShowError(ex);
            }
            base.RefreshList();
        }
        public override void FormatGrid()
        {
            //try
            //{
                grvDetail.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
                grvDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grvDetail.Columns["ID"].Visible = false;
                grvDetail.Columns["Manhanvien"].HeaderText = App.GetTextToFormatGrid(lblManhanvien.Text);
                grvDetail.Columns["DocumentID"].Visible = false;
                //grvDetail.Columns["Document"].HeaderText = App.GetTextToFormatGrid(lblDocument.Text);
                grvDetail.Columns["TenTaiLieu"].HeaderText = App.GetTextToFormatGrid(lblTenTaiLieu.Text);
                grvDetail.Columns["NgayCap"].HeaderText = App.GetTextToFormatGrid(lblNgayCap.Text);
                grvDetail.Columns["Anh"].HeaderText = App.GetTextToFormatGrid(lblAnh.Text);
                grvDetail.Columns["NguoiTao"].HeaderText = App.GetTextToFormatGrid(lblNguoiTao.Text);
                grvDetail.Columns["NgayTao"].HeaderText = App.GetTextToFormatGrid(lblNgayTao.Text);
                grvDetail.Columns["NguoiCapNhat"].HeaderText = App.GetTextToFormatGrid(lblNguoiCapNhat.Text);
                grvDetail.Columns["NgayCapNhat"].HeaderText = App.GetTextToFormatGrid(lblNgayCapNhat.Text);
                grvDetail.Columns["TinhTrang"].HeaderText = App.GetTextToFormatGrid(lblTinhTrang.Text);
                grvDetail.Columns["GhiChu"].HeaderText = App.GetTextToFormatGrid(lblGhiChu.Text);
            //}
            //catch (Exception ex)
            //{
            //    App.ShowError(ex);
            //}
            base.FormatGrid();
        }
        public override void SelectRecord()
        {
            try
            {
                indexID = (int)grvDetail.CurrentRow.Cells["ID"].Value;

                if (grvDetail.CurrentRow.Cells["Manhanvien"].Value != DBNull.Value) txtManhanvien.Text = Convert.ToString(grvDetail.CurrentRow.Cells["Manhanvien"].Value);
                if (grvDetail.CurrentRow.Cells["DocumentID"].Value != DBNull.Value) cboDocument.SelectedValue = Convert.ToInt32(grvDetail.CurrentRow.Cells["DocumentID"].Value);
                if (grvDetail.CurrentRow.Cells["TenTaiLieu"].Value != DBNull.Value) txtTenTaiLieu.Text = Convert.ToString(grvDetail.CurrentRow.Cells["TenTaiLieu"].Value);
                if (grvDetail.CurrentRow.Cells["NgayCap"].Value != DBNull.Value) dtpNgayCap.Value = Convert.ToDateTime(grvDetail.CurrentRow.Cells["NgayCap"].Value);
                if (grvDetail.CurrentRow.Cells["NguoiTao"].Value != DBNull.Value) txtNguoiTao.Text = Convert.ToString(grvDetail.CurrentRow.Cells["NguoiTao"].Value);
                if (grvDetail.CurrentRow.Cells["NgayTao"].Value != DBNull.Value) dtpNgayTao.Value = Convert.ToDateTime(grvDetail.CurrentRow.Cells["NgayTao"].Value);
                if (grvDetail.CurrentRow.Cells["NguoiCapNhat"].Value != DBNull.Value) txtNguoiCapNhat.Text = Convert.ToString(grvDetail.CurrentRow.Cells["NguoiCapNhat"].Value);
                if (grvDetail.CurrentRow.Cells["NgayCapNhat"].Value != DBNull.Value) dtpNgayCapNhat.Value = Convert.ToDateTime(grvDetail.CurrentRow.Cells["NgayCapNhat"].Value);
                if (grvDetail.CurrentRow.Cells["TinhTrang"].Value != DBNull.Value) txtTinhTrang.Text = Convert.ToString(grvDetail.CurrentRow.Cells["TinhTrang"].Value);
                if (grvDetail.CurrentRow.Cells["GhiChu"].Value != DBNull.Value) txtGhiChu.Text = Convert.ToString(grvDetail.CurrentRow.Cells["GhiChu"].Value);
                NS_DOCUMENTS_EMPLOYEEFactory f = new NS_DOCUMENTS_EMPLOYEEFactory();
                NS_DOCUMENTS_EMPLOYEE obj = f.GetByPrimaryKey(new NS_DOCUMENTS_EMPLOYEEKeys(indexID));
                picAnh.Image = ByteArrayToImage(obj.Anh);
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
                NS_DOCUMENTS_EMPLOYEEKeys objNS_DOCUMENTS_EMPLOYEEKeys = new NS_DOCUMENTS_EMPLOYEEKeys(Convert.ToInt32(grvDetail.CurrentRow.Cells["NS_DOCUMENTS_EMPLOYEEID"].Value));
                gFactor.Delete(objNS_DOCUMENTS_EMPLOYEEKeys);
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
                txtTenTaiLieu.Clear();
                dtpNgayCap.Value = DateTime.Now.Date;

                txtNguoiTao.Clear();
                dtpNgayTao.Value = DateTime.Now.Date;
                txtNguoiCapNhat.Clear();
                dtpNgayCapNhat.Value = DateTime.Now.Date;
                txtTinhTrang.Clear();
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

            NS_DOCUMENTLISTFactory _DocumentFactor = new NS_DOCUMENTLISTFactory();
            dvDocument = new DataView(_DocumentFactor.GetAll());
            App.LoadCombo(cboDocument, "DocumentName", "DocumentID", dvDocument);
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
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtDocumentID.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtDocumentID","Loi nhap lieu")
                           txtDocumentID.Focus();
                       }
               */
                /*  if (txtTenTaiLieu.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtTenTaiLieu","Loi nhap lieu")
                         txtTenTaiLieu.Focus();
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
                /*  if (txtNguoiCapNhat.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtNguoiCapNhat","Loi nhap lieu")
                         txtNguoiCapNhat.Focus();
                         return false;
                      } 
                  */
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtTinhTrang.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtTinhTrang","Loi nhap lieu")
                           txtTinhTrang.Focus();
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
        private NS_DOCUMENTS_EMPLOYEE SetValue()
        {
            NS_DOCUMENTS_EMPLOYEE NS_DOCUMENTS_EMPLOYEESetValue = new NS_DOCUMENTS_EMPLOYEE();
            try
            {
                NS_DOCUMENTS_EMPLOYEESetValue.ID = indexID;
                NS_DOCUMENTS_EMPLOYEESetValue.Manhanvien = txtManhanvien.Text;
                if (cboDocument.SelectedValue != null)
                    NS_DOCUMENTS_EMPLOYEESetValue.DocumentID = Convert.ToInt32(cboDocument.SelectedValue);
                else
                    NS_DOCUMENTS_EMPLOYEESetValue.DocumentID = 0;
                NS_DOCUMENTS_EMPLOYEESetValue.TenTaiLieu = txtTenTaiLieu.Text;
                NS_DOCUMENTS_EMPLOYEESetValue.NgayCap = dtpNgayCap.Value.Date;
                NS_DOCUMENTS_EMPLOYEESetValue.Anh = imageToByteArray(picAnh.Image);
                NS_DOCUMENTS_EMPLOYEESetValue.NguoiTao = txtNguoiTao.Text;
                NS_DOCUMENTS_EMPLOYEESetValue.NgayTao = dtpNgayTao.Value.Date;
                NS_DOCUMENTS_EMPLOYEESetValue.NguoiCapNhat = txtNguoiCapNhat.Text;
                NS_DOCUMENTS_EMPLOYEESetValue.NgayCapNhat = dtpNgayCapNhat.Value.Date;
                NS_DOCUMENTS_EMPLOYEESetValue.TinhTrang = Convert.ToInt32(txtTinhTrang.Text);
                NS_DOCUMENTS_EMPLOYEESetValue.GhiChu = txtGhiChu.Text;
            }
            catch (Exception ex)
            {
                App.ShowError(ex);
            }
            return NS_DOCUMENTS_EMPLOYEESetValue;
        }
        #endregion
        private void controls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.SelectNextControl((Control)sender, true, true, true, true);
        }
        public override void AddNewRecord()
        {
            base.AddNewRecord();
            this.txtManhanvien.Text = gEmployee.Manhanvien;
            
        }
        private void lkChonAnh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                picAnh.ImageLocation = fdlg.FileName;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageLocation"></param>
        /// <returns></returns>
        public static byte[] ReadImageFile(string imageLocation)
        {
            byte[] imageData = null;
            FileInfo fileInfo = new FileInfo(imageLocation);
            long imageFileLength = fileInfo.Length;
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imageData = br.ReadBytes((int)imageFileLength);
            return imageData;
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public System.Drawing.Image ByteArrayToImage(byte[] bArray)
        {
            if (bArray == null)
                return null;

            System.Drawing.Image newImage;

            try
            {
                using (MemoryStream ms = new MemoryStream(bArray, 0, bArray.Length))
                {
                    ms.Write(bArray, 0, bArray.Length);
                    newImage = System.Drawing.Image.FromStream(ms, true);
                }
            }
            catch (Exception ex)
            {
                newImage = null;

                //Log an error here
            }

            return newImage;
        }
    }
}

