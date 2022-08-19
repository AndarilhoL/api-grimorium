using Grimorium.Domain.Entity.Base;

namespace Grimorium.Domain.Entity
{
    public sealed class Player : BaseEntity
    {
        public string? Name { get; private set; }
        public string? Nickname { get; set; }
        public int Age { get; private set; }
        public string? Country { get; private set; }
        public string? State { get; private set; }
        public string? UrlPhoto { get; private set; }
        public bool IsCommanderPlayer { get; private set; }


        public int DeckId { get; set; }
        public List<Deck>? Decks { get; set; }

        public Player(string? name, string? nickname)
        {
            Name = name;
            Nickname = nickname;
        }
    }
}
