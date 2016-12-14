using System;
using System.Collections.Generic;

namespace TestLibrary.Entities
{
    public partial class Tick
    {
        public int IdTick { get; set; }
        public int IdTradingObject { get; set; }
        public decimal Buy { get; set; }
        public decimal Sell { get; set; }
        public DateTime DateTime { get; set; }

        public virtual TradingObject IdTradingObjectNavigation { get; set; }
    }
}
