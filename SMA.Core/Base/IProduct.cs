namespace SMA.Core.Base
{
    public interface IProduct
    {
        string Code { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        decimal SellPrice { get; set; }
    }
}