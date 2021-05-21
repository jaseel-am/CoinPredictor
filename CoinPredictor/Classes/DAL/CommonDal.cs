using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CoinPredictor
{
    public class CommonDal :DBConnection
    {
        public void ClearAllTransactions(string strType)
        {
            object result = new object();
            object result_RawRprtId = new object();
            try
            {
                using (SqlConnection objConn = new SqlConnection(ConnectionString))
                {
                    objConn.Open();
                    SqlCommand objCmd = new SqlCommand("ClearAllTransactions", objConn);
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@OpsMode", (object)strType ?? (object)DBNull.Value);
                    objCmd.ExecuteNonQuery();
                    objConn.Close();
                }
            }
            catch (Exception ex)
            {
                LogData.LoggError(ex.Message, "ClearAllTransactions", ex.ToString());
            }
        }
    }
}
