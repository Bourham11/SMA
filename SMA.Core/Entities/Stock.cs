using SMA.Core.Base;
using System.Collections.Generic;

namespace SMA.Core.Entities
{
    public class Stock : IStock
    {
        public IList<IItem> Items { get; set; }
        public int TotalItemsInStock { get; set; }
        public decimal TotalCost { get; set; }
    }
}
