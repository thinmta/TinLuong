///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'Huu_CongNhat_ChiTiet_ChamCong_ToGapDan'
// Generated by LLBLGen v1.3.5996.26197 Final on: Monday, March 29, 2021, 9:39:12 AM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace CtyTinLuong
{
	/// <summary>
	/// Purpose: Data Access class for the table 'Huu_CongNhat_ChiTiet_ChamCong_ToGapDan'.
	/// </summary>
	public partial class clsHuu_CongNhat_ChiTiet_ChamCong_ToGapDan : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bDaCaiDat;
			private SqlDouble		m_fNgay18, m_fNgay21, m_fNgay20, m_fNgay19, m_fNgay14, m_fNgay13, m_fNgay15, m_fNgay17, m_fNgay16, m_fNgay28, m_fNgay27, m_fNgay30, m_fNgay29, m_fNgay26, m_fNgay23, m_fNgay22, m_fNgay25, m_fNgay24, m_fNgay3, m_fNgay4, m_fNgay5, m_fNgay12, m_fNgay1, m_fNgay2, m_fNgay6, m_fNgay10, m_fNgay11, m_fNgay31, m_fNgay7, m_fNgay8, m_fNgay9;
			private SqlInt32		m_iID_CongNhan, m_iID_MaHang_ToGapDan, m_iThang, m_iID_DinhMuc_Luong_SanLuong, m_iID_VTHH, m_iNam;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public clsHuu_CongNhat_ChiTiet_ChamCong_ToGapDan()
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
		///		 <LI>iID_CongNhan</LI>
		///		 <LI>iThang</LI>
		///		 <LI>iNam</LI>
		///		 <LI>iID_VTHH</LI>
		///		 <LI>bDaCaiDat</LI>
		///		 <LI>iID_DinhMuc_Luong_SanLuong</LI>
		///		 <LI>fNgay1</LI>
		///		 <LI>fNgay2</LI>
		///		 <LI>fNgay3</LI>
		///		 <LI>fNgay4</LI>
		///		 <LI>fNgay5</LI>
		///		 <LI>fNgay6</LI>
		///		 <LI>fNgay7</LI>
		///		 <LI>fNgay8</LI>
		///		 <LI>fNgay9</LI>
		///		 <LI>fNgay10</LI>
		///		 <LI>fNgay11</LI>
		///		 <LI>fNgay12</LI>
		///		 <LI>fNgay13</LI>
		///		 <LI>fNgay14</LI>
		///		 <LI>fNgay15</LI>
		///		 <LI>fNgay16</LI>
		///		 <LI>fNgay17</LI>
		///		 <LI>fNgay18</LI>
		///		 <LI>fNgay19</LI>
		///		 <LI>fNgay20</LI>
		///		 <LI>fNgay21</LI>
		///		 <LI>fNgay22</LI>
		///		 <LI>fNgay23</LI>
		///		 <LI>fNgay24</LI>
		///		 <LI>fNgay25</LI>
		///		 <LI>fNgay26</LI>
		///		 <LI>fNgay27</LI>
		///		 <LI>fNgay28</LI>
		///		 <LI>fNgay29</LI>
		///		 <LI>fNgay30</LI>
		///		 <LI>fNgay31</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iID_MaHang_ToGapDan</LI>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_Huu_CongNhat_ChiTiet_ChamCong_ToGapDan_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongNhan", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongNhan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iThang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iThang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iNam", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iNam));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_VTHH", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_VTHH));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bDaCaiDat", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bDaCaiDat));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_DinhMuc_Luong_SanLuong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DinhMuc_Luong_SanLuong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay1", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay2", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay3", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay3));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay4", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay4));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay5", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay5));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay6", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay6));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay7", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay7));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay8", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay8));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay9", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay9));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay10", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay10));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay11", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay11));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay12", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay12));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay13", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay13));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay14", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay14));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay15", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay15));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay16", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay16));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay17", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay17));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay18", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay18));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay19", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay19));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay20", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay20));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay21", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay21));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay22", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay22));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay23", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay23));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay24", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay24));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay25", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay25));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay26", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay26));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay27", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay27));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay28", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay28));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay29", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay29));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay30", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay30));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay31", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay31));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_MaHang_ToGapDan", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_MaHang_ToGapDan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iID_MaHang_ToGapDan = (SqlInt32)scmCmdToExecute.Parameters["@iID_MaHang_ToGapDan"].Value;
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_Huu_CongNhat_ChiTiet_ChamCong_ToGapDan_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsHuu_CongNhat_ChiTiet_ChamCong_ToGapDan::Insert::Error occured.", ex);
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
		///		 <LI>iID_MaHang_ToGapDan</LI>
		///		 <LI>iID_CongNhan</LI>
		///		 <LI>iThang</LI>
		///		 <LI>iNam</LI>
		///		 <LI>iID_VTHH</LI>
		///		 <LI>bDaCaiDat</LI>
		///		 <LI>iID_DinhMuc_Luong_SanLuong</LI>
		///		 <LI>fNgay1</LI>
		///		 <LI>fNgay2</LI>
		///		 <LI>fNgay3</LI>
		///		 <LI>fNgay4</LI>
		///		 <LI>fNgay5</LI>
		///		 <LI>fNgay6</LI>
		///		 <LI>fNgay7</LI>
		///		 <LI>fNgay8</LI>
		///		 <LI>fNgay9</LI>
		///		 <LI>fNgay10</LI>
		///		 <LI>fNgay11</LI>
		///		 <LI>fNgay12</LI>
		///		 <LI>fNgay13</LI>
		///		 <LI>fNgay14</LI>
		///		 <LI>fNgay15</LI>
		///		 <LI>fNgay16</LI>
		///		 <LI>fNgay17</LI>
		///		 <LI>fNgay18</LI>
		///		 <LI>fNgay19</LI>
		///		 <LI>fNgay20</LI>
		///		 <LI>fNgay21</LI>
		///		 <LI>fNgay22</LI>
		///		 <LI>fNgay23</LI>
		///		 <LI>fNgay24</LI>
		///		 <LI>fNgay25</LI>
		///		 <LI>fNgay26</LI>
		///		 <LI>fNgay27</LI>
		///		 <LI>fNgay28</LI>
		///		 <LI>fNgay29</LI>
		///		 <LI>fNgay30</LI>
		///		 <LI>fNgay31</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Update()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_Huu_CongNhat_ChiTiet_ChamCong_ToGapDan_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_MaHang_ToGapDan", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_MaHang_ToGapDan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongNhan", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongNhan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iThang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iThang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iNam", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iNam));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_VTHH", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_VTHH));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bDaCaiDat", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bDaCaiDat));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_DinhMuc_Luong_SanLuong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DinhMuc_Luong_SanLuong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay1", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay2", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay3", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay3));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay4", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay4));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay5", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay5));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay6", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay6));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay7", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay7));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay8", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay8));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay9", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay9));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay10", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay10));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay11", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay11));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay12", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay12));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay13", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay13));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay14", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay14));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay15", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay15));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay16", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay16));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay17", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay17));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay18", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay18));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay19", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay19));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay20", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay20));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay21", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay21));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay22", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay22));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay23", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay23));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay24", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay24));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay25", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay25));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay26", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay26));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay27", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay27));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay28", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay28));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay29", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay29));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay30", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay30));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay31", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay31));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_Huu_CongNhat_ChiTiet_ChamCong_ToGapDan_Update' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsHuu_CongNhat_ChiTiet_ChamCong_ToGapDan::Update::Error occured.", ex);
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
		///		 <LI>iID_MaHang_ToGapDan</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_Huu_CongNhat_ChiTiet_ChamCong_ToGapDan_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_MaHang_ToGapDan", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_MaHang_ToGapDan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_Huu_CongNhat_ChiTiet_ChamCong_ToGapDan_Delete' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsHuu_CongNhat_ChiTiet_ChamCong_ToGapDan::Delete::Error occured.", ex);
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
		///		 <LI>iID_MaHang_ToGapDan</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		///		 <LI>iID_MaHang_ToGapDan</LI>
		///		 <LI>iID_CongNhan</LI>
		///		 <LI>iThang</LI>
		///		 <LI>iNam</LI>
		///		 <LI>iID_VTHH</LI>
		///		 <LI>bDaCaiDat</LI>
		///		 <LI>iID_DinhMuc_Luong_SanLuong</LI>
		///		 <LI>fNgay1</LI>
		///		 <LI>fNgay2</LI>
		///		 <LI>fNgay3</LI>
		///		 <LI>fNgay4</LI>
		///		 <LI>fNgay5</LI>
		///		 <LI>fNgay6</LI>
		///		 <LI>fNgay7</LI>
		///		 <LI>fNgay8</LI>
		///		 <LI>fNgay9</LI>
		///		 <LI>fNgay10</LI>
		///		 <LI>fNgay11</LI>
		///		 <LI>fNgay12</LI>
		///		 <LI>fNgay13</LI>
		///		 <LI>fNgay14</LI>
		///		 <LI>fNgay15</LI>
		///		 <LI>fNgay16</LI>
		///		 <LI>fNgay17</LI>
		///		 <LI>fNgay18</LI>
		///		 <LI>fNgay19</LI>
		///		 <LI>fNgay20</LI>
		///		 <LI>fNgay21</LI>
		///		 <LI>fNgay22</LI>
		///		 <LI>fNgay23</LI>
		///		 <LI>fNgay24</LI>
		///		 <LI>fNgay25</LI>
		///		 <LI>fNgay26</LI>
		///		 <LI>fNgay27</LI>
		///		 <LI>fNgay28</LI>
		///		 <LI>fNgay29</LI>
		///		 <LI>fNgay30</LI>
		///		 <LI>fNgay31</LI>
		/// </UL>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_Huu_CongNhat_ChiTiet_ChamCong_ToGapDan_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("Huu_CongNhat_ChiTiet_ChamCong_ToGapDan");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_MaHang_ToGapDan", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_MaHang_ToGapDan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_Huu_CongNhat_ChiTiet_ChamCong_ToGapDan_SelectOne' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_iID_MaHang_ToGapDan = (Int32)dtToReturn.Rows[0]["ID_MaHang_ToGapDan"];
					m_iID_CongNhan = (Int32)dtToReturn.Rows[0]["ID_CongNhan"];
					m_iThang = (Int32)dtToReturn.Rows[0]["Thang"];
					m_iNam = (Int32)dtToReturn.Rows[0]["Nam"];
					m_iID_VTHH = (Int32)dtToReturn.Rows[0]["ID_VTHH"];
					m_bDaCaiDat = (bool)dtToReturn.Rows[0]["DaCaiDat"];
					m_iID_DinhMuc_Luong_SanLuong = (Int32)dtToReturn.Rows[0]["ID_DinhMuc_Luong_SanLuong"];
					m_fNgay1 = (double)dtToReturn.Rows[0]["Ngay1"];
					m_fNgay2 = (double)dtToReturn.Rows[0]["Ngay2"];
					m_fNgay3 = (double)dtToReturn.Rows[0]["Ngay3"];
					m_fNgay4 = (double)dtToReturn.Rows[0]["Ngay4"];
					m_fNgay5 = (double)dtToReturn.Rows[0]["Ngay5"];
					m_fNgay6 = (double)dtToReturn.Rows[0]["Ngay6"];
					m_fNgay7 = (double)dtToReturn.Rows[0]["Ngay7"];
					m_fNgay8 = (double)dtToReturn.Rows[0]["Ngay8"];
					m_fNgay9 = (double)dtToReturn.Rows[0]["Ngay9"];
					m_fNgay10 = (double)dtToReturn.Rows[0]["Ngay10"];
					m_fNgay11 = (double)dtToReturn.Rows[0]["Ngay11"];
					m_fNgay12 = (double)dtToReturn.Rows[0]["Ngay12"];
					m_fNgay13 = (double)dtToReturn.Rows[0]["Ngay13"];
					m_fNgay14 = (double)dtToReturn.Rows[0]["Ngay14"];
					m_fNgay15 = (double)dtToReturn.Rows[0]["Ngay15"];
					m_fNgay16 = (double)dtToReturn.Rows[0]["Ngay16"];
					m_fNgay17 = (double)dtToReturn.Rows[0]["Ngay17"];
					m_fNgay18 = (double)dtToReturn.Rows[0]["Ngay18"];
					m_fNgay19 = (double)dtToReturn.Rows[0]["Ngay19"];
					m_fNgay20 = (double)dtToReturn.Rows[0]["Ngay20"];
					m_fNgay21 = (double)dtToReturn.Rows[0]["Ngay21"];
					m_fNgay22 = (double)dtToReturn.Rows[0]["Ngay22"];
					m_fNgay23 = (double)dtToReturn.Rows[0]["Ngay23"];
					m_fNgay24 = (double)dtToReturn.Rows[0]["Ngay24"];
					m_fNgay25 = (double)dtToReturn.Rows[0]["Ngay25"];
					m_fNgay26 = (double)dtToReturn.Rows[0]["Ngay26"];
					m_fNgay27 = (double)dtToReturn.Rows[0]["Ngay27"];
					m_fNgay28 = (double)dtToReturn.Rows[0]["Ngay28"];
					m_fNgay29 = (double)dtToReturn.Rows[0]["Ngay29"];
					m_fNgay30 = (double)dtToReturn.Rows[0]["Ngay30"];
					m_fNgay31 = (double)dtToReturn.Rows[0]["Ngay31"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsHuu_CongNhat_ChiTiet_ChamCong_ToGapDan::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_Huu_CongNhat_ChiTiet_ChamCong_ToGapDan_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("Huu_CongNhat_ChiTiet_ChamCong_ToGapDan");
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
					throw new Exception("Stored Procedure 'pr_Huu_CongNhat_ChiTiet_ChamCong_ToGapDan_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsHuu_CongNhat_ChiTiet_ChamCong_ToGapDan::SelectAll::Error occured.", ex);
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
		public SqlInt32 iID_MaHang_ToGapDan
		{
			get
			{
				return m_iID_MaHang_ToGapDan;
			}
			set
			{
				SqlInt32 iID_MaHang_ToGapDanTmp = (SqlInt32)value;
				if(iID_MaHang_ToGapDanTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_MaHang_ToGapDan", "iID_MaHang_ToGapDan can't be NULL");
				}
				m_iID_MaHang_ToGapDan = value;
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


		public SqlInt32 iThang
		{
			get
			{
				return m_iThang;
			}
			set
			{
				SqlInt32 iThangTmp = (SqlInt32)value;
				if(iThangTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iThang", "iThang can't be NULL");
				}
				m_iThang = value;
			}
		}


		public SqlInt32 iNam
		{
			get
			{
				return m_iNam;
			}
			set
			{
				SqlInt32 iNamTmp = (SqlInt32)value;
				if(iNamTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iNam", "iNam can't be NULL");
				}
				m_iNam = value;
			}
		}


		public SqlInt32 iID_VTHH
		{
			get
			{
				return m_iID_VTHH;
			}
			set
			{
				SqlInt32 iID_VTHHTmp = (SqlInt32)value;
				if(iID_VTHHTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_VTHH", "iID_VTHH can't be NULL");
				}
				m_iID_VTHH = value;
			}
		}


		public SqlBoolean bDaCaiDat
		{
			get
			{
				return m_bDaCaiDat;
			}
			set
			{
				SqlBoolean bDaCaiDatTmp = (SqlBoolean)value;
				if(bDaCaiDatTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bDaCaiDat", "bDaCaiDat can't be NULL");
				}
				m_bDaCaiDat = value;
			}
		}


		public SqlInt32 iID_DinhMuc_Luong_SanLuong
		{
			get
			{
				return m_iID_DinhMuc_Luong_SanLuong;
			}
			set
			{
				SqlInt32 iID_DinhMuc_Luong_SanLuongTmp = (SqlInt32)value;
				if(iID_DinhMuc_Luong_SanLuongTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_DinhMuc_Luong_SanLuong", "iID_DinhMuc_Luong_SanLuong can't be NULL");
				}
				m_iID_DinhMuc_Luong_SanLuong = value;
			}
		}


		public SqlDouble fNgay1
		{
			get
			{
				return m_fNgay1;
			}
			set
			{
				SqlDouble fNgay1Tmp = (SqlDouble)value;
				if(fNgay1Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay1", "fNgay1 can't be NULL");
				}
				m_fNgay1 = value;
			}
		}


		public SqlDouble fNgay2
		{
			get
			{
				return m_fNgay2;
			}
			set
			{
				SqlDouble fNgay2Tmp = (SqlDouble)value;
				if(fNgay2Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay2", "fNgay2 can't be NULL");
				}
				m_fNgay2 = value;
			}
		}


		public SqlDouble fNgay3
		{
			get
			{
				return m_fNgay3;
			}
			set
			{
				SqlDouble fNgay3Tmp = (SqlDouble)value;
				if(fNgay3Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay3", "fNgay3 can't be NULL");
				}
				m_fNgay3 = value;
			}
		}


		public SqlDouble fNgay4
		{
			get
			{
				return m_fNgay4;
			}
			set
			{
				SqlDouble fNgay4Tmp = (SqlDouble)value;
				if(fNgay4Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay4", "fNgay4 can't be NULL");
				}
				m_fNgay4 = value;
			}
		}


		public SqlDouble fNgay5
		{
			get
			{
				return m_fNgay5;
			}
			set
			{
				SqlDouble fNgay5Tmp = (SqlDouble)value;
				if(fNgay5Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay5", "fNgay5 can't be NULL");
				}
				m_fNgay5 = value;
			}
		}


		public SqlDouble fNgay6
		{
			get
			{
				return m_fNgay6;
			}
			set
			{
				SqlDouble fNgay6Tmp = (SqlDouble)value;
				if(fNgay6Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay6", "fNgay6 can't be NULL");
				}
				m_fNgay6 = value;
			}
		}


		public SqlDouble fNgay7
		{
			get
			{
				return m_fNgay7;
			}
			set
			{
				SqlDouble fNgay7Tmp = (SqlDouble)value;
				if(fNgay7Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay7", "fNgay7 can't be NULL");
				}
				m_fNgay7 = value;
			}
		}


		public SqlDouble fNgay8
		{
			get
			{
				return m_fNgay8;
			}
			set
			{
				SqlDouble fNgay8Tmp = (SqlDouble)value;
				if(fNgay8Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay8", "fNgay8 can't be NULL");
				}
				m_fNgay8 = value;
			}
		}


		public SqlDouble fNgay9
		{
			get
			{
				return m_fNgay9;
			}
			set
			{
				SqlDouble fNgay9Tmp = (SqlDouble)value;
				if(fNgay9Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay9", "fNgay9 can't be NULL");
				}
				m_fNgay9 = value;
			}
		}


		public SqlDouble fNgay10
		{
			get
			{
				return m_fNgay10;
			}
			set
			{
				SqlDouble fNgay10Tmp = (SqlDouble)value;
				if(fNgay10Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay10", "fNgay10 can't be NULL");
				}
				m_fNgay10 = value;
			}
		}


		public SqlDouble fNgay11
		{
			get
			{
				return m_fNgay11;
			}
			set
			{
				SqlDouble fNgay11Tmp = (SqlDouble)value;
				if(fNgay11Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay11", "fNgay11 can't be NULL");
				}
				m_fNgay11 = value;
			}
		}


		public SqlDouble fNgay12
		{
			get
			{
				return m_fNgay12;
			}
			set
			{
				SqlDouble fNgay12Tmp = (SqlDouble)value;
				if(fNgay12Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay12", "fNgay12 can't be NULL");
				}
				m_fNgay12 = value;
			}
		}


		public SqlDouble fNgay13
		{
			get
			{
				return m_fNgay13;
			}
			set
			{
				SqlDouble fNgay13Tmp = (SqlDouble)value;
				if(fNgay13Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay13", "fNgay13 can't be NULL");
				}
				m_fNgay13 = value;
			}
		}


		public SqlDouble fNgay14
		{
			get
			{
				return m_fNgay14;
			}
			set
			{
				SqlDouble fNgay14Tmp = (SqlDouble)value;
				if(fNgay14Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay14", "fNgay14 can't be NULL");
				}
				m_fNgay14 = value;
			}
		}


		public SqlDouble fNgay15
		{
			get
			{
				return m_fNgay15;
			}
			set
			{
				SqlDouble fNgay15Tmp = (SqlDouble)value;
				if(fNgay15Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay15", "fNgay15 can't be NULL");
				}
				m_fNgay15 = value;
			}
		}


		public SqlDouble fNgay16
		{
			get
			{
				return m_fNgay16;
			}
			set
			{
				SqlDouble fNgay16Tmp = (SqlDouble)value;
				if(fNgay16Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay16", "fNgay16 can't be NULL");
				}
				m_fNgay16 = value;
			}
		}


		public SqlDouble fNgay17
		{
			get
			{
				return m_fNgay17;
			}
			set
			{
				SqlDouble fNgay17Tmp = (SqlDouble)value;
				if(fNgay17Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay17", "fNgay17 can't be NULL");
				}
				m_fNgay17 = value;
			}
		}


		public SqlDouble fNgay18
		{
			get
			{
				return m_fNgay18;
			}
			set
			{
				SqlDouble fNgay18Tmp = (SqlDouble)value;
				if(fNgay18Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay18", "fNgay18 can't be NULL");
				}
				m_fNgay18 = value;
			}
		}


		public SqlDouble fNgay19
		{
			get
			{
				return m_fNgay19;
			}
			set
			{
				SqlDouble fNgay19Tmp = (SqlDouble)value;
				if(fNgay19Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay19", "fNgay19 can't be NULL");
				}
				m_fNgay19 = value;
			}
		}


		public SqlDouble fNgay20
		{
			get
			{
				return m_fNgay20;
			}
			set
			{
				SqlDouble fNgay20Tmp = (SqlDouble)value;
				if(fNgay20Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay20", "fNgay20 can't be NULL");
				}
				m_fNgay20 = value;
			}
		}


		public SqlDouble fNgay21
		{
			get
			{
				return m_fNgay21;
			}
			set
			{
				SqlDouble fNgay21Tmp = (SqlDouble)value;
				if(fNgay21Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay21", "fNgay21 can't be NULL");
				}
				m_fNgay21 = value;
			}
		}


		public SqlDouble fNgay22
		{
			get
			{
				return m_fNgay22;
			}
			set
			{
				SqlDouble fNgay22Tmp = (SqlDouble)value;
				if(fNgay22Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay22", "fNgay22 can't be NULL");
				}
				m_fNgay22 = value;
			}
		}


		public SqlDouble fNgay23
		{
			get
			{
				return m_fNgay23;
			}
			set
			{
				SqlDouble fNgay23Tmp = (SqlDouble)value;
				if(fNgay23Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay23", "fNgay23 can't be NULL");
				}
				m_fNgay23 = value;
			}
		}


		public SqlDouble fNgay24
		{
			get
			{
				return m_fNgay24;
			}
			set
			{
				SqlDouble fNgay24Tmp = (SqlDouble)value;
				if(fNgay24Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay24", "fNgay24 can't be NULL");
				}
				m_fNgay24 = value;
			}
		}


		public SqlDouble fNgay25
		{
			get
			{
				return m_fNgay25;
			}
			set
			{
				SqlDouble fNgay25Tmp = (SqlDouble)value;
				if(fNgay25Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay25", "fNgay25 can't be NULL");
				}
				m_fNgay25 = value;
			}
		}


		public SqlDouble fNgay26
		{
			get
			{
				return m_fNgay26;
			}
			set
			{
				SqlDouble fNgay26Tmp = (SqlDouble)value;
				if(fNgay26Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay26", "fNgay26 can't be NULL");
				}
				m_fNgay26 = value;
			}
		}


		public SqlDouble fNgay27
		{
			get
			{
				return m_fNgay27;
			}
			set
			{
				SqlDouble fNgay27Tmp = (SqlDouble)value;
				if(fNgay27Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay27", "fNgay27 can't be NULL");
				}
				m_fNgay27 = value;
			}
		}


		public SqlDouble fNgay28
		{
			get
			{
				return m_fNgay28;
			}
			set
			{
				SqlDouble fNgay28Tmp = (SqlDouble)value;
				if(fNgay28Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay28", "fNgay28 can't be NULL");
				}
				m_fNgay28 = value;
			}
		}


		public SqlDouble fNgay29
		{
			get
			{
				return m_fNgay29;
			}
			set
			{
				SqlDouble fNgay29Tmp = (SqlDouble)value;
				if(fNgay29Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay29", "fNgay29 can't be NULL");
				}
				m_fNgay29 = value;
			}
		}


		public SqlDouble fNgay30
		{
			get
			{
				return m_fNgay30;
			}
			set
			{
				SqlDouble fNgay30Tmp = (SqlDouble)value;
				if(fNgay30Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay30", "fNgay30 can't be NULL");
				}
				m_fNgay30 = value;
			}
		}


		public SqlDouble fNgay31
		{
			get
			{
				return m_fNgay31;
			}
			set
			{
				SqlDouble fNgay31Tmp = (SqlDouble)value;
				if(fNgay31Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNgay31", "fNgay31 can't be NULL");
				}
				m_fNgay31 = value;
			}
		}
		#endregion
	}
}
