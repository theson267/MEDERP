using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using UMSys.BusinessLayer.DataLayer;

namespace UMSys.BusinessLayer
{
    public class NS_KPI_U_USERROLEFactory
    {

        #region data Members

        NS_KPI_U_USERROLESql _dataObject = null;

        #endregion

        #region Constructor

        public NS_KPI_U_USERROLEFactory()
        {
            _dataObject = new NS_KPI_U_USERROLESql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new NS_KPI_U_USERROLE
        /// </summary>
        /// <param name="businessObject">NS_KPI_U_USERROLE object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(NS_KPI_U_USERROLE businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }
        public bool Insert(NS_KPI_U_USERROLE businessObject,SqlConnection cnn,SqlTransaction trans)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject,cnn,trans);

        }

        /// <summary>
        /// Update existing NS_KPI_U_USERROLE
        /// </summary>
        /// <param name="businessObject">NS_KPI_U_USERROLE object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(NS_KPI_U_USERROLE businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }
        public bool Update(NS_KPI_U_USERROLE businessObject,SqlConnection cnn,SqlTransaction trans)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject,cnn,trans);
        }

        /// <summary>
        /// get NS_KPI_U_USERROLE by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public NS_KPI_U_USERROLE GetByPrimaryKey(NS_KPI_U_USERROLEKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all NS_KPI_U_USERROLEs
        /// </summary>
        /// <returns>list</returns>
        public List<NS_KPI_U_USERROLE> GetAllForList()
        {
            return _dataObject.SelectAllForList(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of NS_KPI_U_USERROLE by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<NS_KPI_U_USERROLE> GetAllByForList(NS_KPI_U_USERROLE.NS_KPI_U_USERROLEFields fieldName, object value)
        {
            return _dataObject.SelectByFieldForList(fieldName.ToString(), value);  
        }
        public DataTable GetAllBy(NS_KPI_U_USERROLE.NS_KPI_U_USERROLEFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(NS_KPI_U_USERROLEKeys keys)
        {
            return _dataObject.Delete(keys); 
        }
        
        /// <summary>
        /// delete NS_KPI_U_USERROLE by field.
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

        public bool Delete(NS_KPI_U_USERROLEKeys keys,SqlConnection cnn,SqlTransaction trans)
        {
            return _dataObject.Delete(keys,cnn,trans); 
        }
        
        public bool Delete(NS_KPI_U_USERROLE.NS_KPI_U_USERROLEFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }
//HaDaiCa
        public bool Delete(NS_KPI_U_USERROLE.NS_KPI_U_USERROLEFields fieldName, object value,SqlConnection cnn,SqlTransaction trans)
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
