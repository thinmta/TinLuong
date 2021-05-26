using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace CtyTinLuong
{
	public partial class clsAaatbMacDinhNguoiKy : clsDBInteractionBase
	{
        //pr_aaatbMacDinhNguoiKy_Delete_All_ID_DangNhap
        public void Delete_All_ID_DangNhap()
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_aaatbMacDinhNguoiKy_Delete_All_ID_DangNhap]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_DangNhap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DangNhap)); //scmCmdToExecute.Parameters.Add(new SqlParameter("@fNo", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNo));
                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_aaatbMacDinhNguoiKy_Delete_All_ID_DangNhap::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
        public DataTable SelectAll_ID_DangNhap()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_aaatbMacDinhNguoiKy_SelectAll_ID_DangNhap]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_aaatbMacDinhNguoiKy_SelectAll_ID_DangNhap");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_DangNhap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DangNhap));
                // Execute query.
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_aaatbMacDinhNguoiKy_SelectAll_ID_DangNhap", ex);
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
