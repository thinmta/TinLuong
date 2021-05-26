///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'MH_tbMuaHang'
// Generated by LLBLGen v1.3.5996.26197 Final on: Tuesday, March 23, 2021, 9:18:26 AM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace CtyTinLuong
{
	/// <summary>
	/// Purpose: Data Access class for the table 'MH_tbMuaHang'.
	/// </summary>
	public partial class clsMH_tbMuaHang : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bTienUSD, m_bNgungTheoDoi, m_bCheck_LaiXe, m_bMuaHangNhapKho, m_bCheck_BaoVe, m_bTrangThaiNhapKho, m_bGuiDuLieu, m_bTonTai;
			private SqlDateTime		m_daNgayChungTu;
			private SqlDouble		m_fTiGia, m_fPhanTramVAT, m_fTienVAT, m_fTongTienHangChuaVAT, m_fTongTienHangCoVAT;
			private SqlInt32		m_iID_NguoiMua, m_iIDNhaCungCap, m_iID_MuaHang;
			private SqlString		m_sNguoiGiaoHang, m_sDienGiai, m_sSoHoaDon, m_sSoChungTu;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public clsMH_tbMuaHang()
		{
			// Nothing for now.
		}


		/// <summary>
		/// Purpose: Insert method. This method will insert one new row into the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>daNgayChungTu</LI>
		///		 <LI>sSoChungTu</LI>
		///		 <LI>sSoHoaDon</LI>
		///		 <LI>sNguoiGiaoHang. May be SqlString.Null</LI>
		///		 <LI>iIDNhaCungCap</LI>
		///		 <LI>sDienGiai</LI>
		///		 <LI>fTongTienHangChuaVAT</LI>
		///		 <LI>fTongTienHangCoVAT</LI>
		///		 <LI>iID_NguoiMua</LI>
		///		 <LI>bTonTai</LI>
		///		 <LI>bNgungTheoDoi</LI>
		///		 <LI>bTienUSD</LI>
		///		 <LI>fTiGia. May be SqlDouble.Null</LI>
		///		 <LI>fPhanTramVAT</LI>
		///		 <LI>fTienVAT</LI>
		///		 <LI>bMuaHangNhapKho</LI>
		///		 <LI>bGuiDuLieu</LI>
		///		 <LI>bTrangThaiNhapKho</LI>
		///		 <LI>bCheck_BaoVe. May be SqlBoolean.Null</LI>
		///		 <LI>bCheck_LaiXe. May be SqlBoolean.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iID_MuaHang</LI>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_MH_tbMuaHang_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daNgayChungTu", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgayChungTu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSoChungTu", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSoChungTu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSoHoaDon", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSoHoaDon));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sNguoiGiaoHang", SqlDbType.NVarChar, 150, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNguoiGiaoHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iIDNhaCungCap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iIDNhaCungCap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDienGiai", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDienGiai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fTongTienHangChuaVAT", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTongTienHangChuaVAT));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fTongTienHangCoVAT", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTongTienHangCoVAT));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NguoiMua", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NguoiMua));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bNgungTheoDoi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bNgungTheoDoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTienUSD", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTienUSD));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fTiGia", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTiGia));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fPhanTramVAT", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fPhanTramVAT));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fTienVAT", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTienVAT));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bMuaHangNhapKho", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bMuaHangNhapKho));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bGuiDuLieu", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bGuiDuLieu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTrangThaiNhapKho", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTrangThaiNhapKho));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bcheck_BaoVe", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bCheck_BaoVe));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bcheck_LaiXe", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bCheck_LaiXe));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_MuaHang", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_MuaHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iID_MuaHang = (SqlInt32)scmCmdToExecute.Parameters["@iID_MuaHang"].Value;
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_MH_tbMuaHang_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsMH_tbMuaHang::Insert::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Update method. This method will Update one existing row in the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>iID_MuaHang</LI>
		///		 <LI>daNgayChungTu</LI>
		///		 <LI>sSoChungTu</LI>
		///		 <LI>sSoHoaDon</LI>
		///		 <LI>sNguoiGiaoHang. May be SqlString.Null</LI>
		///		 <LI>iIDNhaCungCap</LI>
		///		 <LI>sDienGiai</LI>
		///		 <LI>fTongTienHangChuaVAT</LI>
		///		 <LI>fTongTienHangCoVAT</LI>
		///		 <LI>iID_NguoiMua</LI>
		///		 <LI>bTonTai</LI>
		///		 <LI>bNgungTheoDoi</LI>
		///		 <LI>bTienUSD</LI>
		///		 <LI>fTiGia. May be SqlDouble.Null</LI>
		///		 <LI>fPhanTramVAT</LI>
		///		 <LI>fTienVAT</LI>
		///		 <LI>bMuaHangNhapKho</LI>
		///		 <LI>bGuiDuLieu</LI>
		///		 <LI>bTrangThaiNhapKho</LI>
		///		 <LI>bCheck_BaoVe. May be SqlBoolean.Null</LI>
		///		 <LI>bCheck_LaiXe. May be SqlBoolean.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Update()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_MH_tbMuaHang_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_MuaHang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_MuaHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daNgayChungTu", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgayChungTu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSoChungTu", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSoChungTu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSoHoaDon", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSoHoaDon));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sNguoiGiaoHang", SqlDbType.NVarChar, 150, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNguoiGiaoHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iIDNhaCungCap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iIDNhaCungCap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDienGiai", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDienGiai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fTongTienHangChuaVAT", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTongTienHangChuaVAT));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fTongTienHangCoVAT", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTongTienHangCoVAT));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NguoiMua", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NguoiMua));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bNgungTheoDoi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bNgungTheoDoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTienUSD", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTienUSD));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fTiGia", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTiGia));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fPhanTramVAT", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fPhanTramVAT));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fTienVAT", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTienVAT));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bMuaHangNhapKho", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bMuaHangNhapKho));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bGuiDuLieu", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bGuiDuLieu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTrangThaiNhapKho", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTrangThaiNhapKho));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bcheck_BaoVe", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bCheck_BaoVe));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bcheck_LaiXe", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bCheck_LaiXe));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_MH_tbMuaHang_Update' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsMH_tbMuaHang::Update::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Delete method. This method will Delete one existing row in the database, based on the Primary Key.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>iID_MuaHang</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_MH_tbMuaHang_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_MuaHang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_MuaHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_MH_tbMuaHang_Delete' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsMH_tbMuaHang::Delete::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Select method. This method will Select one existing row from the database, based on the Primary Key.
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>iID_MuaHang</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		///		 <LI>iID_MuaHang</LI>
		///		 <LI>daNgayChungTu</LI>
		///		 <LI>sSoChungTu</LI>
		///		 <LI>sSoHoaDon</LI>
		///		 <LI>sNguoiGiaoHang</LI>
		///		 <LI>iIDNhaCungCap</LI>
		///		 <LI>sDienGiai</LI>
		///		 <LI>fTongTienHangChuaVAT</LI>
		///		 <LI>fTongTienHangCoVAT</LI>
		///		 <LI>iID_NguoiMua</LI>
		///		 <LI>bTonTai</LI>
		///		 <LI>bNgungTheoDoi</LI>
		///		 <LI>bTienUSD</LI>
		///		 <LI>fTiGia</LI>
		///		 <LI>fPhanTramVAT</LI>
		///		 <LI>fTienVAT</LI>
		///		 <LI>bMuaHangNhapKho</LI>
		///		 <LI>bGuiDuLieu</LI>
		///		 <LI>bTrangThaiNhapKho</LI>
		///		 <LI>bCheck_BaoVe</LI>
		///		 <LI>bCheck_LaiXe</LI>
		/// </UL>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_MH_tbMuaHang_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("MH_tbMuaHang");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_MuaHang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_MuaHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_MH_tbMuaHang_SelectOne' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_iID_MuaHang = (Int32)dtToReturn.Rows[0]["ID_MuaHang"];
					m_daNgayChungTu = (DateTime)dtToReturn.Rows[0]["NgayChungTu"];
					m_sSoChungTu = (string)dtToReturn.Rows[0]["SoChungTu"];
					m_sSoHoaDon = (string)dtToReturn.Rows[0]["SoHoaDon"];
					m_sNguoiGiaoHang = dtToReturn.Rows[0]["NguoiGiaoHang"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["NguoiGiaoHang"];
					m_iIDNhaCungCap = (Int32)dtToReturn.Rows[0]["IDNhaCungCap"];
					m_sDienGiai = (string)dtToReturn.Rows[0]["DienGiai"];
					m_fTongTienHangChuaVAT = (double)dtToReturn.Rows[0]["TongTienHangChuaVAT"];
					m_fTongTienHangCoVAT = (double)dtToReturn.Rows[0]["TongTienHangCoVAT"];
					m_iID_NguoiMua = (Int32)dtToReturn.Rows[0]["ID_NguoiMua"];
					m_bTonTai = (bool)dtToReturn.Rows[0]["TonTai"];
					m_bNgungTheoDoi = (bool)dtToReturn.Rows[0]["NgungTheoDoi"];
					m_bTienUSD = (bool)dtToReturn.Rows[0]["TienUSD"];
					m_fTiGia = dtToReturn.Rows[0]["TiGia"] == System.DBNull.Value ? SqlDouble.Null : (double)dtToReturn.Rows[0]["TiGia"];
					m_fPhanTramVAT = (double)dtToReturn.Rows[0]["PhanTramVAT"];
					m_fTienVAT = (double)dtToReturn.Rows[0]["TienVAT"];
					m_bMuaHangNhapKho = (bool)dtToReturn.Rows[0]["MuaHangNhapKho"];
					m_bGuiDuLieu = (bool)dtToReturn.Rows[0]["GuiDuLieu"];
					m_bTrangThaiNhapKho = (bool)dtToReturn.Rows[0]["TrangThaiNhapKho"];
					m_bCheck_BaoVe = dtToReturn.Rows[0]["check_BaoVe"] == System.DBNull.Value ? SqlBoolean.Null : (bool)dtToReturn.Rows[0]["check_BaoVe"];
					m_bCheck_LaiXe = dtToReturn.Rows[0]["check_LaiXe"] == System.DBNull.Value ? SqlBoolean.Null : (bool)dtToReturn.Rows[0]["check_LaiXe"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsMH_tbMuaHang::SelectOne::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
				sdaAdapter.Dispose();
			}
		}


		/// <summary>
		/// Purpose: SelectAll method. This method will Select all rows from the table.
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override DataTable SelectAll()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_MH_tbMuaHang_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("MH_tbMuaHang");
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
					throw new Exception("Stored Procedure 'pr_MH_tbMuaHang_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsMH_tbMuaHang::SelectAll::Error occured.", ex);
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
		public SqlInt32 iID_MuaHang
		{
			get
			{
				return m_iID_MuaHang;
			}
			set
			{
				SqlInt32 iID_MuaHangTmp = (SqlInt32)value;
				if(iID_MuaHangTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_MuaHang", "iID_MuaHang can't be NULL");
				}
				m_iID_MuaHang = value;
			}
		}


		public SqlDateTime daNgayChungTu
		{
			get
			{
				return m_daNgayChungTu;
			}
			set
			{
				SqlDateTime daNgayChungTuTmp = (SqlDateTime)value;
				if(daNgayChungTuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("daNgayChungTu", "daNgayChungTu can't be NULL");
				}
				m_daNgayChungTu = value;
			}
		}


		public SqlString sSoChungTu
		{
			get
			{
				return m_sSoChungTu;
			}
			set
			{
				SqlString sSoChungTuTmp = (SqlString)value;
				if(sSoChungTuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sSoChungTu", "sSoChungTu can't be NULL");
				}
				m_sSoChungTu = value;
			}
		}


		public SqlString sSoHoaDon
		{
			get
			{
				return m_sSoHoaDon;
			}
			set
			{
				SqlString sSoHoaDonTmp = (SqlString)value;
				if(sSoHoaDonTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sSoHoaDon", "sSoHoaDon can't be NULL");
				}
				m_sSoHoaDon = value;
			}
		}


		public SqlString sNguoiGiaoHang
		{
			get
			{
				return m_sNguoiGiaoHang;
			}
			set
			{
				SqlString sNguoiGiaoHangTmp = (SqlString)value;
				if(sNguoiGiaoHangTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sNguoiGiaoHang", "sNguoiGiaoHang can't be NULL");
				}
				m_sNguoiGiaoHang = value;
			}
		}


		public SqlInt32 iIDNhaCungCap
		{
			get
			{
				return m_iIDNhaCungCap;
			}
			set
			{
				SqlInt32 iIDNhaCungCapTmp = (SqlInt32)value;
				if(iIDNhaCungCapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iIDNhaCungCap", "iIDNhaCungCap can't be NULL");
				}
				m_iIDNhaCungCap = value;
			}
		}


		public SqlString sDienGiai
		{
			get
			{
				return m_sDienGiai;
			}
			set
			{
				SqlString sDienGiaiTmp = (SqlString)value;
				if(sDienGiaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sDienGiai", "sDienGiai can't be NULL");
				}
				m_sDienGiai = value;
			}
		}


		public SqlDouble fTongTienHangChuaVAT
		{
			get
			{
				return m_fTongTienHangChuaVAT;
			}
			set
			{
				SqlDouble fTongTienHangChuaVATTmp = (SqlDouble)value;
				if(fTongTienHangChuaVATTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fTongTienHangChuaVAT", "fTongTienHangChuaVAT can't be NULL");
				}
				m_fTongTienHangChuaVAT = value;
			}
		}


		public SqlDouble fTongTienHangCoVAT
		{
			get
			{
				return m_fTongTienHangCoVAT;
			}
			set
			{
				SqlDouble fTongTienHangCoVATTmp = (SqlDouble)value;
				if(fTongTienHangCoVATTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fTongTienHangCoVAT", "fTongTienHangCoVAT can't be NULL");
				}
				m_fTongTienHangCoVAT = value;
			}
		}


		public SqlInt32 iID_NguoiMua
		{
			get
			{
				return m_iID_NguoiMua;
			}
			set
			{
				SqlInt32 iID_NguoiMuaTmp = (SqlInt32)value;
				if(iID_NguoiMuaTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_NguoiMua", "iID_NguoiMua can't be NULL");
				}
				m_iID_NguoiMua = value;
			}
		}


		public SqlBoolean bTonTai
		{
			get
			{
				return m_bTonTai;
			}
			set
			{
				SqlBoolean bTonTaiTmp = (SqlBoolean)value;
				if(bTonTaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bTonTai", "bTonTai can't be NULL");
				}
				m_bTonTai = value;
			}
		}


		public SqlBoolean bNgungTheoDoi
		{
			get
			{
				return m_bNgungTheoDoi;
			}
			set
			{
				SqlBoolean bNgungTheoDoiTmp = (SqlBoolean)value;
				if(bNgungTheoDoiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bNgungTheoDoi", "bNgungTheoDoi can't be NULL");
				}
				m_bNgungTheoDoi = value;
			}
		}


		public SqlBoolean bTienUSD
		{
			get
			{
				return m_bTienUSD;
			}
			set
			{
				SqlBoolean bTienUSDTmp = (SqlBoolean)value;
				if(bTienUSDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bTienUSD", "bTienUSD can't be NULL");
				}
				m_bTienUSD = value;
			}
		}


		public SqlDouble fTiGia
		{
			get
			{
				return m_fTiGia;
			}
			set
			{
				SqlDouble fTiGiaTmp = (SqlDouble)value;
				if(fTiGiaTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fTiGia", "fTiGia can't be NULL");
				}
				m_fTiGia = value;
			}
		}


		public SqlDouble fPhanTramVAT
		{
			get
			{
				return m_fPhanTramVAT;
			}
			set
			{
				SqlDouble fPhanTramVATTmp = (SqlDouble)value;
				if(fPhanTramVATTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fPhanTramVAT", "fPhanTramVAT can't be NULL");
				}
				m_fPhanTramVAT = value;
			}
		}


		public SqlDouble fTienVAT
		{
			get
			{
				return m_fTienVAT;
			}
			set
			{
				SqlDouble fTienVATTmp = (SqlDouble)value;
				if(fTienVATTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fTienVAT", "fTienVAT can't be NULL");
				}
				m_fTienVAT = value;
			}
		}


		public SqlBoolean bMuaHangNhapKho
		{
			get
			{
				return m_bMuaHangNhapKho;
			}
			set
			{
				SqlBoolean bMuaHangNhapKhoTmp = (SqlBoolean)value;
				if(bMuaHangNhapKhoTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bMuaHangNhapKho", "bMuaHangNhapKho can't be NULL");
				}
				m_bMuaHangNhapKho = value;
			}
		}


		public SqlBoolean bGuiDuLieu
		{
			get
			{
				return m_bGuiDuLieu;
			}
			set
			{
				SqlBoolean bGuiDuLieuTmp = (SqlBoolean)value;
				if(bGuiDuLieuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bGuiDuLieu", "bGuiDuLieu can't be NULL");
				}
				m_bGuiDuLieu = value;
			}
		}


		public SqlBoolean bTrangThaiNhapKho
		{
			get
			{
				return m_bTrangThaiNhapKho;
			}
			set
			{
				SqlBoolean bTrangThaiNhapKhoTmp = (SqlBoolean)value;
				if(bTrangThaiNhapKhoTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bTrangThaiNhapKho", "bTrangThaiNhapKho can't be NULL");
				}
				m_bTrangThaiNhapKho = value;
			}
		}


		public SqlBoolean bCheck_BaoVe
		{
			get
			{
				return m_bCheck_BaoVe;
			}
			set
			{
				SqlBoolean bCheck_BaoVeTmp = (SqlBoolean)value;
				if(bCheck_BaoVeTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bCheck_BaoVe", "bCheck_BaoVe can't be NULL");
				}
				m_bCheck_BaoVe = value;
			}
		}


		public SqlBoolean bCheck_LaiXe
		{
			get
			{
				return m_bCheck_LaiXe;
			}
			set
			{
				SqlBoolean bCheck_LaiXeTmp = (SqlBoolean)value;
				if(bCheck_LaiXeTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bCheck_LaiXe", "bCheck_LaiXe can't be NULL");
				}
				m_bCheck_LaiXe = value;
			}
		}
		#endregion
	}
}
