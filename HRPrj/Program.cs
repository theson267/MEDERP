using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization.Formatters.Binary;
using BugReport;
namespace HRPrj
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
    class App
    {
        public static int UserID;
        public static string cnstring;
        public static string UserName;
        public static string Password;
        public static string IntervalDayForWillExpiredContract;
        public static string LevelSecondmentLoadForTreeViewHRM;
        public static string TitleMessage = "KPI-MEDLATEC";
        public static Boolean RememberPassword;
        public enum EmployeeListStatus { AllEmployee = 1, ActiveEmployee, QuitJobEmployee, NoContractEmployee, NoSecondmentEmployee, WillExpiredContractEmployee };
        public enum StsLabelSystemStatus { Create = 1, Active, Deactive, Dispose };

        //public static BinaryFormatter bf;
        public static void SaveBinaryData(string path, object o)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, o);
                fs.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if ((fs != null)) fs.Close();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="displaymember"></param>
        /// <param name="valuemember"></param>
        /// <param name="dv"></param>
        static internal void LoadCombo(ComboBox cb, string displaymember, string valuemember, DataView dv)
        {
            cb.DisplayMember = displaymember;
            cb.ValueMember = valuemember;
            cb.DataSource = dv;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static object LoadBinaryData(string path)
        {
            object functionReturnValue = null;
            try
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    lock (fs)
                    {
                        try
                        {

                            BinaryFormatter bf = new BinaryFormatter();
                            functionReturnValue = bf.Deserialize(fs);
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                        finally
                        {
                            if ((fs != null)) fs.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return functionReturnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="labelText"></param>
        /// <returns></returns>
        static internal string GetTextToFormatGrid(string labelText)
        {
            labelText.Trim();
            if (labelText.Length < 1) return labelText;
            return labelText.Substring(0, labelText.Length - 1);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        static internal void ShowError(Exception ex)
        {

            //if fantal error
            if (!(ex.TargetSite.Name == "Throw"))
            {

                ErrorReport f = new ErrorReport();
                //f.ErrorMessage = "Program error. " + Environment.NewLine + "Check the updated version of the program (Options-> Check the version update). " + Environment.NewLine + "If you have updated the latest version please press 'Submit' to send error information to us or 'Cancel' to refuse.";
                f.ErrorMessage = "Chương trình có lỗi!" + Environment.NewLine + Environment.NewLine + "Liên hệ với chúng tôi để được hỗ trợ" + Environment.NewLine + "Email: nguyentheson@medlatec.vn" + Environment.NewLine + "Tel: 4072";
                //f.ErrorMessage = "Chương trình có lỗi! " + Environment.NewLine + Environment.NewLine + "''"+ ex.Message + "''" + Environment.NewLine + ;
                f.ErrorStack = "==============Nôi dung==============" + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace.ToString();
                f.ErrorTitle = App.TitleMessage;
                f.ErrorImage = ErrorReport.MessageImage.Denied;
                f.ApplicationName = f.ProductName + " " + f.ProductVersion;
                f.ShowDialog();
            }
            else
            {
                //only standard error
                MessageBox.Show(ex.Message, App.TitleMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Kiểu hiển thị Form
        /// </summary>
        /// <param name="frmChild"></param>
        /// <param name="DockPanel"></param>
        /// <param name="showdialog"></param>
        public static void ShowObject(WeifenLuo.WinFormsUI.Docking.DockPanel DockPanel,
            bool showdialog,
            string formUrl,
            bool DLLex,
            string dllName
            )
        {
            try
            {
                Type type = Type.GetType(formUrl.Trim());
                object obj;
                if (DLLex == true)
                {
                    obj = Activator.CreateInstance(dllName, formUrl);
                }
                else
                {
                    obj = Activator.CreateInstance(type);
                }
                if (showdialog == true)
                {
                    (obj as Form).ShowDialog();
                }
                else
                {
                    ShowFormMD(obj as WeifenLuo.WinFormsUI.Docking.DockContent, DockPanel);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ShowObject::Error occured.", ex);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="frmChild"></param>
        /// <param name="DockPanel"></param>
        public static void ShowFormMD(WeifenLuo.WinFormsUI.Docking.DockContent frmChild, WeifenLuo.WinFormsUI.Docking.DockPanel DockPanel)
        {
            try
            {
                frmChild.TabText = frmChild.Text;
                frmChild.Activate();
                frmChild.Show(DockPanel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static int GetIso8601WeekOfYear(DateTime time)
        {
            //// Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            //// be the same week# as whatever Thursday, Friday or Saturday are,
            //// and we always get those right
            //DayOfWeek day = System.Globalization.CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            //if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            //{
            //    time = time.AddDays(3);
            //}

            //// Return the week of our adjusted day
            //return System.Globalization.CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return 0;
        }

        /// <summary>
        /// Loại kế hoạch
        /// </summary>
        enum TypePlan
        {
            DAY = 24,
            WEEK = 7,
            MONTH = 30,
            QUATER = 90,
            YEAR = 365
        }
    }
}
