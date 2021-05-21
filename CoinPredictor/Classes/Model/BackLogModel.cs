using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinPredictor
{
    public class BackLogModel
    {
        public int BackLogId { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }
        public DateTime LogDate { get; set; }
        public double OpenVal { get; set; }
        public double HighVal { get; set; }
        public double LowVal { get; set; }
        public double CloseVal { get; set; }
        public long TotalVolume { get; set; }

        public double True_Range { get; set; }
        public double ATR_2 { get; set; }
        public double ATR_5 { get; set; }
        public double ATR_14 { get; set; }
        public double ROC_2 { get; set; }
        public double ROC_5 { get; set; }
        public double ROC_14 { get; set; }
        public double NATR_2 { get; set; }
        public double NATR_5 { get; set; }
        public double NATR_14 { get; set; }
        public double PPRatio { get; set; }
    }
}
