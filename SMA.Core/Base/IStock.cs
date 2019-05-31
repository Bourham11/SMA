using System.Collections.Generic;

namespace SMA.Core.Base
{
    public interface IStock
    {
        IList<IItem> Items { get; set; }
        decimal TotalCost { get; set; }
        int TotalItemsInStock { get; set; }
    }
}