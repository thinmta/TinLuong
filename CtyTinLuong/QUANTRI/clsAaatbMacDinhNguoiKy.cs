using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace CtyTinLuong
{
	public partial class clsAaatbMacDinhNguoiKy : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlInt32		m_iID_DangNhap, m_iID;
			private SqlString		m_sChucVu, m_sHoTen;
		#endregion


		public clsAaatbMacDinhNguoiKy()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_aaatbMacDinhNguoiKy_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sChucVu", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sChucVu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sHoTen", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sHoTen));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_DangNhap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DangNhap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iID = (SqlInt32)scmCmdToExecute.Parameters["@iID"].Value;
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_aaatbMacDinhNguoiKy_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsAaatbMacDinhNguoiKy::Insert::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		public override bool Update()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_aaatbMacDinhNguoiKy_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sChucVu", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sChucVu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sHoTen", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sHoTen));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_DangNhap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DangNhap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_aaatbMacDinhNguoiKy_Update' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsAaatbMacDinhNguoiKy::Update::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		public override bool Delete()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_aaatbMacDinhNguoiKy_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_aaatbMacDinhNguoiKy_Delete' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsAaatbMacDinhNguoiKy::Delete::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_aaatbMacDinhNguoiKy_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("aaatbMacDinhNguoiKy");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_aaatbMacDinhNguoiKy_SelectOne' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_iID = (Int32)dtToReturn.Rows[0]["ID"];
					m_sChucVu = (string)dtToReturn.Rows[0]["ChucVu"];
					m_sHoTen = (string)dtToReturn.Rows[0]["HoTen"];
					m_iID_DangNhap = dtToReturn.Rows[0]["ID_DangNhap"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_DangNhap"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsAaatbMacDinhNguoiKy::SelectOne::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
				sdaAdapter.Dispose();
			}
		}


		public override DataTable SelectAll()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_aaatbMacDinhNguoiKy_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("aaatbMacDinhNguoiKy");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_aaatbMacDinhNguoiKy_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsAaatbMacDinhNguoiKy::SelectAll::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
				sdaAdapter.Dispose();
			}
		}


		#region Class Property Declarations
		public SqlInt32 iID
		{
			get
			{
				return m_iID;
			}
			set
			{
				SqlInt32 iIDTmp = (SqlInt32)value;
				if(iIDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID", "iID can't be NULL");
				}
				m_iID = value;
			}
		}


		public SqlString sChucVu
		{
			get
			{
				return m_sChucVu;
			}
			set
			{
				SqlString sChucVuTmp = (SqlString)value;
				if(sChucVuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sChucVu", "sChucVu can't be NULL");
				}
				m_sChucVu = value;
			}
		}


		public SqlString sHoTen
		{
			get
			{
				return m_sHoTen;
			}
			set
			{
				SqlString sHoTenTmp = (SqlString)value;
				if(sHoTenTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sHoTen", "sHoTen can't be NULL");
				}
				m_sHoTen = value;
			}
		}


		public SqlInt32 iID_DangNhap
		{
			get
			{
				return m_iID_DangNhap;
			}
			set
			{
				SqlInt32 iID_DangNhapTmp = (SqlInt32)value;
				if(iID_DangNhapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_DangNhap", "iID_DangNhap can't be NULL");
				}
				m_iID_DangNhap = value;
			}
		}
		#endregion
	}
}
