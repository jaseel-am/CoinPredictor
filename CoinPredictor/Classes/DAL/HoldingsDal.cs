using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CoinPredictor
{
   public class HoldingsDal:DBConnection
    {
        public DataSet GetHoldings(int inUserId, int inSymbolId, DateTime dtToDate)
        {
            DataSet dsData = new DataSet();
            try
            {
                using (SqlConnection objConn = new SqlConnection(ConnectionString))
                {
                    if (objConn.State == ConnectionState.Closed)
                    {
                        objConn.Open();
                    }
                    SqlDataAdapter sdaadapter = new SqlDataAdapter("GetHoldings", objConn);
                    sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sdaadapter.SelectCommand.Parameters.AddWithValue("@UserId", inUserId);
                    sdaadapter.SelectCommand.Parameters.AddWithValue("@SymbolId", inSymbolId);
                    sdaadapter.SelectCommand.Parameters.AddWithValue("@ToDate", dtToDate);
                    sdaadapter.Fill(dsData);
                }
            }
            catch (Exception ex)
            {
                LogData.LoggError(ex.Message, "RawreportSearch", ex.ToString());
            }
            return dsData;
        }
        public int SalesAdd(SalesModel objModel)
        {
            object result = new object();
            try
            {
                using (SqlConnection objConn = new SqlConnection(ConnectionString))
                {
                    objConn.Open();
                    SqlCommand objCmd = new SqlCommand("SalesAdd", objConn);
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@UserId", (object)objModel.UserId ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@SymbolId", (object)objModel.SymbolId ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@SalesRate", (object)objModel.SalesRate ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@SalesQty", (object)objModel.SalesQty ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@SalesDate", (object)objModel.SalesDate ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@TotalAmount", (object)objModel.TotalAmount ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@PurchaseId", (object)objModel.PurchaseId ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@ProfitorLoss", (object)objModel.ProfitorLoss ?? (object)DBNull.Value);
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
    }
}
