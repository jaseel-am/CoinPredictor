using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;



namespace CoinPredictor
{
    public class PurcahseDal : DBConnection
    {
        public DataTable OpeningBalanceGet()
        {
            DataTable dtbl = new DataTable();
            try
            {
                using (SqlConnection objConn = new SqlConnection(ConnectionString))
                {
                    if (objConn.State == ConnectionState.Closed)
                    {
                        objConn.Open();
                    }
                    SqlDataAdapter sdaadapter = new SqlDataAdapter("OpeningBalanceGet", objConn);
                    sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sdaadapter.Fill(dtbl);
                }
            }
            catch (Exception ex)
            {
                LogData.LoggError(ex.Message, "OpeningBalanceGet", ex.ToString());
            }
            return dtbl;
        }
        public DataTable CurrentBalanceGet()
        {
            DataTable dtbl = new DataTable();
            try
            {
                using (SqlConnection objConn = new SqlConnection(ConnectionString))
                {
                    if (objConn.State == ConnectionState.Closed)
                    {
                        objConn.Open();
                    }
                    SqlDataAdapter sdaadapter = new SqlDataAdapter("CurrentBalanceGet", objConn);
                    sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sdaadapter.Fill(dtbl);
                }
            }
            catch (Exception ex)
            {
                LogData.LoggError(ex.Message, "OpeningBalanceGet", ex.ToString());
            }
            return dtbl;
        }
        public int PurchaseAdd(PurchaseModel objModel)
        {
            object result = new object();
            try
            {
                using (SqlConnection objConn = new SqlConnection(ConnectionString))
                {
                    objConn.Open();
                    SqlCommand objCmd = new SqlCommand("PurchaseAdd", objConn);
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@UserId", (object)objModel.UserId ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@SymbolId", (object)objModel.SymbolId ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@PurchaseRate", (object)objModel.PurchaseRate ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@PurchaseQty", (object)objModel.PurchaseQty ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@PurchaseDate", (object)objModel.PurchaseDate ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@TotalAmount", (object)objModel.TotalAmount ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@ProfitTarget", (object)objModel.ProfitTarget ?? (object)DBNull.Value);
                    result = objCmd.ExecuteScalar().ToString();
                    objConn.Close();
                }
            }
            catch (Exception ex)
            {
                LogData.LoggError(ex.Message, "PurchaseAdd", ex.ToString());
                return 0;
            }
            return result.ToString().AsInt();
        }

        public DataTable GetValuesForAutoTrade(int inSymbolId, DateTime dtfrom, DateTime dtTo)
        {
            DataTable dtbl = new DataTable();
            try
            {
                using (SqlConnection objConn = new SqlConnection(ConnectionString))
                {
                    if (objConn.State == ConnectionState.Closed)
                    {
                        objConn.Open();
                    }
                    SqlDataAdapter sdaadapter = new SqlDataAdapter("GetValuesForAutoTrade", objConn);
                    sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sdaadapter.SelectCommand.Parameters.AddWithValue("@SymbolId", inSymbolId);
                    sdaadapter.SelectCommand.Parameters.AddWithValue("@FromDate", dtfrom);
                    sdaadapter.SelectCommand.Parameters.AddWithValue("@ToDate", dtTo);
                    sdaadapter.Fill(dtbl);
                }
            }
            catch (Exception ex)
            {
                LogData.LoggError(ex.Message, "OpeningBalanceGet", ex.ToString());
            }
            return dtbl;
        }

    }
}
