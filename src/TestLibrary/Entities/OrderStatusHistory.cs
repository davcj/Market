using System;
using System.Collections.Generic;

namespace TestLibrary.Entities
{
    public partial class OrderStatusHistory
    {
        public int IdOrderStatusHistory { get; set; }
        public int IdOrder1 { get; set; }
        public int IdOrderStatus1 { get; set; }
        public string StatusUpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? SaveDate { get; set; }
    }
}
