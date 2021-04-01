using System.Collections.Generic;

namespace DigimonCollection.Model
{
    public class Card
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public Color Color { get; set; }
        public CardType Type { get; set; }

        public string Name { get; set; }
        public string PrimaryEffect { get; set; }
        public string SecondaryEffect { get; set; }
        
        public int? Level { get; set; }
        public int? PlayCost { get; set; }
        public int? EvoCost { get; set; }
        public int? DP { get; set; }

        public int SetId { get; set; }
        public Set Set { get; set; }

        public List<Printing> Printings { get; }
    }
}
