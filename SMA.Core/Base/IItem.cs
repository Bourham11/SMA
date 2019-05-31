namespace SMA.Core.Base
{
    public interface IItem
    {
        bool InStock { get; set; }
        decimal ItemCost { get; set; }
        IVendor ItemOwner { get; set; }
        int QtyInStock { get; set; }
    }
}