using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KPIPrj.BusinessLayer;
namespace KPIPrjReport
{
    public partial class frmReportMaster : Form
    {
        public frmReportMaster()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        private void addParrentNode()
        {
            TreeNode _orgNode = new TreeNode();
            _orgNode.Tag = "0";
            _orgNode.Name = "0";
            _orgNode.Text = "Danh sách báo cáo";
            this.tvMD.Nodes.Add(_orgNode);

            NS_KPI_U_ITEMFactory f = new NS_KPI_U_ITEMFactory();
            DataTable dt = f.GetAllBy(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.ParrentId, 0);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Type"].ToString() == "BCNS")
                    {
                        TreeNode tr = new TreeNode();
                        tr.Name = dt.Rows[i]["ItemID"].ToString();
                        tr.Text = dt.Rows[i]["Order"].ToString() + ". " + dt.Rows[i]["Item_Title"].ToString();
                        tr.Tag = dt.Rows[i]["Form_Namespace"].ToString() + "." + dt.Rows[i]["Alias"].ToString();
                        loadTree(tr);
                        _orgNode.Nodes.Add(tr);
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="trOrg"></param>
        private void loadTree(TreeNode trOrg)
        {
            NS_KPI_U_ITEMFactory f = new NS_KPI_U_ITEMFactory();
            DataTable dt = f.GetAllBy(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.ParrentId, int.Parse(trOrg.Name.ToString()));
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Type"].ToString().Trim() == "BCNS")
                    {
                        TreeNode tr = new TreeNode();
                        tr.Name = dt.Rows[i]["ItemID"].ToString();
                        tr.Text = dt.Rows[i]["Order"].ToString() + ". " + dt.Rows[i]["Item_Title"].ToString();
                        tr.Tag = dt.Rows[i]["Form_Namespace"].ToString() + "." + dt.Rows[i]["Alias"].ToString();
                        loadTree(tr);
                        trOrg.Nodes.Add(tr);
                    }
                }
                tvMD.Update();
            }
            tvMD.ExpandAll();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmReportMaster_Load(object sender, EventArgs e)
        {
            addParrentNode();
        }
    }
}
