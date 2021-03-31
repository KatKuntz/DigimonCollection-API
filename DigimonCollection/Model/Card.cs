using System.Collections.Generic;

namespace DigimonCollection.Model
{
    public class Card
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public Color Color { get; set; }

        public int SetId { get; set; }
        public Set Set { get; set; }

        public List<Printing> Printings { get; }
    }
}
