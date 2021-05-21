using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace CoinPredictor
{
    public class ReportDal : DBConnection
    {
        public DataTable ProfitOrLossReport()
        {
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SLNO", typeof(decimal));
            dtbl.Columns["SLNO"].AutoIncrement = true;
            dtbl.Columns["SLNO"].AutoIncrementSeed = 1;
            dtbl.Columns["SLNO"].AutoIncrementStep = 1;
            try
            {
                using (SqlConnection objConn = new SqlConnection(ConnectionString))
                {
                    if (objConn.State == ConnectionState.Closed)
                    {
                        objConn.Open();
                    }
                    SqlDataAdapter sdaadapter = new SqlDataAdapter("ProfitOrLossReport", objConn);
                    sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sdaadapter.Fill(dtbl);
                }
            }
            catch (Exception ex)
            {
                LogData.LoggError(ex.Message, "ProfitOrLossReport", ex.ToString());
            }
            return dtbl;
        }
        public DataSet PerfomanceMatrix()
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
                    SqlDataAdapter sdaadapter = new SqlDataAdapter("ReportPerfomanceMatrix", objConn);
                    sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sdaadapter.Fill(dsData);
                }
            }
            catch (Exception ex)
            {
                LogData.LoggError(ex.Message, "PerfomanceMatrix", ex.ToString());
            }
            return dsData;
        }
    }
}
