using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KPIPrj.BusinessLayer;
using System.Data.SqlClient;
using System.IO;

namespace HRPrj
{
    public delegate void DelegateChangeEmployee(NS_Employee currentEmployee);
    public delegate bool DelegateFuncEmployee(string FuntionName);
    public partial class frmMain : Form
    {
        public event DelegateChangeEmployee ChangeEmployee;
        public event DelegateFuncEmployee FuncEmployee;
        NS_Employee gEmployee = new NS_Employee();
        int indexID;
        NS_EmployeeFactory gFactor = new NS_EmployeeFactory();
        NS_Employee gNS_Employee = new NS_Employee();

        Relations.frm_NS_DOCUMENTS_EMPLOYEE _NS_DocumentEmployee = new Relations.frm_NS_DOCUMENTS_EMPLOYEE();
        Relations.frm_NS_RELATION_DETAILS _NS_Relations = new Relations.frm_NS_RELATION_DETAILS();
        Relations.frm_NS_RESOLVED_EMPLOYEE _NS_ResoledEmployee = new Relations.frm_NS_RESOLVED_EMPLOYEE();
        Relations.frm_NS_ALLOWANCE_EMPLOYEE _NS_Allowwance = new Relations.frm_NS_ALLOWANCE_EMPLOYEE();
        Relations.frm_NS_CONTRACT_EMPLOYEE _NS_Contract = new Relations.frm_NS_CONTRACT_EMPLOYEE();
        Relations.frm_NS_TRAININGCOURSE_EMPLOYEE _NS_Trainingcourse = new Relations.frm_NS_TRAININGCOURSE_EMPLOYEE();
        Relations.frm_NS_HEALTH_EMPLOYEE _NS_Health = new Relations.frm_NS_HEALTH_EMPLOYEE();
        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        private void loadEmployee(string filter)
        {
            NS_EmployeeFactory _fact = new NS_EmployeeFactory();
            string sql = "SELECT ID,manhanvien, hoten from NS_Employee ";
            if (filter.Trim().Length > 0)
                sql += filter;
            DataTable dt = _fact.Execute(sql, CommandType.Text);
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            loadEmployee("");
            LoadCombobox();
            loadTab();
            addDepartment();
        }
        /// <summary>
        /// 
        /// </summary>
        private void loadTab()
        {
            _NS_Relations.gEmployee = gEmployee;
            _NS_Relations.frmHRMMain = this;
            ShowFormInTab(_NS_Relations, tabRealation);

            _NS_DocumentEmployee.gEmployee = gEmployee;
            _NS_DocumentEmployee.frmHRMMain = this;
            ShowFormInTab(_NS_DocumentEmployee, tabVanBangChungChi);

            _NS_ResoledEmployee.gEmployee = gEmployee;
            _NS_ResoledEmployee.frmHRMMain = this;
            ShowFormInTab(_NS_ResoledEmployee, tabQuaTrinhCongTac);

            _NS_Allowwance.gEmployee = gEmployee;
            _NS_Allowwance.frmHRMMain = this;
            ShowFormInTab(_NS_Allowwance, tabPhuCap);

            _NS_Contract.gEmployee = gEmployee;
            _NS_Contract.frmHRMMain = this;
            ShowFormInTab(_NS_Contract, tabHopDongLaoDong);

            _NS_Trainingcourse.gEmployee = gEmployee;
            _NS_Trainingcourse.frmHRMMain = this;
            ShowFormInTab(_NS_Trainingcourse, tabQuaTrinhDaoTao);

            _NS_Health.gEmployee = gEmployee;
            _NS_Health.frmHRMMain = this;
            ShowFormInTab(_NS_Health, tabKiemTraSucKhoe);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            loadEmployee("where hoten like N'%" + txtHotenSearch.Text.Trim() + "%'");
        }
        #region Employee
        

        #region override
        /// <summary>
        /// 
        /// </summary>
        public void LoadCombobox()
        {
            NS_BranchOfficeFactory _factBrand = new NS_BranchOfficeFactory();
            List<NS_BranchOffice> _lstBrand = _factBrand.GetAllForList();
            cboDonVi.DataSource = _lstBrand;
            cboDonVi.ValueMember = "MACHINHANH";
            cboDonVi.DisplayMember = "TENCHINHANH";


            NS_DepartmentFactory _factDepartment = new NS_DepartmentFactory();
            List<NS_Department> _lstDepartment = _factDepartment.GetAllForList();
            cboKhoaPhong.DataSource = _lstDepartment;
            cboKhoaPhong.ValueMember = "Maphongban";
            cboKhoaPhong.DisplayMember = "Tenphongban";

            NS_LEVELFactory _factLevel = new NS_LEVELFactory();
            List<NS_LEVEL> _lstLevel = _factLevel.GetAllForList();
            cboTrinhDo.ValueMember = "Ma";
            cboTrinhDo.DisplayMember = "Ten";
            cboTrinhDo.DataSource = _lstLevel;

            NS_FOLKFactory _fackFolk = new NS_FOLKFactory();
            List<NS_FOLK> _lstfolk = _fackFolk.GetAllForList();
            cboDanToc.DataSource = _lstfolk;
            cboDanToc.ValueMember = "Ma";
            cboDanToc.DisplayMember = "Ten";

            NS_TITLEFactory _titlefact = new NS_TITLEFactory();
            List<NS_TITLE> _titlelst = _titlefact.GetAllForList();
            cboChucVu.DataSource = _titlelst;
            cboChucVu.ValueMember = "MACHUCDANH";
            cboChucVu.DisplayMember = "TENCHUCDANH";

            NS_JOBFOREMPLOYEEFactory _jobEmplooyeFact = new NS_JOBFOREMPLOYEEFactory();
            List<NS_JOBFOREMPLOYEE> _jobEmpLst = _jobEmplooyeFact.GetAllForList();
            cboChuyenMon.DataSource = _jobEmpLst;
            cboChuyenMon.ValueMember = "Manghenghiep";
            cboChuyenMon.DisplayMember = "Tennghenghiep";

            NS_NATIONFactory _nationFact = new NS_NATIONFactory();
            List<NS_NATION> _nationlst = _nationFact.GetAllForList();
            cboQuocTich.DataSource = _nationlst;
            cboQuocTich.ValueMember = "MaQG";
            cboQuocTich.DisplayMember = "TenQG";
   

            NS_RELIGIONFactory _religionfact = new NS_RELIGIONFactory();
            List<NS_RELIGION> _religionlst = _religionfact.GetAllForList();
            cboTonGiao.DataSource = _religionlst;
            cboTonGiao.ValueMember = "Ma";
            cboTonGiao.DisplayMember = "Ten";
            

            NS_ACADEMICFactory _academicfact1 = new NS_ACADEMICFactory();
            List<NS_ACADEMIC> _academiclst1 = _academicfact1.GetAllByForList(NS_ACADEMIC.NS_ACADEMICFields.Loai, 1);
            cboHocHam.DataSource = _academiclst1;
            cboHocHam.ValueMember = "Ma";
            cboHocHam.DisplayMember = "Ten";

            NS_ACADEMICFactory _academicfact2 = new NS_ACADEMICFactory();
            List<NS_ACADEMIC> _academiclst2 = _academicfact2.GetAllByForList(NS_ACADEMIC.NS_ACADEMICFields.Loai, 0);
            cboHocVi.DataSource = _academiclst2;
            cboHocVi.ValueMember = "Ma";
            cboHocVi.DisplayMember = "Ten";

            NS_POLICYFactory _policy = new NS_POLICYFactory();
            List<NS_POLICY> _policilst = new List<NS_POLICY>();
            cboPolicy.DataSource = _policilst;
            cboPolicy.ValueMember = "Ma";
            cboPolicy.DisplayMember = "Ten";
        }
        /* Kiem tra du lieu dau vao */
        public bool isValid()
        {
            try
            {
                /*  if (txtManhanvien.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtManhanvien","Loi nhap lieu")
                         txtManhanvien.Focus();
                         return false;
                      } 
                  */
                /*  if (txtHoten.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtHoten","Loi nhap lieu")
                         txtHoten.Focus();
                         return false;
                      } 
                  */
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtGioitinh.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtGioitinh","Loi nhap lieu")
                           txtGioitinh.Focus();
                       }
               */
                /*  if (txtDienthoai.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtDienthoai","Loi nhap lieu")
                         txtDienthoai.Focus();
                         return false;
                      } 
                  */
                /*  if (txtDienthoainha.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtDienthoainha","Loi nhap lieu")
                         txtDienthoainha.Focus();
                         return false;
                      } 
                  */
                /*  if (txtEmail.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtEmail","Loi nhap lieu")
                         txtEmail.Focus();
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
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtTrinhdo.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtTrinhdo","Loi nhap lieu")
                           txtTrinhdo.Focus();
                       }
               */
                /*  if (txtChucvu.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtChucvu","Loi nhap lieu")
                         txtChucvu.Focus();
                         return false;
                      } 
                  */
                /*  if (txtHocham.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtHocham","Loi nhap lieu")
                         txtHocham.Focus();
                         return false;
                      } 
                  */
                /*  if (txtHocvi.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtHocvi","Loi nhap lieu")
                         txtHocvi.Focus();
                         return false;
                      } 
                  */
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtThuviec_thoigian.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtThuviec_thoigian","Loi nhap lieu")
                           txtThuviec_thoigian.Focus();
                       }
               */
                /*  if (txtThuviec_So.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtThuviec_So","Loi nhap lieu")
                         txtThuviec_So.Focus();
                         return false;
                      } 
                  */
                /*  if (txtChinhthuc_So.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtChinhthuc_So","Loi nhap lieu")
                         txtChinhthuc_So.Focus();
                         return false;
                      } 
                  */
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtChinhthuc_thoigian.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtChinhthuc_thoigian","Loi nhap lieu")
                           txtChinhthuc_thoigian.Focus();
                       }
               */
                /*  if (txtThoiviec_So.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtThoiviec_So","Loi nhap lieu")
                         txtThoiviec_So.Focus();
                         return false;
                      } 
                  */
                /*  if (txtLydothoi.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtLydothoi","Loi nhap lieu")
                         txtLydothoi.Focus();
                         return false;
                      } 
                  */
                /*  if (txtNghihuu_so.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtNghihuu_so","Loi nhap lieu")
                         txtNghihuu_so.Focus();
                         return false;
                      } 
                  */
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtHonnhan.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtHonnhan","Loi nhap lieu")
                           txtHonnhan.Focus();
                       }
               */
                /*  if (txtNoisinh.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtNoisinh","Loi nhap lieu")
                         txtNoisinh.Focus();
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
                /*  if (txtQuequan.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtQuequan","Loi nhap lieu")
                         txtQuequan.Focus();
                         return false;
                      } 
                  */
                /*  if (txtCMTND.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtCMTND","Loi nhap lieu")
                         txtCMTND.Focus();
                         return false;
                      } 
                  */
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtcmtnd_noicap.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtcmtnd_noicap","Loi nhap lieu")
                           txtcmtnd_noicap.Focus();
                       }
               */
                /*  if (txtHochieu.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtHochieu","Loi nhap lieu")
                         txtHochieu.Focus();
                         return false;
                      } 
                  */
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtHochieu_noicap.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtHochieu_noicap","Loi nhap lieu")
                           txtHochieu_noicap.Focus();
                       }
               */
                /*  if (txtSoBH.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtSoBH","Loi nhap lieu")
                         txtSoBH.Focus();
                         return false;
                      } 
                  */
                /*  if (txtQuoctich.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtQuoctich","Loi nhap lieu")
                         txtQuoctich.Focus();
                         return false;
                      } 
                  */
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtDantoc.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtDantoc","Loi nhap lieu")
                           txtDantoc.Focus();
                       }
               */
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtTongiao.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtTongiao","Loi nhap lieu")
                           txtTongiao.Focus();
                       }
               */
                /*  if (txtLilich.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtLilich","Loi nhap lieu")
                         txtLilich.Focus();
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
                /*  if (txtChungchi.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtChungchi","Loi nhap lieu")
                         txtChungchi.Focus();
                         return false;
                      } 
                  */
                /*  if (txtSotaikhoan.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtSotaikhoan","Loi nhap lieu")
                         txtSotaikhoan.Focus();
                         return false;
                      } 
                  */
                /*  if (txtNganhang.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtNganhang","Loi nhap lieu")
                         txtNganhang.Focus();
                         return false;
                      } 
                  */
                /*  if (txtMasothue.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtMasothue","Loi nhap lieu")
                         txtMasothue.Focus();
                         return false;
                      } 
                  */
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtChamcong.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtChamcong","Loi nhap lieu")
                           txtChamcong.Focus();
                       }
               */
                /*  if (txtHokhau.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtHokhau","Loi nhap lieu")
                         txtHokhau.Focus();
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
                /*  if (txtChinhsach.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtChinhsach","Loi nhap lieu")
                         txtChinhsach.Focus();
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
                /*  if (txtNoidaotao.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtNoidaotao","Loi nhap lieu")
                         txtNoidaotao.Focus();
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
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtenrollNumber.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtenrollNumber","Loi nhap lieu")
                           txtenrollNumber.Focus();
                       }
               */
                /*  
                   try
                       {
                           int v = Convert.ToInt32(txtMahoso.Text == "");
                           return true;
                       }
                   catch
                       {
                           return false;
                           MessageBox.Show("Vui long nhap txtMahoso","Loi nhap lieu")
                           txtMahoso.Focus();
                       }
               */
                /*  if (txtGhichuThuviec.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtGhichuThuviec","Loi nhap lieu")
                         txtGhichuThuviec.Focus();
                         return false;
                      } 
                  */
                /*  if (txtGhichuVanphong.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtGhichuVanphong","Loi nhap lieu")
                         txtGhichuVanphong.Focus();
                         return false;
                      } 
                  */
                /*  if (txtTaiKhoan.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtTaiKhoan","Loi nhap lieu")
                         txtTaiKhoan.Focus();
                         return false;
                      } 
                  */
                /*  if (txtMatKhau.Text == "")
                      {
                         MessageBox.Show("Vui long nhap txtMatKhau","Loi nhap lieu")
                         txtMatKhau.Focus();
                         return false;
                      } 
                  */
            }
            catch (Exception ex)
            {
                //App.ShowError(ex);
            }
            return true;
        }
        #endregion
        #region Function
        private NS_Employee SetValue()
        {
           NS_Employee NS_EmployeeSetValue = new NS_Employee();
            //try
            //{
            //    //NS_EmployeeSetValue.ID = txtID.Text;
            //    // NS_EmployeeSetValue.ManhanviID = indexID;
            //    NS_EmployeeSetValue.Hoten = txtHoten.Text;
            //    NS_EmployeeSetValue.Namsinh = dtpNamsinh.Value.Date;
            //    if (radNam.Checked)
            //        NS_EmployeeSetValue.Gioitinh = 1;
            //    else if (radNu.Checked)
            //        NS_EmployeeSetValue.Gioitinh = 0;
            //    else
            //        NS_EmployeeSetValue.Gioitinh = 2;
            //    NS_EmployeeSetValue.Dienthoai = txtDienthoai.Text;
            //    NS_EmployeeSetValue.Dienthoainha = txtDienthoainha.Text;
            //    NS_EmployeeSetValue.Email = txtEmail.Text;
            //    NS_EmployeeSetValue.Maphong = txtMaphong.Text;
            //    NS_EmployeeSetValue.Trinhdo = Convert.ToInt32(txtTrinhdo.Text);
            //    NS_EmployeeSetValue.Chucvu = txtChucvu.Text;
            //    NS_EmployeeSetValue.Hocham = txtHocham.Text;
            //    NS_EmployeeSetValue.Hocvi = txtHocvi.Text;
            //    NS_EmployeeSetValue.Ngaythuviec = dtpNgaythuviec.Value.Date;
            //    NS_EmployeeSetValue.Thuviec_thoigian = Convert.ToInt32(txtThuviec_thoigian.Text);
            //    NS_EmployeeSetValue.Thuviec_So = txtThuviec_So.Text;
            //    NS_EmployeeSetValue.NgayChinhthuc = dtpNgayChinhthuc.Value.Date;
            //    NS_EmployeeSetValue.Chinhthuc_So = txtChinhthuc_So.Text;
            //    NS_EmployeeSetValue.Chinhthuc_thoigian = Convert.ToInt32(txtChinhthuc_thoigian.Text);
            //    NS_EmployeeSetValue.Ngaythoiviec = dtpNgaythoiviec.Value.Date;
            //    NS_EmployeeSetValue.Thoiviec_So = txtThoiviec_So.Text;
            //    NS_EmployeeSetValue.Lydothoi = txtLydothoi.Text;
            //    NS_EmployeeSetValue.Thoiviec = chkThoiviec.Checked;
            //    NS_EmployeeSetValue.Fulltime = chkFulltime.Checked;
            //    NS_EmployeeSetValue.Nvchinh = chkNvchinh.Checked;
            //    NS_EmployeeSetValue.Nghihuu_Ngay = dtpNghihuu_Ngay.Value.Date;
            //    NS_EmployeeSetValue.Nghihuu_so = txtNghihuu_so.Text;
            //    NS_EmployeeSetValue.Nghihuu = chkNghihuu.Checked;
            //    NS_EmployeeSetValue.Honnhan = Convert.ToInt32(txtHonnhan.Text);
            //    NS_EmployeeSetValue.Noisinh = txtNoisinh.Text;
            //    NS_EmployeeSetValue.Diachi = txtDiachi.Text;
            //    NS_EmployeeSetValue.Quequan = txtQuequan.Text;
            //    NS_EmployeeSetValue.CMTND = txtCMTND.Text;
            //    //NS_EmployeeSetValue.cmtnd_ngaycap = dtpcmtnd_ngaycap.Value.Date;
            //    //NS_EmployeeSetValue.cmtnd_noicap = Convert.ToInt32(txtcmtnd_noicap.Text);
            //    NS_EmployeeSetValue.Hochieu = txtHochieu.Text;
            //    NS_EmployeeSetValue.Hochieu_ngaycap = dtpHochieu_ngaycap.Value.Date;
            //    NS_EmployeeSetValue.Hochieu_noicap = Convert.ToInt32(txtHochieu_noicap.Text);
            //    NS_EmployeeSetValue.SoBH = txtSoBH.Text;
            //    NS_EmployeeSetValue.SoBH_Ngay = dtpSoBH_Ngay.Value.Date;
            //    NS_EmployeeSetValue.Doanvien = chkDoanvien.Checked;
            //    NS_EmployeeSetValue.DoanNgaykn = dtpDoanNgaykn.Value.Date;
            //    NS_EmployeeSetValue.Dangvien = chkDangvien.Checked;
            //    NS_EmployeeSetValue.DangNgaykn = dtpDangNgaykn.Value.Date;
            //    NS_EmployeeSetValue.DangNgayct = dtpDangNgayct.Value.Date;
            //    NS_EmployeeSetValue.Quoctich = txtQuoctich.Text;
            //    NS_EmployeeSetValue.Dantoc = Convert.ToInt32(txtDantoc.Text);
            //    NS_EmployeeSetValue.Tongiao = Convert.ToInt32(txtTongiao.Text);
            //    NS_EmployeeSetValue.Lilich = txtLilich.Text;
            //    // NS_EmployeeSetValue.Anh = Convert.ToDecimal( ptbAnh);
            //    //if (chkAnh.Checked)
            //    //    NS_EmployeeSetValue.Anh = 1;
            //    //else
            //    //    NS_EmployeeSetValue.Anh = 0;
            //    NS_EmployeeSetValue.Ghichu = txtGhichu.Text;
            //    NS_EmployeeSetValue.Chungchi = txtChungchi.Text;
            //    NS_EmployeeSetValue.Damat = chkDamat.Checked;
            //    NS_EmployeeSetValue.Ngaymat = dtpNgaymat.Value.Date;
            //    NS_EmployeeSetValue.Sotaikhoan = txtSotaikhoan.Text;
            //    NS_EmployeeSetValue.Nganhang = txtNganhang.Text;
            //    NS_EmployeeSetValue.Masothue = txtMasothue.Text;
            //    NS_EmployeeSetValue.Chamcong = Convert.ToInt32(txtChamcong.Text);
            //    //NS_EmployeeSetValue.Tiencongngay = txtTiencongngay.Text;
            //    NS_EmployeeSetValue.Hokhau = txtHokhau.Text;
            //    NS_EmployeeSetValue.Thuviec = chkThuviec.Checked;
            //    NS_EmployeeSetValue.Madv = txtMadv.Text;
            //    NS_EmployeeSetValue.Chinhsach = txtChinhsach.Text;
            //    NS_EmployeeSetValue.Manghenghiep = txtManghenghiep.Text;
            //    NS_EmployeeSetValue.CBchuchot = chkCBchuchot.Checked;
            //    NS_EmployeeSetValue.Noidaotao = txtNoidaotao.Text;
            //    NS_EmployeeSetValue.Ngaybonhiem = dtpNgaybonhiem.Value.Date;
            //    // NS_EmployeeSetValue.ngayvaoct = dtpngayvaoct.Value.Date;
            //    NS_EmployeeSetValue.DaiHan = chkDaiHan.Checked;
            //    NS_EmployeeSetValue.ThoiGian = Convert.ToInt32(txtThoiGian.Text);
            //    // NS_EmployeeSetValue.enrollNumber = Convert.ToInt32(txtenrollNumber.Text);
            //    NS_EmployeeSetValue.Mahoso = Convert.ToInt32(txtMahoso.Text);
            //    NS_EmployeeSetValue.GhichuThuviec = txtGhichuThuviec.Text;
            //    NS_EmployeeSetValue.GhichuVanphong = txtGhichuVanphong.Text;
            //    NS_EmployeeSetValue.TaiKhoan = txtTaiKhoan.Text;
            //    NS_EmployeeSetValue.MatKhau = txtMatKhau.Text;
            //    NS_EmployeeSetValue.CheckTN = chkCheckTN.Checked;
            //    NS_EmployeeSetValue.CheckDG = chkCheckDG.Checked;
            //    NS_EmployeeSetValue.NX = chkNX.Checked;
            //    NS_EmployeeSetValue.DGOnly = chkDGOnly.Checked;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            return NS_EmployeeSetValue;
        }
        #endregion
        private void controls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.SelectNextControl((Control)sender, true, true, true, true);
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void viewDetails(string manhanvien)
        {
            NS_EmployeeFactory _fact = new NS_EmployeeFactory();
            NS_Employee obj = _fact.GetByPrimaryKey(new NS_EmployeeKeys(manhanvien));
            ///
            this.txtMaNhanVien.Text = obj.Manhanvien;
            this.txtHotenSearch.Text = obj.Hoten;
            this.txtDiachi.Text = obj.Diachi;
            this.txtHokhau.Text = obj.Hokhau;
            this.txtCMTND.Text = obj.CMTND;
            this.txtChinhthuc_So.Text = obj.Chinhthuc_So;
            this.txtChungchi.Text = obj.Chungchi;
            this.txtDienthoai.Text = obj.Dienthoai;
            this.txtDienthoainha.Text = obj.Dienthoainha;
            this.txtEmail.Text = obj.Email;
            this.txtenrollNumber.Text = obj.EnrollNumber.ToString();
            this.txtGhichu.Text = obj.Ghichu;
            this.txtGhichuThuviec.Text = obj.GhichuThuviec;
            this.txtHochieu.Text = obj.Hochieu;
            this.txtLilich.Text = obj.Lilich;
            this.txtLydothoi.Text = obj.Lydothoi;
            this.txtMasothue.Text = obj.Masothue;
            this.txtNganhang.Text = obj.Nganhang;
            this.txtNghihuu_so.Text = obj.Nghihuu_so;
            this.txtNoidaotao.Text = obj.Noidaotao;
            this.txtNoisinh.Text = obj.Noisinh;
            this.txtQuequan.Text = obj.Quequan;
            this.txtSoBH.Text = obj.SoBH;
            this.txtSotaikhoan.Text = obj.Sotaikhoan;
            this.txtThoiviec_So.Text = obj.Thoiviec_So;
            this.txtThuviec_So.Text = obj.Thuviec_So;
            this.txtThuviec_thoigian.Text = obj.Thuviec_thoigian.ToString();

            if(obj.Cmtnd_ngaycap.HasValue) this.dtpcmtnd_ngaycap.Value = obj.Cmtnd_ngaycap.Value;
            if(obj.DangNgaykn.HasValue) this.dtpDangNgaykn.Value = obj.DangNgaykn.Value;
            if(obj.DangNgayct.HasValue) this.dtpDangNgayct.Value = obj.DangNgayct.Value;
            if(obj.DoanNgaykn.HasValue) this.dtpDoanNgaykn.Value = obj.DoanNgaykn.Value;
            if(obj.Hochieu_ngaycap.HasValue) this.dtpHochieu_ngaycap.Value = obj.Hochieu_ngaycap.Value;
            if(obj.Namsinh.HasValue) this.dtpNamsinh.Value = obj.Namsinh.Value;
            if(obj.Ngaybonhiem.HasValue) this.dtpNgaybonhiem.Value = obj.Ngaybonhiem.Value;
            if(obj.NgayChinhthuc.HasValue) this.dtpNgayChinhthuc.Value = obj.NgayChinhthuc.Value;
            if(obj.Ngaymat.HasValue) this.dtpNgaymat.Value = obj.Ngaymat.Value;
            if(obj.Ngaythoiviec.HasValue) this.dtpNgaythoiviec.Value = obj.Ngaythoiviec.Value;
            if(obj.Ngaythuviec.HasValue) this.dtpNgaythuviec.Value = obj.Ngaythuviec.Value;
            try
            {
                if (!obj.Ngayvaoct.HasValue) this.dtpngayvaoct.Value = obj.Ngayvaoct.Value;
            }
            catch { }
            
            if(!obj.Nghihuu_Ngay.HasValue) this.dtpNghihuu_Ngay.Value = obj.Nghihuu_Ngay.Value;
            if(!obj.SoBH_Ngay.HasValue) this.dtpSoBH_Ngay.Value = obj.SoBH_Ngay.Value;

            this.chkCBchuchot.Checked = obj.CBchuchot.Value;
            this.chkDaiHan.Checked = obj.DaiHan.Value;
            this.chkDamat.Checked = obj.Damat.Value;
            this.chkDangvien.Checked = obj.Dangvien.Value;
            this.chkDoanvien.Checked = obj.Doanvien.Value;
            this.chkFulltime.Checked = obj.Fulltime.Value;
            this.chkNghihuu.Checked = obj.Fulltime.Value;
            this.chkNvchinh.Checked = obj.Nvchinh.Value;
            this.chkThoiviec.Checked = obj.Thoiviec.Value;
            this.chkThuviec.Checked = obj.Thuviec.Value;

            this.picAnh.Image = ByteArrayToImage(obj.Anh);

            cboChucVu.SelectedValue = obj.Chucvu;
            cboChuyenMon.SelectedValue = obj.Manghenghiep;
            if(obj.Dantoc.HasValue) cboDanToc.SelectedValue = obj.Dantoc;
            cboDonVi.SelectedValue = obj.Madv;
            cboHocHam.SelectedValue = obj.Hocham;
            cboHocVi.SelectedValue = obj.Hocvi;
            cboKhoaPhong.SelectedValue = obj.Maphong;
            cboQuocTich.SelectedValue = obj.Quoctich;
            if(obj.Tongiao.HasValue) cboTonGiao.SelectedValue = obj.Tongiao;
            cboTrinhDo.SelectedValue = obj.Trinhdo;
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
        private void loadRelation(string manhanvien)
        {
            
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="frmTmp"></param>
        /// <param name="tabTmp"></param>
        private void ShowFormInTab(Form frmTmp, TabPage tabTmp)
        {
            frmTmp.TopLevel = false;
            frmTmp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmTmp.Dock = DockStyle.Fill;
            tabTmp.Controls.Add(frmTmp);
            frmTmp.Show();

        }
        public void SelectRecord()
        {
            try
            {
                if (dgvNhanVien.RowCount <= 0)
                {
                    gEmployee.ID = -1;
                    gEmployee.Manhanvien = "";
                    gEmployee.Hoten = "";
                    return;
                }
                gEmployee.ID = (long)dgvNhanVien.Rows[dgvNhanVien.CurrentRow.Index].Cells["ID"].Value;
                gEmployee.Manhanvien = dgvNhanVien.Rows[dgvNhanVien.CurrentRow.Index].Cells["Manhanvien"].Value.ToString();
                gEmployee.Hoten = dgvNhanVien.CurrentRow.Cells["Hoten"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SelectRecordTree()
        {
            try
            {
                if (dgvNhanVien.RowCount <= 0)
                {
                    gEmployee.ID = -1;
                    gEmployee.Manhanvien = "";
                    gEmployee.Hoten = "";
                    return;
                }
                //gEmployee.ID = (long)dgvNhanVien.Rows[dgvNhanVien.CurrentRow.Index].Cells["ID"].Value;
                gEmployee.Manhanvien = trvEmployee.SelectedNode.Tag.ToString();
                gEmployee.Hoten = trvEmployee.SelectedNode.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            viewDetails(dgvNhanVien.Rows[dgvNhanVien.CurrentRow.Index].Cells["Manhanvien"].Value.ToString());
            SelectRecord();
            if (ChangeEmployee != null)
            {
                ChangeEmployee(gEmployee);
                //tssLabel.Text = "Thônng tin nhân viên: " + gEmployee.EmployeeCode + " - " + gEmployee.FirstName + " " + gEmployee.Lastname;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        
        private void addDepartment()
        {

            TreeNode _orgNode = new TreeNode();
            _orgNode.Tag = "0";
            _orgNode.Name = "0";
            _orgNode.Text = "Khoa/Phòng";
            this.trvEmployee.Nodes.Add(_orgNode);

            NS_DepartmentFactory f = new NS_DepartmentFactory();
            DataTable dt = f.GetAll();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                   
                        TreeNode tr = new TreeNode();
                        tr.Name = dt.Rows[i]["Maphongban"].ToString();
                        tr.Text = dt.Rows[i]["TenPhongBan"].ToString();
                        tr.Tag = "Department";
                        _orgNode.Nodes.Add(tr);
                    
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="trOrg"></param>
        private void loadEmployee(TreeNode trOrg)
        {
            NS_EmployeeFactory f = new NS_EmployeeFactory();
            DataTable dt = f.GetAllBy(NS_Employee.NS_EmployeeFields.Maphong, trOrg.Name.ToString());
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    TreeNode tr = new TreeNode();
                    tr.Name = dt.Rows[i]["Manhanvien"].ToString();
                    tr.Text = dt.Rows[i]["Hoten"].ToString();
                    tr.Tag = dt.Rows[i]["Manhanvien"].ToString();
                    trOrg.Nodes.Add(tr);
                }
                trvEmployee.Update();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trvEmployee_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (trvEmployee.SelectedNode.Tag.ToString() == "Department" || trvEmployee.SelectedNode.Tag.ToString() == "0")
            {
                if (trvEmployee.SelectedNode.Nodes.Count == 0)
                    loadEmployee(trvEmployee.SelectedNode);
            }
            else
            {
                viewDetails(trvEmployee.SelectedNode.Tag.ToString());
                SelectRecordTree();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trvEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
