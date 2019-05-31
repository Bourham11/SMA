namespace SMA.Core.Base
{
    public interface IItemCart
    {
        IItem Item { get; set; }
        int Qty { get; set; }
        decimal SubPrice { get; set; }
    }
}