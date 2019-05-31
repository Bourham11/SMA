using SMA.Core.Base;

namespace SMA.Core.Entities
{
    class ServiceCart : IServiceCart
    {
        public IProduct Service { get; set; }
        public IOrder Order { get ; set ; }
        public decimal TotalPrice { get ; set ; }
    }
}
