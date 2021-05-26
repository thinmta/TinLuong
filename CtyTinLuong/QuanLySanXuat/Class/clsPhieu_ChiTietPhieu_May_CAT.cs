using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace CtyTinLuong
{
	public partial class clsPhieu_ChiTietPhieu_May_CAT : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bGuiDuLieu, m_bTrangThaiXuatNhap;
			private SqlDateTime		m_daNgaySanXuat;
			private SqlDouble		m_fSanLuongTong, m_fSanLuongThuong, m_fDonGiaXuat, m_fPhePham, m_fSanLuongTangCa, m_fSoLuongNhap, m_fDonGiaNhap;
			private SqlInt32		m_iID_SoPhieu, m_iID_VTHH_Vao, m_iID_ChiTietPhieu, m_iID_CaTruong, m_iID_DinhMuc_Luong, m_iID_CongNhan, m_iID_VTHH_Ra, m_iID_May;
			private SqlString		m_sGhiChu;
		#endregion


		public clsPhieu_ChiTietPhieu_May_CAT()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_Phieu_ChiTietPhieu_May_CAT_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_SoPhieu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_SoPhieu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_VTHH_Vao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_VTHH_Vao));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_May", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_May));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongNhan", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongNhan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_DinhMuc_Luong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DinhMuc_Luong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fSoLuongNhap", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSoLuongNhap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fDonGiaNhap", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDonGiaNhap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fSanLuongThuong", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSanLuongThuong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fSanLuongTong", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSanLuongTong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fDonGiaXuat", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDonGiaXuat));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fSanLuongTangCa", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSanLuongTangCa));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_VTHH_Ra", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_VTHH_Ra));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fPhePham", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fPhePham));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sGhiChu", SqlDbType.NVarChar, 350, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sGhiChu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTrangThaiXuatNhap", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTrangThaiXuatNhap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bGuiDuLieu", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bGuiDuLieu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CaTruong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CaTruong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daNgaySanXuat", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgaySanXuat));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietPhieu", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietPhieu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iID_ChiTietPhieu = (SqlInt32)scmCmdToExecute.Parameters["@iID_ChiTietPhieu"].Value;
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_Phieu_ChiTietPhieu_May_CAT_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsPhieu_ChiTietPhieu_May_CAT::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_Phieu_ChiTietPhieu_May_CAT_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietPhieu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietPhieu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_SoPhieu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_SoPhieu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_VTHH_Vao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_VTHH_Vao));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_May", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_May));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongNhan", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongNhan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_DinhMuc_Luong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DinhMuc_Luong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fSoLuongNhap", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSoLuongNhap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fDonGiaNhap", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDonGiaNhap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fSanLuongThuong", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSanLuongThuong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fSanLuongTong", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSanLuongTong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fDonGiaXuat", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDonGiaXuat));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fSanLuongTangCa", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSanLuongTangCa));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_VTHH_Ra", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_VTHH_Ra));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fPhePham", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fPhePham));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sGhiChu", SqlDbType.NVarChar, 350, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sGhiChu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTrangThaiXuatNhap", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTrangThaiXuatNhap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bGuiDuLieu", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bGuiDuLieu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CaTruong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CaTruong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daNgaySanXuat", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgaySanXuat));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_Phieu_ChiTietPhieu_May_CAT_Update' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsPhieu_ChiTietPhieu_May_CAT::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_Phieu_ChiTietPhieu_May_CAT_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietPhieu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietPhieu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_Phieu_ChiTietPhieu_May_CAT_Delete' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsPhieu_ChiTietPhieu_May_CAT::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_Phieu_ChiTietPhieu_May_CAT_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("Phieu_ChiTietPhieu_May_CAT");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietPhieu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietPhieu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_Phieu_ChiTietPhieu_May_CAT_SelectOne' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_iID_ChiTietPhieu = (Int32)dtToReturn.Rows[0]["ID_ChiTietPhieu"];
					m_iID_SoPhieu = (Int32)dtToReturn.Rows[0]["ID_SoPhieu"];
					m_iID_VTHH_Vao = (Int32)dtToReturn.Rows[0]["ID_VTHH_Vao"];
					m_iID_May = (Int32)dtToReturn.Rows[0]["ID_May"];
					m_iID_CongNhan = (Int32)dtToReturn.Rows[0]["ID_CongNhan"];
					m_iID_DinhMuc_Luong = dtToReturn.Rows[0]["ID_DinhMuc_Luong"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_DinhMuc_Luong"];
					m_fSoLuongNhap = (double)dtToReturn.Rows[0]["SoLuongNhap"];
					m_fDonGiaNhap = dtToReturn.Rows[0]["DonGiaNhap"] == System.DBNull.Value ? SqlDouble.Null : (double)dtToReturn.Rows[0]["DonGiaNhap"];
					m_fSanLuongThuong = (double)dtToReturn.Rows[0]["SanLuongThuong"];
					m_fSanLuongTong = (double)dtToReturn.Rows[0]["SanLuongTong"];
					m_fDonGiaXuat = dtToReturn.Rows[0]["DonGiaXuat"] == System.DBNull.Value ? SqlDouble.Null : (double)dtToReturn.Rows[0]["DonGiaXuat"];
					m_fSanLuongTangCa = (double)dtToReturn.Rows[0]["SanLuongTangCa"];
					m_iID_VTHH_Ra = (Int32)dtToReturn.Rows[0]["ID_VTHH_Ra"];
					m_fPhePham = (double)dtToReturn.Rows[0]["PhePham"];
					m_sGhiChu = dtToReturn.Rows[0]["GhiChu"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["GhiChu"];
					m_bTrangThaiXuatNhap = (bool)dtToReturn.Rows[0]["TrangThaiXuatNhap"];
					m_bGuiDuLieu = (bool)dtToReturn.Rows[0]["GuiDuLieu"];
					m_iID_CaTruong = (Int32)dtToReturn.Rows[0]["ID_CaTruong"];
					m_daNgaySanXuat = (DateTime)dtToReturn.Rows[0]["NgaySanXuat"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsPhieu_ChiTietPhieu_May_CAT::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_Phieu_ChiTietPhieu_May_CAT_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("Phieu_ChiTietPhieu_May_CAT");
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
					throw new Exception("Stored Procedure 'pr_Phieu_ChiTietPhieu_May_CAT_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsPhieu_ChiTietPhieu_May_CAT::SelectAll::Error occured.", ex);
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
		public SqlInt32 iID_ChiTietPhieu
		{
			get
			{
				return m_iID_ChiTietPhieu;
			}
			set
			{
				SqlInt32 iID_ChiTietPhieuTmp = (SqlInt32)value;
				if(iID_ChiTietPhieuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_ChiTietPhieu", "iID_ChiTietPhieu can't be NULL");
				}
				m_iID_ChiTietPhieu = value;
			}
		}


		public SqlInt32 iID_SoPhieu
		{
			get
			{
				return m_iID_SoPhieu;
			}
			set
			{
				SqlInt32 iID_SoPhieuTmp = (SqlInt32)value;
				if(iID_SoPhieuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_SoPhieu", "iID_SoPhieu can't be NULL");
				}
				m_iID_SoPhieu = value;
			}
		}


		public SqlInt32 iID_VTHH_Vao
		{
			get
			{
				return m_iID_VTHH_Vao;
			}
			set
			{
				SqlInt32 iID_VTHH_VaoTmp = (SqlInt32)value;
				if(iID_VTHH_VaoTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_VTHH_Vao", "iID_VTHH_Vao can't be NULL");
				}
				m_iID_VTHH_Vao = value;
			}
		}


		public SqlInt32 iID_May
		{
			get
			{
				return m_iID_May;
			}
			set
			{
				SqlInt32 iID_MayTmp = (SqlInt32)value;
				if(iID_MayTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_May", "iID_May can't be NULL");
				}
				m_iID_May = value;
			}
		}


		public SqlInt32 iID_CongNhan
		{
			get
			{
				return m_iID_CongNhan;
			}
			set
			{
				SqlInt32 iID_CongNhanTmp = (SqlInt32)value;
				if(iID_CongNhanTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_CongNhan", "iID_CongNhan can't be NULL");
				}
				m_iID_CongNhan = value;
			}
		}


		public SqlInt32 iID_DinhMuc_Luong
		{
			get
			{
				return m_iID_DinhMuc_Luong;
			}
			set
			{
				SqlInt32 iID_DinhMuc_LuongTmp = (SqlInt32)value;
				if(iID_DinhMuc_LuongTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_DinhMuc_Luong", "iID_DinhMuc_Luong can't be NULL");
				}
				m_iID_DinhMuc_Luong = value;
			}
		}


		public SqlDouble fSoLuongNhap
		{
			get
			{
				return m_fSoLuongNhap;
			}
			set
			{
				SqlDouble fSoLuongNhapTmp = (SqlDouble)value;
				if(fSoLuongNhapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fSoLuongNhap", "fSoLuongNhap can't be NULL");
				}
				m_fSoLuongNhap = value;
			}
		}


		public SqlDouble fDonGiaNhap
		{
			get
			{
				return m_fDonGiaNhap;
			}
			set
			{
				SqlDouble fDonGiaNhapTmp = (SqlDouble)value;
				if(fDonGiaNhapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fDonGiaNhap", "fDonGiaNhap can't be NULL");
				}
				m_fDonGiaNhap = value;
			}
		}


		public SqlDouble fSanLuongThuong
		{
			get
			{
				return m_fSanLuongThuong;
			}
			set
			{
				SqlDouble fSanLuongThuongTmp = (SqlDouble)value;
				if(fSanLuongThuongTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fSanLuongThuong", "fSanLuongThuong can't be NULL");
				}
				m_fSanLuongThuong = value;
			}
		}


		public SqlDouble fSanLuongTong
		{
			get
			{
				return m_fSanLuongTong;
			}
			set
			{
				SqlDouble fSanLuongTongTmp = (SqlDouble)value;
				if(fSanLuongTongTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fSanLuongTong", "fSanLuongTong can't be NULL");
				}
				m_fSanLuongTong = value;
			}
		}


		public SqlDouble fDonGiaXuat
		{
			get
			{
				return m_fDonGiaXuat;
			}
			set
			{
				SqlDouble fDonGiaXuatTmp = (SqlDouble)value;
				if(fDonGiaXuatTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fDonGiaXuat", "fDonGiaXuat can't be NULL");
				}
				m_fDonGiaXuat = value;
			}
		}


		public SqlDouble fSanLuongTangCa
		{
			get
			{
				return m_fSanLuongTangCa;
			}
			set
			{
				SqlDouble fSanLuongTangCaTmp = (SqlDouble)value;
				if(fSanLuongTangCaTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fSanLuongTangCa", "fSanLuongTangCa can't be NULL");
				}
				m_fSanLuongTangCa = value;
			}
		}


		public SqlInt32 iID_VTHH_Ra
		{
			get
			{
				return m_iID_VTHH_Ra;
			}
			set
			{
				SqlInt32 iID_VTHH_RaTmp = (SqlInt32)value;
				if(iID_VTHH_RaTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_VTHH_Ra", "iID_VTHH_Ra can't be NULL");
				}
				m_iID_VTHH_Ra = value;
			}
		}


		public SqlDouble fPhePham
		{
			get
			{
				return m_fPhePham;
			}
			set
			{
				SqlDouble fPhePhamTmp = (SqlDouble)value;
				if(fPhePhamTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fPhePham", "fPhePham can't be NULL");
				}
				m_fPhePham = value;
			}
		}


		public SqlString sGhiChu
		{
			get
			{
				return m_sGhiChu;
			}
			set
			{
				SqlString sGhiChuTmp = (SqlString)value;
				if(sGhiChuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sGhiChu", "sGhiChu can't be NULL");
				}
				m_sGhiChu = value;
			}
		}


		public SqlBoolean bTrangThaiXuatNhap
		{
			get
			{
				return m_bTrangThaiXuatNhap;
			}
			set
			{
				SqlBoolean bTrangThaiXuatNhapTmp = (SqlBoolean)value;
				if(bTrangThaiXuatNhapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bTrangThaiXuatNhap", "bTrangThaiXuatNhap can't be NULL");
				}
				m_bTrangThaiXuatNhap = value;
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


		public SqlInt32 iID_CaTruong
		{
			get
			{
				return m_iID_CaTruong;
			}
			set
			{
				SqlInt32 iID_CaTruongTmp = (SqlInt32)value;
				if(iID_CaTruongTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_CaTruong", "iID_CaTruong can't be NULL");
				}
				m_iID_CaTruong = value;
			}
		}


		public SqlDateTime daNgaySanXuat
		{
			get
			{
				return m_daNgaySanXuat;
			}
			set
			{
				SqlDateTime daNgaySanXuatTmp = (SqlDateTime)value;
				if(daNgaySanXuatTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("daNgaySanXuat", "daNgaySanXuat can't be NULL");
				}
				m_daNgaySanXuat = value;
			}
		}
		#endregion
	}
}
