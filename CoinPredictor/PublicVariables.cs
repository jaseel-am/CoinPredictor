using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinPredictor
{
    public static class PublicVariables
    {
        public static decimal _decCurrentUserId = 1;
        public static decimal _decCurrentCompanyId = 0;
        public static DateTime _dtCurrentDate;
        public static DateTime _dtFromDate;//financial year starting    
        public static DateTime _dtToDate;//financial year ending         
        public static decimal _decCurrentFinancialYearId = 1;
        public static bool isMessageAdd = true;
        public static bool isMessageEdit = true;
        public static bool isMessageDelete = true;
        public static bool isMessageClose = true;
        public static decimal _decCurrencyId = 1;
        public static int _inNoOfDecimalPlaces = 2;
        public static string MessageToShow = string.Empty;
        public static string MessageHeadear = string.Empty;
    }
}
