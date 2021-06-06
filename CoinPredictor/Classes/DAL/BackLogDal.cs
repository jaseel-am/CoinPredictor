using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace CoinPredictor
{
    public class BackLogDal : DBConnection
    {
        public void BackLogInsert(BackLogModel objModel)
        {
            object result = new object();
            object result_RawRprtId = new object();
            try
            {
                using (SqlConnection objConn = new SqlConnection(ConnectionString))
                {
                    objConn.Open();
                    SqlCommand objCmd = new SqlCommand("BackLogInsert", objConn);
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Symbol", (object)objModel.Symbol ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@Description", (object)objModel.Description ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@LogDate", (object)objModel.LogDate ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@HighVal", (object)objModel.HighVal ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@LowVal", (object)objModel.LowVal ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@CloseVal", (object)objModel.CloseVal ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@TotalVolume", (object)objModel.TotalVolume ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@True_Range", (object)objModel.True_Range ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@ATR_2", (object)objModel.ATR_2 ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@ATR_5", (object)objModel.ATR_5 ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@ATR_14", (object)objModel.ATR_14 ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@ROC_2", (object)objModel.ROC_2 ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@ROC_5", (object)objModel.ROC_5 ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@ROC_14", (object)objModel.ROC_14 ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@NATR_2", (object)objModel.NATR_2 ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@NATR_5", (object)objModel.NATR_5 ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@NATR_14", (object)objModel.NATR_14 ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@PPRatio", (object)objModel.PPRatio ?? (object)DBNull.Value);
                    objCmd.ExecuteNonQuery();
                    objConn.Close();
                }
            }
            catch (Exception ex)
            {
                LogData.LoggError(ex.Message, "InsertBackLog", ex.ToString());
            }
        }
        public void BackLogClearBySymbol(BackLogModel objModel)
        {
            object result = new object();
            object result_RawRprtId = new object();
            try
            {
                using (SqlConnection objConn = new SqlConnection(ConnectionString))
                {
                    objConn.Open();
                    SqlCommand objCmd = new SqlCommand("BackLogClearBySymbol", objConn);
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Symbol", (object)objModel.Symbol ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@Description", (object)objModel.Description ?? (object)DBNull.Value);
                    objCmd.ExecuteNonQuery();
                    objConn.Close();
                }
            }
            catch (Exception ex)
            {
                LogData.LoggError(ex.Message, "BackLogClearBySymbol", ex.ToString());
            }
        }

        public DataTable GetCloseValue(int inSymbol, DateTime dtFrom)
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
                    SqlDataAdapter sdaadapter = new SqlDataAdapter("GetCloseValue", objConn);
                    sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sdaadapter.SelectCommand.Parameters.AddWithValue("@SymbolId", inSymbol);
                    sdaadapter.SelectCommand.Parameters.AddWithValue("@FromDate", dtFrom);
                    sdaadapter.Fill(dtbl);
                }
            }
            catch (Exception ex)
            {
                LogData.LoggError(ex.Message, "RawreportSearch", ex.ToString());
            }
            return dtbl;
        }

        public DataTable SymbolGetAllForDropdown()
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
                    SqlDataAdapter sdaadapter = new SqlDataAdapter("SymbolsGetAll", objConn);
                    sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sdaadapter.Fill(dtbl);
                }
            }
            catch (Exception ex)
            {
                LogData.LoggError(ex.Message, "RawreportSearch", ex.ToString());
            }
            return dtbl;
        }


    }
}
