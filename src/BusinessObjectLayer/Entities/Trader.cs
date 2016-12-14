using System;
using System.Collections.Generic;

namespace BusinessObjectLayer.Entities
{
    public partial class Trader
    {
        public Trader()
        {
            AssetBalance = new HashSet<AssetBalance>();
            OrderIdTraderANavigation = new HashSet<Order>();
            OrderIdTraderBNavigation = new HashSet<Order>();
            TradingObject = new HashSet<TradingObject>();
        }

        public int IdTrader { get; set; }
        public int? IdTradingObject { get; set; }
        public int? IdAssetType { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? SaveDate { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<AssetBalance> AssetBalance { get; set; }
        public virtual ICollection<Order> OrderIdTraderANavigation { get; set; }
        public virtual ICollection<Order> OrderIdTraderBNavigation { get; set; }
        public virtual ICollection<TradingObject> TradingObject { get; set; }
        public virtual AssetBalance IdAssetTypeNavigation { get; set; }
        public virtual TradingObject IdTradingObjectNavigation { get; set; }
    }
}
