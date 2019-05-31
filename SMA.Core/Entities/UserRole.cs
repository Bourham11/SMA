using SMA.Core.Base;

namespace SMA.Core.Entities
{
    public class UserRole : IUserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
