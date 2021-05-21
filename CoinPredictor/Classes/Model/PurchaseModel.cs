using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinPredictor
{
    public class PurchaseModel
    {
        public int PurchaseId { get; set; }
        public int UserId { get; set; }
        public int SymbolId { get; set; }
        public double PurchaseRate { get; set; }
        public int PurchaseQty { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double TotalAmount { get; set; }
        public double ProfitTarget { get; set; }
    }
}
