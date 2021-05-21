using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinPredictor
{
    public class SalesModel
    {
        public int SalesId { get; set; }
        public int PurchaseId { get; set; }
        public int UserId { get; set; }
        public int SymbolId { get; set; }
        public double SalesRate { get; set; }
        public int SalesQty { get; set; }
        public DateTime SalesDate { get; set; }
        public double TotalAmount { get; set; }
        public double ProfitorLoss { get; set; }
    }
}
