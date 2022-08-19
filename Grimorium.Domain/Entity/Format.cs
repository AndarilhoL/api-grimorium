using Grimorium.Domain.Entity.Base;

namespace Grimorium.Domain.Entity
{
    public class Format : BaseEntity
    {
        public string? Name { get; private set; }
        public string? Description { get; set; }

        public Format(string? name, string? description)
        {
            Name = name;
            Description = description;
        }
    }
}
