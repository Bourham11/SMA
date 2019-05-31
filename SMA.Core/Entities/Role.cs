using SMA.Core.Base;

namespace SMA.Core.Entities
{
    public class Role : IRole
    {
        public int Id { get; set; }
        public string UserCredential { get; set; }
    }
}
