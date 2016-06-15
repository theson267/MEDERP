using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace UMSys.BusinessLayer.DataLayer
{
	/// <summary>
	/// Data access layer class for NS_KPI_U_ITEM
	/// </summary>
	class NS_KPI_U_ITEMSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public NS_KPI_U_ITEMSql()
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
		public bool Insert(NS_KPI_U_ITEM businessObject)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ITEM_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.Add(new SqlParameter("@ItemID", SqlDbType.Int, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ItemID));
				sqlCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Name));
				sqlCommand.Parameters.Add(new SqlParameter("@Alias", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Alias));
				sqlCommand.Parameters.Add(new SqlParameter("@Item_Title", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Item_Title));
				sqlCommand.Parameters.Add(new SqlParameter("@Form_Namespace", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Form_Namespace));
				sqlCommand.Parameters.Add(new SqlParameter("@IsFunction", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsFunction));
				sqlCommand.Parameters.Add(new SqlParameter("@IsDialog", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsDialog));
				sqlCommand.Parameters.Add(new SqlParameter("@Activate", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Activate));
				sqlCommand.Parameters.Add(new SqlParameter("@ParrentId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ParrentId));
				sqlCommand.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Type));
				sqlCommand.Parameters.Add(new SqlParameter("@XML_File", SqlDbType.NVarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.XML_File));
				sqlCommand.Parameters.Add(new SqlParameter("@Note", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Note));
				sqlCommand.Parameters.Add(new SqlParameter("@Order", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Order));

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.ItemID = (int)sqlCommand.Parameters["@ItemID"].Value;

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("NS_KPI_U_ITEM::Insert::Error occured.", ex);
			}
			finally
			{			
				MainConnection.Close();
				sqlCommand.Dispose();
			}
		}
        //HaDaiCa
        public bool Insert(NS_KPI_U_ITEM businessObject,SqlConnection cnn,SqlTransaction trans)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ITEM_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = cnn;

			try
			{
                
				sqlCommand.Parameters.Add(new SqlParameter("@ItemID", SqlDbType.Int, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ItemID));
				sqlCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Name));
				sqlCommand.Parameters.Add(new SqlParameter("@Alias", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Alias));
				sqlCommand.Parameters.Add(new SqlParameter("@Item_Title", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Item_Title));
				sqlCommand.Parameters.Add(new SqlParameter("@Form_Namespace", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Form_Namespace));
				sqlCommand.Parameters.Add(new SqlParameter("@IsFunction", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsFunction));
				sqlCommand.Parameters.Add(new SqlParameter("@IsDialog", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsDialog));
				sqlCommand.Parameters.Add(new SqlParameter("@Activate", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Activate));
				sqlCommand.Parameters.Add(new SqlParameter("@ParrentId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ParrentId));
				sqlCommand.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Type));
				sqlCommand.Parameters.Add(new SqlParameter("@XML_File", SqlDbType.NVarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.XML_File));
				sqlCommand.Parameters.Add(new SqlParameter("@Note", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Note));
				sqlCommand.Parameters.Add(new SqlParameter("@Order", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Order));

								
				
				sqlCommand.Transaction = trans;
				sqlCommand.ExecuteNonQuery();
                businessObject.ItemID = (int)sqlCommand.Parameters["@ItemID"].Value;

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("NS_KPI_U_ITEM::Insert::Error occured.", ex);
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
        public bool Update(NS_KPI_U_ITEM businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ITEM_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.Add(new SqlParameter("@ItemID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ItemID));
				sqlCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Name));
				sqlCommand.Parameters.Add(new SqlParameter("@Alias", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Alias));
				sqlCommand.Parameters.Add(new SqlParameter("@Item_Title", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Item_Title));
				sqlCommand.Parameters.Add(new SqlParameter("@Form_Namespace", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Form_Namespace));
				sqlCommand.Parameters.Add(new SqlParameter("@IsFunction", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsFunction));
				sqlCommand.Parameters.Add(new SqlParameter("@IsDialog", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsDialog));
				sqlCommand.Parameters.Add(new SqlParameter("@Activate", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Activate));
				sqlCommand.Parameters.Add(new SqlParameter("@ParrentId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ParrentId));
				sqlCommand.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Type));
				sqlCommand.Parameters.Add(new SqlParameter("@XML_File", SqlDbType.NVarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.XML_File));
				sqlCommand.Parameters.Add(new SqlParameter("@Note", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Note));
				sqlCommand.Parameters.Add(new SqlParameter("@Order", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Order));

                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("NS_KPI_U_ITEM::Update::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }
        }
//HaDaiCa
        public bool Update(NS_KPI_U_ITEM businessObject,SqlConnection cnn,SqlTransaction trans)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ITEM_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = cnn;

            try
            {
                
				sqlCommand.Parameters.Add(new SqlParameter("@ItemID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ItemID));
				sqlCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Name));
				sqlCommand.Parameters.Add(new SqlParameter("@Alias", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Alias));
				sqlCommand.Parameters.Add(new SqlParameter("@Item_Title", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Item_Title));
				sqlCommand.Parameters.Add(new SqlParameter("@Form_Namespace", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Form_Namespace));
				sqlCommand.Parameters.Add(new SqlParameter("@IsFunction", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsFunction));
				sqlCommand.Parameters.Add(new SqlParameter("@IsDialog", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsDialog));
				sqlCommand.Parameters.Add(new SqlParameter("@Activate", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Activate));
				sqlCommand.Parameters.Add(new SqlParameter("@ParrentId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ParrentId));
				sqlCommand.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Type));
				sqlCommand.Parameters.Add(new SqlParameter("@XML_File", SqlDbType.NVarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.XML_File));
				sqlCommand.Parameters.Add(new SqlParameter("@Note", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Note));
				sqlCommand.Parameters.Add(new SqlParameter("@Order", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Order));

                
                
                sqlCommand.Transaction = trans;
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("NS_KPI_U_ITEM::Update::Error occured.", ex);
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
        /// <returns>NS_KPI_U_ITEM business object</returns>
        public NS_KPI_U_ITEM SelectByPrimaryKey(NS_KPI_U_ITEMKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ITEM_SelectByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new SqlParameter("@ItemID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keys.ItemID));

                
                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    NS_KPI_U_ITEM businessObject = new NS_KPI_U_ITEM();

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
                throw new Exception("NS_KPI_U_ITEM::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of NS_KPI_U_ITEM</returns>
        public List<NS_KPI_U_ITEM> SelectAllForList()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ITEM_SelectAll]";
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
                throw new Exception("NS_KPI_U_ITEM::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ITEM_SelectAll]";
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
                throw new Exception("NS_KPI_U_ITEM::SelectAll::Error occured.", ex);
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
        /// <returns>list of NS_KPI_U_ITEM</returns>
        public List<NS_KPI_U_ITEM> SelectByFieldForList(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ITEM_SelectByField]";
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
                throw new Exception("NS_KPI_U_ITEM::SelectByField::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ITEM_SelectByField]";
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
                throw new Exception("NS_KPI_U_ITEM::SelectByField::Error occured.", ex);
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
                throw new Exception("NS_KPI_U_ITEM::SelectByField::Error occured.", ex);
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
                throw new Exception("NS_KPI_U_ITEM::SelectByField::Error occured.", ex);
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
                throw new Exception("NS_KPI_U_ITEM::SelectByField::Error occured.", ex);
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
                throw new Exception("NS_KPI_U_ITEM::SelectByField::Error occured.", ex);
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
        public bool Delete(NS_KPI_U_ITEMKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ITEM_DeleteByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new SqlParameter("@ItemID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keys.ItemID));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("NS_KPI_U_ITEM::DeleteByKey::Error occured.", ex);
            }
            finally
            {                
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }
//HaDaiCa
        public bool Delete(NS_KPI_U_ITEMKeys keys,SqlConnection cnn,SqlTransaction trans)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ITEM_DeleteByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = cnn;
            sqlCommand.Transaction = trans;

            try
            {

				sqlCommand.Parameters.Add(new SqlParameter("@ItemID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keys.ItemID));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("NS_KPI_U_ITEM::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ITEM_DeleteByField]";
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
                throw new Exception("NS_KPI_U_ITEM::DeleteByField::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[KPI_NS_KPI_U_ITEM_DeleteByField]";
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
                throw new Exception("NS_KPI_U_ITEM::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(NS_KPI_U_ITEM businessObject, IDataReader dataReader)
        {


				businessObject.ItemID = dataReader.GetInt32(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.ItemID.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.Name.ToString())))
				{
					businessObject.Name = dataReader.GetString(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.Name.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.Alias.ToString())))
				{
					businessObject.Alias = dataReader.GetString(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.Alias.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.Item_Title.ToString())))
				{
					businessObject.Item_Title = dataReader.GetString(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.Item_Title.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.Form_Namespace.ToString())))
				{
					businessObject.Form_Namespace = dataReader.GetString(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.Form_Namespace.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.IsFunction.ToString())))
				{
					businessObject.IsFunction = dataReader.GetBoolean(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.IsFunction.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.IsDialog.ToString())))
				{
					businessObject.IsDialog = dataReader.GetBoolean(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.IsDialog.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.Activate.ToString())))
				{
					businessObject.Activate = dataReader.GetBoolean(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.Activate.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.ParrentId.ToString())))
				{
					businessObject.ParrentId = dataReader.GetInt32(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.ParrentId.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.Type.ToString())))
				{
					businessObject.Type = dataReader.GetString(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.Type.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.XML_File.ToString())))
				{
					businessObject.XML_File = dataReader.GetString(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.XML_File.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.Note.ToString())))
				{
					businessObject.Note = dataReader.GetString(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.Note.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.Order.ToString())))
				{
					businessObject.Order = dataReader.GetInt32(dataReader.GetOrdinal(NS_KPI_U_ITEM.NS_KPI_U_ITEMFields.Order.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of NS_KPI_U_ITEM</returns>
        internal List<NS_KPI_U_ITEM> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<NS_KPI_U_ITEM> list = new List<NS_KPI_U_ITEM>();

            while (dataReader.Read())
            {
                NS_KPI_U_ITEM businessObject = new NS_KPI_U_ITEM();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
