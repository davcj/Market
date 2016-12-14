using System;
using System.Collections.Generic;

namespace TestLibrary.Entities
{
    public partial class TradingObject
    {
        public TradingObject()
        {
            Order = new HashSet<Order>();
            SocialMedia = new HashSet<SocialMedia>();
            Tick = new HashSet<Tick>();
            Trader = new HashSet<Trader>();
        }

        public int IdTradingObject { get; set; }
        public int? IdTrader { get; set; }
        public string Name { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<SocialMedia> SocialMedia { get; set; }
        public virtual ICollection<Tick> Tick { get; set; }
        public virtual ICollection<Trader> Trader { get; set; }
        public virtual Trader IdTraderNavigation { get; set; }
    }
}
