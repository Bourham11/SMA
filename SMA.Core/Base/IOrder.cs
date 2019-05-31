using System;

namespace SMA.Core.Base
{
    public interface IOrder
    {
        ICustomer Customer { get; set; }
        decimal DiscountAmount { get; set; }
        IEmployee Employee { get; set; }
        decimal GrandTotal { get; set; }
        bool HasDiscount { get; set; }
        DateTime OrderDate { get; set; }
        int OrderId { get; set; }
        decimal SubTotal { get; set; }
        decimal Tax { get; set; }
    }
}