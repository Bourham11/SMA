using SMA.Core.Base;
using System;

namespace SMA.Core.Entities
{
    public class Order : IOrder
    {
        public int OrderId { get; set; }
        public bool HasDiscount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal GrandTotal { get; set; }
        public DateTime OrderDate { get; set; }
        public ICustomer Customer { get; set; }
        public IEmployee Employee { get; set; }
    }
}
