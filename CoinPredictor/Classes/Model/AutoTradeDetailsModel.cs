using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinPredictor
{
    public class AutoTradeDetailsModel
    {
        public int AutoTradeDetailsId { get; set; }
        public int AutoTradeId { get; set; }
        public int SymbolId { get; set; }
        public DateTime EntryDate { get; set; }
        public double EntryPrice { get; set; }
        public DateTime ExitDate { get; set; }
        public double ExitPrice { get; set; }
        public double Qty { get; set; }
        public double ProfitorLoss { get; set; }
        public double ClosingBalance { get; set; }
        public string ExitOn { get; set; }
    }
}
