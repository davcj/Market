using System;
using System.Collections.Generic;

namespace BusinessObjectLayer.Entities
{
    public partial class AssetBalance
    {
        public AssetBalance()
        {
            Trader = new HashSet<Trader>();
        }

        public int IdAssetBalance { get; set; }
        public int? IdTrader { get; set; }
        public decimal? Balance { get; set; }
        public decimal? FrozenBalance { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? SaveDate { get; set; }

        public virtual ICollection<Trader> Trader { get; set; }
        public virtual Trader IdTraderNavigation { get; set; }
    }
}
