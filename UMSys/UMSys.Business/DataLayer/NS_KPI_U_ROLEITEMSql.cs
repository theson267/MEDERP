using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace UMSys.BusinessLayer.DataLayer
{
	/// <summary>
	/// Data access layer class for NS_KPI_U_ROLEITEM
	/// </summary>
	class NS_KPI_U_ROLEITEMSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public NS_KPI_U_ROLEITEMSql()
		{
			// Nothing for now.
		}

        #endregion

        #region Public Methods
        public DataTable SelectByRole(int RoleID)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_Item_SelectByRole]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@RoleID", RoleID));

                MainConnection.Open();

                DataTable dtable = new DataTable();
                SqlDataAdapter myadapter = new SqlDataAdapter(sqlCommand);
                myadapter.Fill(dtable);
                return dtable;

            }
            catch (Exception ex)
            {
                throw new Exception("Tbl_U_Item::SelectByRole::Error occured.", ex);
            }
            finally
            {

                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }
        /// <summary>
        /// insert new row in the table
        /// </summary>
		/// <param name="businessObject">business object</param>
		/// <returns>true of successfully insert</returns>
		public bool Insert(NS_KPI_U_ROLEITEM businessObject)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ROLEITEM_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.Add(new SqlParameter("@ItemID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ItemID));
				sqlCommand.Parameters.Add(new SqlParameter("@RoleID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.RoleID));
				sqlCommand.Parameters.Add(new SqlParameter("@IsReadonly", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsReadonly));
				sqlCommand.Parameters.Add(new SqlParameter("@IsFullControl", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsFullControl));

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                
				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("NS_KPI_U_ROLEITEM::Insert::Error occured.", ex);
			}
			finally
			{			
				MainConnection.Close();
				sqlCommand.Dispose();
			}
		}
        //HaDaiCa
        public bool Insert(NS_KPI_U_ROLEITEM businessObject,SqlConnection cnn,SqlTransaction trans)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ROLEITEM_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = cnn;

			try
			{
                
				sqlCommand.Parameters.Add(new SqlParameter("@ItemID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ItemID));
				sqlCommand.Parameters.Add(new SqlParameter("@RoleID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.RoleID));
				sqlCommand.Parameters.Add(new SqlParameter("@IsReadonly", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsReadonly));
				sqlCommand.Parameters.Add(new SqlParameter("@IsFullControl", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsFullControl));

								
				
				sqlCommand.Transaction = trans;
				sqlCommand.ExecuteNonQuery();
                
				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("NS_KPI_U_ROLEITEM::Insert::Error occured.", ex);
			}
			finally
			{			
				sqlCommand.Dispose();
			}
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(NS_KPI_U_ROLEITEM businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ROLEITEM_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.Add(new SqlParameter("@ItemID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ItemID));
				sqlCommand.Parameters.Add(new SqlParameter("@RoleID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.RoleID));
				sqlCommand.Parameters.Add(new SqlParameter("@IsReadonly", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsReadonly));
				sqlCommand.Parameters.Add(new SqlParameter("@IsFullControl", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsFullControl));

                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("NS_KPI_U_ROLEITEM::Update::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }
        }
//HaDaiCa
        public bool Update(NS_KPI_U_ROLEITEM businessObject,SqlConnection cnn,SqlTransaction trans)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ROLEITEM_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = cnn;

            try
            {
                
				sqlCommand.Parameters.Add(new SqlParameter("@ItemID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ItemID));
				sqlCommand.Parameters.Add(new SqlParameter("@RoleID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.RoleID));
				sqlCommand.Parameters.Add(new SqlParameter("@IsReadonly", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsReadonly));
				sqlCommand.Parameters.Add(new SqlParameter("@IsFullControl", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsFullControl));

                
                
                sqlCommand.Transaction = trans;
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("NS_KPI_U_ROLEITEM::Update::Error occured.", ex);
            }
            finally
            {
                sqlCommand.Dispose();
            }
        }
        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>NS_KPI_U_ROLEITEM business object</returns>
        public NS_KPI_U_ROLEITEM SelectByPrimaryKey(NS_KPI_U_ROLEITEMKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ROLEITEM_SelectByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new SqlParameter("@ItemID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keys.ItemID));
				sqlCommand.Parameters.Add(new SqlParameter("@RoleID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keys.RoleID));

                
                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    NS_KPI_U_ROLEITEM businessObject = new NS_KPI_U_ROLEITEM();

                    PopulateBusinessObjectFromReader(businessObject, dataReader);

                    return businessObject;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("NS_KPI_U_ROLEITEM::SelectByPrimaryKey::Error occured.", ex);
            }
            finally
            {             
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of NS_KPI_U_ROLEITEM</returns>
        public List<NS_KPI_U_ROLEITEM> SelectAllForList()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ROLEITEM_SelectAll]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectsFromReader(dataReader);

            }
            catch (Exception ex)
            {                
                throw new Exception("NS_KPI_U_ROLEITEM::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }
        
        /// <summary>
        /// Select All record
        /// </summary>
        /// <param name="fieldName">name of field</param>
        /// <param name="value">value of field</param>
        /// <returns>DataTable</returns>
        public DataTable SelectAll()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ROLEITEM_SelectAll]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
                MainConnection.Open();

                DataTable dtable = new DataTable();
                SqlDataAdapter myadapter = new SqlDataAdapter(sqlCommand);
                myadapter.Fill(dtable);
                return dtable;

            }
            catch (Exception ex)
            {                
                throw new Exception("NS_KPI_U_ROLEITEM::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Select records by field
        /// </summary>
        /// <param name="fieldName">name of field</param>
        /// <param name="value">value of field</param>
        /// <returns>list of NS_KPI_U_ROLEITEM</returns>
        public List<NS_KPI_U_ROLEITEM> SelectByFieldForList(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ROLEITEM_SelectByField]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@FieldName", fieldName));
                sqlCommand.Parameters.Add(new SqlParameter("@Value", value));

                MainConnection.Open();
                
                IDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectsFromReader(dataReader);

            }
            catch (Exception ex)
            {
                throw new Exception("NS_KPI_U_ROLEITEM::SelectByField::Error occured.", ex);
            }
            finally
            {

                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Select records by field
        /// </summary>
        /// <param name="fieldName">name of field</param>
        /// <param name="value">value of field</param>
        /// <returns>DataTable</returns>
        public DataTable SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ROLEITEM_SelectByField]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@FieldName", fieldName));
                sqlCommand.Parameters.Add(new SqlParameter("@Value", value));

                MainConnection.Open();

                DataTable dtable = new DataTable();
                SqlDataAdapter myadapter = new SqlDataAdapter(sqlCommand);
                myadapter.Fill(dtable);
                return dtable;

            }
            catch (Exception ex)
            {
                throw new Exception("NS_KPI_U_ROLEITEM::SelectByField::Error occured.", ex);
            }
            finally
            {

                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }
        public DataTable Execute(string spName, SqlParameter[] myPara)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText =spName;
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.AddRange(myPara);
                

                MainConnection.Open();

                DataTable dtable = new DataTable();
                SqlDataAdapter myadapter = new SqlDataAdapter(sqlCommand);
                myadapter.Fill(dtable);
                return dtable;

            }
            catch (Exception ex)
            {
                throw new Exception("NS_KPI_U_ROLEITEM::SelectByField::Error occured.", ex);
            }
            finally
            {

                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }
        public DataTable Execute(string strSQL)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText =strSQL;
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                
                

                MainConnection.Open();

                DataTable dtable = new DataTable();
                SqlDataAdapter myadapter = new SqlDataAdapter(sqlCommand);
                myadapter.Fill(dtable);
                return dtable;

            }
            catch (Exception ex)
            {
                throw new Exception("NS_KPI_U_ROLEITEM::SelectByField::Error occured.", ex);
            }
            finally
            {

                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }
public bool ExecuteNonQuery(string spName, SqlParameter[] myPara)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText =spName;
            sqlCommand.CommandType = CommandType.Text;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.AddRange(myPara);
                

                MainConnection.Open();

                return(sqlCommand.ExecuteNonQuery()>0);
                

            }
            catch (Exception ex)
            {
                throw new Exception("NS_KPI_U_ROLEITEM::SelectByField::Error occured.", ex);
            }
            finally
            {

                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }
public bool ExecuteNonQuery(string SQL)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText =SQL;
            sqlCommand.CommandType = CommandType.Text;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                MainConnection.Open();

                return(sqlCommand.ExecuteNonQuery()>0);
                

            }
            catch (Exception ex)
            {
                throw new Exception("NS_KPI_U_ROLEITEM::SelectByField::Error occured.", ex);
            }
            finally
            {

                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Delete by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(NS_KPI_U_ROLEITEMKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ROLEITEM_DeleteByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new SqlParameter("@ItemID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keys.ItemID));
				sqlCommand.Parameters.Add(new SqlParameter("@RoleID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keys.RoleID));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("NS_KPI_U_ROLEITEM::DeleteByKey::Error occured.", ex);
            }
            finally
            {                
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }
//HaDaiCa
        public bool Delete(NS_KPI_U_ROLEITEMKeys keys,SqlConnection cnn,SqlTransaction trans)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ROLEITEM_DeleteByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = cnn;
            sqlCommand.Transaction = trans;

            try
            {

				sqlCommand.Parameters.Add(new SqlParameter("@ItemID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keys.ItemID));
				sqlCommand.Parameters.Add(new SqlParameter("@RoleID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keys.RoleID));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("NS_KPI_U_ROLEITEM::DeleteByKey::Error occured.", ex);
            }
            finally
            {                
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Delete records by field
        /// </summary>
        /// <param name="fieldName">name of field</param>
        /// <param name="value">value of field</param>
        /// <returns>true for successfully deleted</returns>
        public bool DeleteByField(string fieldName, object value)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ROLEITEM_DeleteByField]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@FieldName", fieldName));
                sqlCommand.Parameters.Add(new SqlParameter("@Value", value));
                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {                
                throw new Exception("NS_KPI_U_ROLEITEM::DeleteByField::Error occured.", ex);
            }
            finally
            {             
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }
//HaDaiCa
        public bool DeleteByField(string fieldName, object value,SqlConnection cnn,SqlTransaction trans)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ROLEITEM_DeleteByField]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = cnn;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@FieldName", fieldName));
                sqlCommand.Parameters.Add(new SqlParameter("@Value", value));
                sqlCommand.Transaction = trans;
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {                
                throw new Exception("NS_KPI_U_ROLEITEM::DeleteByField::Error occured.", ex);
            }
            finally
            {             
                sqlCommand.Dispose();
            }

        }

        public SqlConnection MyConnection()
        {
            return MainConnection;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Populate business object from data reader
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <param name="dataReader">data reader</param>
        internal void PopulateBusinessObjectFromReader(NS_KPI_U_ROLEITEM businessObject, IDataReader dataReader)
        {


				businessObject.ItemID = dataReader.GetInt32(dataReader.GetOrdinal(NS_KPI_U_ROLEITEM.NS_KPI_U_ROLEITEMFields.ItemID.ToString()));

				businessObject.RoleID = dataReader.GetInt32(dataReader.GetOrdinal(NS_KPI_U_ROLEITEM.NS_KPI_U_ROLEITEMFields.RoleID.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NS_KPI_U_ROLEITEM.NS_KPI_U_ROLEITEMFields.IsReadonly.ToString())))
				{
					businessObject.IsReadonly = dataReader.GetBoolean(dataReader.GetOrdinal(NS_KPI_U_ROLEITEM.NS_KPI_U_ROLEITEMFields.IsReadonly.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NS_KPI_U_ROLEITEM.NS_KPI_U_ROLEITEMFields.IsFullControl.ToString())))
				{
					businessObject.IsFullControl = dataReader.GetBoolean(dataReader.GetOrdinal(NS_KPI_U_ROLEITEM.NS_KPI_U_ROLEITEMFields.IsFullControl.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of NS_KPI_U_ROLEITEM</returns>
        internal List<NS_KPI_U_ROLEITEM> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<NS_KPI_U_ROLEITEM> list = new List<NS_KPI_U_ROLEITEM>();

            while (dataReader.Read())
            {
                NS_KPI_U_ROLEITEM businessObject = new NS_KPI_U_ROLEITEM();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
