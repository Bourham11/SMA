using SMA.Core.Base;

namespace SMA.Core.Entities
{
    class Service : IProduct
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal SellPrice { get; set; }
    }
    
}
