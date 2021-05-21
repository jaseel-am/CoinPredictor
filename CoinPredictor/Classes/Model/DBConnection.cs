using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CoinPredictor
{
    public class DBConnection
    {
        protected string ConnectionString = string.Empty;
        public DBConnection()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DBCoinPredict"].ConnectionString;
        }
    }
}
