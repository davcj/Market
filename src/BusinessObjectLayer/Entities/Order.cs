using System;
using System.Collections.Generic;

namespace BusinessObjectLayer.Entities
{
    public partial class Order
    {
        public int IdOrder { get; set; }
        public int IdTradingObject { get; set; }
        public int IdTraderA { get; set; }
        public int IdTraderB { get; set; }
        public int IdOrderType { get; set; }
        public int IdOfferAssetType { get; set; }
        public int IdWantAssetType { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int IdOrderStatus { get; set; }
        public int? IdOriginalOrder { get; set; }
        public bool? MarketOrder { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? IdTakeProfitOrder { get; set; }
        public int? IdStopLossOrder { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? SaveDate { get; set; }

        public virtual Trader IdTraderANavigation { get; set; }
        public virtual Trader IdTraderBNavigation { get; set; }
        public virtual TradingObject IdTradingObjectNavigation { get; set; }
    }
}
