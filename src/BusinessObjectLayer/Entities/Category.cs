using System;
using System.Collections.Generic;

namespace BusinessObjectLayer.Entities
{
    public partial class Category
    {
        public Category()
        {
            TradingObjectCategory = new HashSet<TradingObjectCategory>();
        }

        public int IdCategory { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public int? ParentCategory { get; set; }
        public string Description { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<TradingObjectCategory> TradingObjectCategory { get; set; }
    }
}
