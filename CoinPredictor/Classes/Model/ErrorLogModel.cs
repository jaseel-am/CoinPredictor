using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinPredictor
{
    public class ErrorLogModel
    {
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }
        public string FunctName { get; set; }
        public string ErrorSource { get; set; }

        public string ComputerName { get; set; }
        public string IPAddress { get; set; }
        public string ComputerUser { get; set; }
        public bool IsArchived { get; set; }

    }
}
