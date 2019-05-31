using SMA.Core.Base;

namespace SMA.Core.Entities
{
    public class Manager : IManager
    {
        public int Id { get ; set ; }
        public string Name {get; set; }
        public string Phone { get ; set; }
        public string Email { get ; set ; }
    }
}
