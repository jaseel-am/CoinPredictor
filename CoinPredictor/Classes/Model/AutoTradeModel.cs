using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinPredictor
{
    public class AutoTradeModel
    {
        public int AutoTradeId { get; set; }
        public int SymbolId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Duration { get; set; }
        public double OpeningBalance { get; set; }
    }
}
