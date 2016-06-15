using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using UMSys.BusinessLayer.DataLayer;

namespace UMSys.BusinessLayer
{
    public class NS_KPI_U_ROLEITEMFactory
    {

        #region data Members

        NS_KPI_U_ROLEITEMSql _dataObject = null;

        #endregion

        #region Constructor

        public NS_KPI_U_ROLEITEMFactory()
        {
            _dataObject = new NS_KPI_U_ROLEITEMSql();
        }

        #endregion


        #region Public Methods
        public DataTable SelectByRole(int RoleID)
        {
            return _dataObject.SelectByRole(RoleID);
        }
        /// <summary>
        /// Insert new NS_KPI_U_ROLEITEM
        /// </summary>
        /// <param name="businessObject">NS_KPI_U_ROLEITEM object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(NS_KPI_U_ROLEITEM businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }
        public bool Insert(NS_KPI_U_ROLEITEM businessObject,SqlConnection cnn,SqlTransaction trans)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject,cnn,trans);

        }

        /// <summary>
        /// Update existing NS_KPI_U_ROLEITEM
        /// </summary>
        /// <param name="businessObject">NS_KPI_U_ROLEITEM object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(NS_KPI_U_ROLEITEM businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }
        public bool Update(NS_KPI_U_ROLEITEM businessObject,SqlConnection cnn,SqlTransaction trans)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject,cnn,trans);
        }

        /// <summary>
        /// get NS_KPI_U_ROLEITEM by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public NS_KPI_U_ROLEITEM GetByPrimaryKey(NS_KPI_U_ROLEITEMKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all NS_KPI_U_ROLEITEMs
        /// </summary>
        /// <returns>list</returns>
        public List<NS_KPI_U_ROLEITEM> GetAllForList()
        {
            return _dataObject.SelectAllForList(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of NS_KPI_U_ROLEITEM by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<NS_KPI_U_ROLEITEM> GetAllByForList(NS_KPI_U_ROLEITEM.NS_KPI_U_ROLEITEMFields fieldName, object value)
        {
            return _dataObject.SelectByFieldForList(fieldName.ToString(), value);  
        }
        public DataTable GetAllBy(NS_KPI_U_ROLEITEM.NS_KPI_U_ROLEITEMFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(NS_KPI_U_ROLEITEMKeys keys)
        {
            return _dataObject.Delete(keys); 
        }
        
        /// <summary>
        /// delete NS_KPI_U_ROLEITEM by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        //DaiCaHa
        public DataTable Execute(string spName,SqlParameter[] myPara)
        {
            return _dataObject.Execute(spName,myPara); 
        }
        public DataTable Execute(string strSQL)
        {
            return _dataObject.Execute(strSQL); 
        }
        public bool ExecuteNonQuery(string spName,SqlParameter[] myPara)
        {
            return _dataObject.ExecuteNonQuery(spName,myPara); 
        }
        public bool ExecuteNonQuery(string strSQL)
        {
            return _dataObject.ExecuteNonQuery(strSQL); 
        }

        public bool Delete(NS_KPI_U_ROLEITEMKeys keys,SqlConnection cnn,SqlTransaction trans)
        {
            return _dataObject.Delete(keys,cnn,trans); 
        }
        
        public bool Delete(NS_KPI_U_ROLEITEM.NS_KPI_U_ROLEITEMFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }
//HaDaiCa
        public bool Delete(NS_KPI_U_ROLEITEM.NS_KPI_U_ROLEITEMFields fieldName, object value,SqlConnection cnn,SqlTransaction trans)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value,cnn,trans); 
        }
        public SqlConnection MyConnection()
        {
            return _dataObject.MyConnection();
        }
        #endregion
    }
}
