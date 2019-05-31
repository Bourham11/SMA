namespace SMA.Core.Base
{
    public interface IUser
    {
        int UserId { get; set; }
        string UserName { get; set; }
        string UserPassword { get; set; }
    }
}