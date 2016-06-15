using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace UMSys.BusinessLayer.DataLayer
{
	/// <summary>
	/// Data access layer class for NS_KPI_U_USER
	/// </summary>
	class NS_KPI_U_USERSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public NS_KPI_U_USERSql()
		{
			// Nothing for now.
		}

        #endregion

        #region Public Methods

        /// <summary>
        /// insert new row in the table
        /// </summary>
		/// <param name="businessObject">business object</param>
		/// <returns>true of successfully insert</returns>
		public bool Insert(NS_KPI_U_USER businessObject)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_USER_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, businessObject.UserID));
				sqlCommand.Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.UserName));
				sqlCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 30, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Password));
				sqlCommand.Parameters.Add(new SqlParameter("@FullName", SqlDbType.NVarChar, 150, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.FullName));
				sqlCommand.Parameters.Add(new SqlParameter("@Act", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Act));
				sqlCommand.Parameters.Add(new SqlParameter("@Note", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Note));

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.UserID = (int)sqlCommand.Parameters["@UserID"].Value;

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("NS_KPI_U_USER::Insert::Error occured.", ex);
			}
			finally
			{			
				MainConnection.Close();
				sqlCommand.Dispose();
			}
		}
        //HaDaiCa
        public bool Insert(NS_KPI_U_USER businessObject,SqlConnection cnn,SqlTransaction trans)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_USER_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = cnn;

			try
			{
                
				sqlCommand.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, businessObject.UserID));
				sqlCommand.Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.UserName));
				sqlCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 30, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Password));
				sqlCommand.Parameters.Add(new SqlParameter("@FullName", SqlDbType.NVarChar, 150, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.FullName));
				sqlCommand.Parameters.Add(new SqlParameter("@Act", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Act));
				sqlCommand.Parameters.Add(new SqlParameter("@Note", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Note));

								
				
				sqlCommand.Transaction = trans;
				sqlCommand.ExecuteNonQuery();
                businessObject.UserID = (int)sqlCommand.Parameters["@UserID"].Value;

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("NS_KPI_U_USER::Insert::Error occured.", ex);
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
        public bool Update(NS_KPI_U_USER businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_USER_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.UserID));
				sqlCommand.Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.UserName));
				sqlCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 30, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Password));
				sqlCommand.Parameters.Add(new SqlParameter("@FullName", SqlDbType.NVarChar, 150, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.FullName));
				sqlCommand.Parameters.Add(new SqlParameter("@Act", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Act));
				sqlCommand.Parameters.Add(new SqlParameter("@Note", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Note));

                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("NS_KPI_U_USER::Update::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }
        }
//HaDaiCa
        public bool Update(NS_KPI_U_USER businessObject,SqlConnection cnn,SqlTransaction trans)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_USER_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = cnn;

            try
            {
                
				sqlCommand.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.UserID));
				sqlCommand.Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.UserName));
				sqlCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 30, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Password));
				sqlCommand.Parameters.Add(new SqlParameter("@FullName", SqlDbType.NVarChar, 150, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.FullName));
				sqlCommand.Parameters.Add(new SqlParameter("@Act", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Act));
				sqlCommand.Parameters.Add(new SqlParameter("@Note", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Note));

                
                
                sqlCommand.Transaction = trans;
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("NS_KPI_U_USER::Update::Error occured.", ex);
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
        /// <returns>NS_KPI_U_USER business object</returns>
        public NS_KPI_U_USER SelectByPrimaryKey(NS_KPI_U_USERKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_USER_SelectByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keys.UserID));

                
                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    NS_KPI_U_USER businessObject = new NS_KPI_U_USER();

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
                throw new Exception("NS_KPI_U_USER::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of NS_KPI_U_USER</returns>
        public List<NS_KPI_U_USER> SelectAllForList()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_USER_SelectAll]";
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
                throw new Exception("NS_KPI_U_USER::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_USER_SelectAll]";
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
                throw new Exception("NS_KPI_U_USER::SelectAll::Error occured.", ex);
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
        /// <returns>list of NS_KPI_U_USER</returns>
        public List<NS_KPI_U_USER> SelectByFieldForList(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_USER_SelectByField]";
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
                throw new Exception("NS_KPI_U_USER::SelectByField::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_USER_SelectByField]";
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
                throw new Exception("NS_KPI_U_USER::SelectByField::Error occured.", ex);
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
                throw new Exception("NS_KPI_U_USER::SelectByField::Error occured.", ex);
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
                throw new Exception("NS_KPI_U_USER::SelectByField::Error occured.", ex);
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
                throw new Exception("NS_KPI_U_USER::SelectByField::Error occured.", ex);
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
                throw new Exception("NS_KPI_U_USER::SelectByField::Error occured.", ex);
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
        public bool Delete(NS_KPI_U_USERKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_USER_DeleteByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keys.UserID));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("NS_KPI_U_USER::DeleteByKey::Error occured.", ex);
            }
            finally
            {                
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }
//HaDaiCa
        public bool Delete(NS_KPI_U_USERKeys keys,SqlConnection cnn,SqlTransaction trans)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_USER_DeleteByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = cnn;
            sqlCommand.Transaction = trans;

            try
            {

				sqlCommand.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keys.UserID));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("NS_KPI_U_USER::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_USER_DeleteByField]";
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
                throw new Exception("NS_KPI_U_USER::DeleteByField::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_USER_DeleteByField]";
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
                throw new Exception("NS_KPI_U_USER::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(NS_KPI_U_USER businessObject, IDataReader dataReader)
        {


				businessObject.UserID = dataReader.GetInt32(dataReader.GetOrdinal(NS_KPI_U_USER.NS_KPI_U_USERFields.UserID.ToString()));

				businessObject.UserName = dataReader.GetString(dataReader.GetOrdinal(NS_KPI_U_USER.NS_KPI_U_USERFields.UserName.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NS_KPI_U_USER.NS_KPI_U_USERFields.Password.ToString())))
				{
					businessObject.Password = dataReader.GetString(dataReader.GetOrdinal(NS_KPI_U_USER.NS_KPI_U_USERFields.Password.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NS_KPI_U_USER.NS_KPI_U_USERFields.FullName.ToString())))
				{
					businessObject.FullName = dataReader.GetString(dataReader.GetOrdinal(NS_KPI_U_USER.NS_KPI_U_USERFields.FullName.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NS_KPI_U_USER.NS_KPI_U_USERFields.Act.ToString())))
				{
					businessObject.Act = dataReader.GetBoolean(dataReader.GetOrdinal(NS_KPI_U_USER.NS_KPI_U_USERFields.Act.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NS_KPI_U_USER.NS_KPI_U_USERFields.Note.ToString())))
				{
					businessObject.Note = dataReader.GetString(dataReader.GetOrdinal(NS_KPI_U_USER.NS_KPI_U_USERFields.Note.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of NS_KPI_U_USER</returns>
        internal List<NS_KPI_U_USER> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<NS_KPI_U_USER> list = new List<NS_KPI_U_USER>();

            while (dataReader.Read())
            {
                NS_KPI_U_USER businessObject = new NS_KPI_U_USER();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }
        public NS_KPI_U_USER AuthenticateUser(String UserName, String Password)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPS_NS_KPI_U_User_SelectBy_UserName_Password]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, UserName));
                sqlCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 30, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, Password));
                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    NS_KPI_U_USER businessObject = new NS_KPI_U_USER();

                    PopulateBusinessObjectFromReader(businessObject, dataReader);

                    return businessObject;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                //throw new Exception("Tbl_U_User::AuthenticateUser::Error occured.", ex);
                return null;
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        #endregion

    }
}
