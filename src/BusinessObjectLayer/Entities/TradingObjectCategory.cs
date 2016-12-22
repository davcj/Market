using System;
using System.Collections.Generic;

namespace BusinessObjectLayer.Entities
{
    public partial class TradingObjectCategory
    {
        public int IdCategory { get; set; }
        public int IdTradingObject { get; set; }

        public virtual Category IdCategoryNavigation { get; set; }
        public virtual TradingObject IdTradingObjectNavigation { get; set; }
    }
}
