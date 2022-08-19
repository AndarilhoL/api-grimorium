using Grimorium.Domain.Entity.Base;
using Grimorium.Domain.Entity.Enums;

namespace Grimorium.Domain.Entity
{
    public class Cards : BaseEntity
    {
        public string? Name { get; private set; }
        public int CMC { get; private set; }
        public string? Type { get; set; }
        public List<string>? Types { get; set; }
        public string? Text { get; set; }
        public string? ImageUrl { get; private set; }
        public IEnumerable<Colors>? ColorIdentity { get; private set; }
        public IEnumerable<Format>? Legality { get; set; }

    }
}
