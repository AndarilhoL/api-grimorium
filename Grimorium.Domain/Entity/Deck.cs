using Grimorium.Domain.Entity.Base;
using Grimorium.Domain.Entity.Enums;

namespace Grimorium.Domain.Entity
{
    public sealed class Deck : BaseEntity
    {
        public string? Name { get; private set; }
        public string? Description { get; private set; }
        public IEnumerable<Colors>? Colors { get; private set; }


        public int PlayerId { get; set; }
        public Player? Player { get; set; }
        public int FormatId { get; set; }
        public Format? Format { get; set; }

        public Deck(string? name, string? description, IEnumerable<Colors>? colors)
        {
            Name = name;
            Description = description;
            Colors = colors;
        }
    }
}
