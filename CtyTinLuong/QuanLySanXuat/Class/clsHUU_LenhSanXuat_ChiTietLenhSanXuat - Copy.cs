///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'HUU_LenhSanXuat_ChiTietLenhSanXuat'
// Generated by LLBLGen v1.3.5996.26197 Final on: Thursday, January 21, 2021, 2:13:02 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace CtyTinLuong
{
	/// <summary>
	/// Purpose: Data Access class for the table 'HUU_LenhSanXuat_ChiTietLenhSanXuat'.
	/// </summary>
	public partial class clsHUU_LenhSanXuat_ChiTietLenhSanXuat : clsDBInteractionBase
	{
        //pr_HUU_LenhSanXuat_ChiTietLenhSanXuat_SelectAll_ID_LenhSanXuat_ID_ChiTietPhieu_ID_SoPhieu
        public DataTable SelectAll_ID_LenhSanXuat_ID_ChiTietPhieu_ID_SoPhieu()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_HUU_LenhSanXuat_ChiTietLenhSanXuat_SelectAll_ID_LenhSanXuat_ID_ChiTietPhieu_ID_SoPhieu]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_HUU_LenhSanXuat_ChiTietLenhSanXuat_SelectAll_ID_LenhSanXuat_ID_ChiTietPhieu_ID_SoPhieu");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_LenhSanXuat", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_LenhSanXuat));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietPhieu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietPhieu));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_SoPhieu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_SoPhieu));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_VTHHVao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_VTHHVao));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@fSoLuongVao", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSoLuongVao));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_VTHHRa", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_VTHHRa));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@fSanLuongThuong", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSanLuongThuong));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@fSanLuongTangCa", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSanLuongTangCa));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@fPhePham", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fPhePham));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@fDonGiaVao", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDonGiaVao));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@fDonGiaRa", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDonGiaRa));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@bNgungTheoDoi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bNgungTheoDoi));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietLenhSanXuat", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietLenhSanXuat));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_HUU_LenhSanXuat_ChiTietLenhSanXuat_SelectAll_ID_LenhSanXuat_ID_ChiTietPhieu_ID_SoPhieu", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        public void Delete_w_iID_LenhSanXuat()
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_HUU_LenhSanXuat_ChiTietLenhSanXuat_Delete_w_iID_LenhSanXuat]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_LenhSanXuat", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_LenhSanXuat));
                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_HUU_LenhSanXuat_ChiTietLenhSanXuat_Delete_w_iID_LenhSanXuat::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
        public DataTable SelectAll_w_iID_LenhSanXuat()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_HUU_LenhSanXuat_ChiTietLenhSanXuat_SelectAll_w_iID_LenhSanXuat]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_HUU_LenhSanXuat_ChiTietLenhSanXuat_SelectAll_w_iID_LenhSanXuat");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_LenhSanXuat", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_LenhSanXuat));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_HUU_LenhSanXuat_ChiTietLenhSanXuat_SelectAll_w_iID_LenhSanXuat", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
    }
}
