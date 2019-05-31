using SMA.Core.Base;

namespace SMA.Core.Entities
{
    public class User : IUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
