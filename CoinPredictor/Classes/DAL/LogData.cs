using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinPredictor
{
    public static class LogData
    {

        public static void LoggError(string ErrorMessage, string FunctName, string StackTrace)
        {
            try
            {
                MessageBox.Show(ErrorMessage, FunctName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                //ErrorLogDal spErrorLog = new ErrorLogDal();
                //ErrorLogModel objModel = new ErrorLogModel();
                //objModel.ErrorMessage = ErrorMessage;
                //objModel.ErrorSource = "Application";
                //objModel.FunctName = FunctName;
                //objModel.StackTrace = StackTrace;
                //spErrorLog.ErrorLogAdd(objModel);
            }
            catch (Exception)
            {
                throw;
            }
        }
        //public static long LoggOperations(int inOprId,int TemplateId, int UserId, string Status, int LastStepId, string Message,string OpsMode)
        //{
        //    long lnId = 0;
        //    try
        //    {
        //        OperationLogDAL objOprLog = new OperationLogDAL();
        //        OperationLogModel objModel = new OperationLogModel();
        //        objModel.Id = inOprId;
        //        objModel.EnrichedTemplateId = TemplateId;
        //        objModel.UserId = UserId;
        //        objModel.StartTime = DateTime.Now;
        //        objModel.EndTime = DateTime.Now;
        //        objModel.Status = Status;
        //        objModel.LastStepId = LastStepId;
        //        objModel.Message = Message;
        //        objModel.OpsMode = OpsMode;
        //        lnId= objOprLog.OperationLogInsert(objModel);
        //    }
        //    catch (Exception ex)
        //    {
        //        LoggError(ex.Message, "LogData-LoggOperations", ex.StackTrace);
        //    }
        //    return lnId;
        //}
    }
}
