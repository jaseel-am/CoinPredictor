using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinPredictor
{
   public class ErrorLogDal :DBConnection
    {
        public void ErrorLogAdd(ErrorLogModel objModel)
        {
            try
            {
                using (SqlConnection objConn = new SqlConnection(ConnectionString))
                {
                    objConn.Open();
                    SqlCommand objCmd = new SqlCommand("ErrorLogInsert", objConn);
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@error_message", objModel.ErrorMessage);
                    objCmd.Parameters.AddWithValue("@stack_trace", objModel.StackTrace);
                    objCmd.Parameters.AddWithValue("@funct_name", objModel.FunctName);
                    objCmd.Parameters.AddWithValue("@error_source", objModel.ErrorSource);

                    //objCmd.Parameters.AddWithValue("@ComputerName", DalSettings.DalComputerName);
                    //objCmd.Parameters.AddWithValue("@IPAddress", DalSettings.DalIpAddress);
                    //objCmd.Parameters.AddWithValue("@ComputerUser", DalSettings.DalComputerUser);

                    objCmd.ExecuteNonQuery();
                    objConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //public DataTable GetErrorLogs(string Searchitem = "")
        //{
        //    DataTable dtbl = new DataTable();
        //    try
        //    {
        //        using (SqlConnection objConn = new SqlConnection(ConnectionString))
        //        {
        //            if (objConn.State == ConnectionState.Closed)
        //            {
        //                objConn.Open();
        //            }
        //            SqlDataAdapter sdaadapter = new SqlDataAdapter("ErrorLogsList", objConn);
        //            sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
        //            if (!string.IsNullOrEmpty(Searchitem))
        //            {
        //                sdaadapter.SelectCommand.Parameters.AddWithValue("@Search", Searchitem);
        //            }
        //            sdaadapter.Fill(dtbl);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    return dtbl;
        //}

        //public DataTable ErrorLogsByArchive(bool isArchived)
        //{
        //    DataTable dtbl = new DataTable();
        //    try
        //    {
        //        using (SqlConnection objConn = new SqlConnection(ConnectionString))
        //        {
        //            if (objConn.State == ConnectionState.Closed)
        //            {
        //                objConn.Open();
        //            }
        //            SqlDataAdapter sdaadapter = new SqlDataAdapter("ErrorLogsByArchive", objConn);
        //            sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
        //            if (isArchived != false)
        //            {
        //                sdaadapter.SelectCommand.Parameters.Add("@is_archived", SqlDbType.Bit).Value = isArchived;
        //            }
        //            sdaadapter.Fill(dtbl);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    return dtbl;
        //}
        //public void ErrorLogDelete(int Id)
        //{
        //    try
        //    {
        //        using (SqlConnection objConn = new SqlConnection(ConnectionString))
        //        {
        //            objConn.Open();
        //            SqlCommand objCmd = new SqlCommand("ErrorLogArchieved", objConn);
        //            objCmd.CommandType = CommandType.StoredProcedure;
        //            objCmd.Parameters.AddWithValue("@Id", Id);
        //            objCmd.ExecuteNonQuery();
        //            objConn.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }

        //}

        //public void TruncateErrorLog()
        //{
        //    try
        //    {
        //        using (SqlConnection objConn = new SqlConnection(ConnectionString))
        //        {
        //            objConn.Open();
        //            SqlCommand objCmd = new SqlCommand("ErrorLogTruncate", objConn);
        //            objCmd.CommandType = CommandType.StoredProcedure;
        //            objCmd.ExecuteNonQuery();
        //            objConn.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}
        //public void OperationLogTruncate()
        //{
        //    try
        //    {
        //        using (SqlConnection objConn = new SqlConnection(ConnectionString))
        //        {
        //            objConn.Open();
        //            SqlCommand objCmd = new SqlCommand("OperationLogTruncate", objConn);
        //            objCmd.CommandType = CommandType.StoredProcedure;
        //            objCmd.ExecuteNonQuery();
        //            objConn.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}
    }
}
