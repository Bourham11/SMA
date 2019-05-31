using System;

namespace SMA.Core.Base
{
    public interface IVendor : IPerson
    {
        decimal NextPaymentAmount { get; set; }
        DateTime NextPaymentDate { get; set; }
        string PaymentType { get; set; }
        decimal TotalPayments { get; set; }
    }
}