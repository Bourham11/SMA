using SMA.Core.Base;

namespace SMA.Core.Entities
{
    public class ItemCart : IItemCart
    {
        public IOrder Order { get; set; }
        public IItem Item { get; set; }
        public decimal SubPrice { get; set; }
        public int Qty { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
