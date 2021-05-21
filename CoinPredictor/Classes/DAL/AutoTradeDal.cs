using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CoinPredictor
{
    public class AutoTradeDal : DBConnection
    {
        public double GetAutoTradeCurrentBalance()
        {
            object result = new object();
            double decBalance = 0;
            try
            {
                using (SqlConnection objConn = new SqlConnection(ConnectionString))
                {
                    objConn.Open();
                    SqlCommand objCmd = new SqlCommand("GetAutoTradeCurrentBalance", objConn);
                    objCmd.CommandType = CommandType.StoredProcedure;
                    result = objCmd.ExecuteScalar();
                    objConn.Close();
                    decBalance = result.ToString().AsDouble();
                }
            }
            catch (Exception ex)
            {
                LogData.LoggError(ex.Message, "GetAutoTradeCurrentBalance", ex.ToString());
            }
            return decBalance;
        }
        public int AutoTradeMasterInsert(AutoTradeModel objModel)
        {
            object result = new object();
            int inRetId = 0;
            try
            {
                using (SqlConnection objConn = new SqlConnection(ConnectionString))
                {
                    objConn.Open();
                    SqlCommand objCmd = new SqlCommand("AutoTradeInsert", objConn);
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@SymbolId", (object)objModel.SymbolId ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@StartDate", (object)objModel.StartDate ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@EndDate", (object)objModel.EndDate ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@Duration", (object)objModel.Duration ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@OpeningBalance", (object)objModel.OpeningBalance ?? (object)DBNull.Value);
                    result = objCmd.ExecuteScalar();
                    objConn.Close();
                    inRetId = result.ToString().AsInt();
                }
            }
            catch (Exception ex)
            {
                LogData.LoggError(ex.Message, "AutoTradeMasterInsert", ex.ToString());
            }
            return inRetId;
        }
        public int AutoTradeDetailsInsert(AutoTradeDetailsModel objModel)
        {
            object result = new object();
            int inRetId = 0;
            try
            {
                using (SqlConnection objConn = new SqlConnection(ConnectionString))
                {
                    objConn.Open();
                    SqlCommand objCmd = new SqlCommand("AutoTradeDetailsInsert", objConn);
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@AutoTradeId", (object)objModel.AutoTradeId ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@EntryDate", (object)objModel.EntryDate ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@EntryPrice", (object)objModel.EntryPrice ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@ExitDate", (object)objModel.ExitDate ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@ExitPrice", (object)objModel.ExitPrice ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@Qty", (object)objModel.Qty ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@ProfitorLoss", (object)objModel.ProfitorLoss ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@ClosingBalance", (object)objModel.ClosingBalance ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@ExitOn", (object)objModel.ExitOn ?? (object)DBNull.Value);
                    result = objCmd.ExecuteScalar();
                    objConn.Close();
                    inRetId = result.ToString().AsInt();
                }
            }
            catch (Exception ex)
            {
                LogData.LoggError(ex.Message, "AutoTradeDetailsInsert", ex.ToString());
            }
            return inRetId;
        }

        public DataTable GetAutoTradeReport()
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
                    SqlDataAdapter sdaadapter = new SqlDataAdapter("GetAutoTradeReport", objConn);
                    sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sdaadapter.Fill(dtbl);
                }
            }
            catch (Exception ex)
            {
                LogData.LoggError(ex.Message, "GetAutoTradeReport", ex.ToString());
            }
            return dtbl;
        }
        public DataSet GetAutoTradePerfomanceMatrixReport()
        {
            DataSet DsData = new DataSet();
            try
            {
                using (SqlConnection objConn = new SqlConnection(ConnectionString))
                {
                    if (objConn.State == ConnectionState.Closed)
                    {
                        objConn.Open();
                    }
                    SqlDataAdapter sdaadapter = new SqlDataAdapter("AutoTradePerfomanceMatrixReport", objConn);
                    sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sdaadapter.Fill(DsData);
                }
            }
            catch (Exception ex)
            {
                LogData.LoggError(ex.Message, "GetAutoTradePerfomanceMatrixReport", ex.ToString());
            }
            return DsData;
        }
        

    }
}
