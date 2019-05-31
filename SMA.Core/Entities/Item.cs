using SMA.Core.Base;

namespace SMA.Core.Entities
{
    public class Item : IProduct, IItem
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal SellPrice { get; set; }

        public int QtyInStock { get; set; }
        public decimal ItemCost { get; set; }
        public IVendor ItemOwner { get; set; }
        public bool InStock { get; set; }
    }
}
