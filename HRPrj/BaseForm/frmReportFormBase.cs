using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRPrj.BaseForm
{
    public partial class frmReportFormBase : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public frmReportFormBase()
        {
            InitializeComponent();
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            loadReport();
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual void loadReport()
        {

        }
    }
}
