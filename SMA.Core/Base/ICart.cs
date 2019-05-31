namespace SMA.Core.Base
{
    public interface ICart
    {
        IOrder Order { get; set; }
        decimal TotalPrice { get; set; }
    }
}