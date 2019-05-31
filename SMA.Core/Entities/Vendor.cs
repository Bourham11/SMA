using SMA.Core.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMA.Core.Entities
{
    public class Vendor : IPerson, IVendor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string PaymentType { get; set; }
        public decimal NextPaymentAmount { get; set; }
        public DateTime NextPaymentDate { get; set; }
        public decimal TotalPayments { get; set; }
    }
}
