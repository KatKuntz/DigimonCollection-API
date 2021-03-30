using System;
using System.Collections.Generic;

namespace DigimonCollection.Model
{
    public class Set
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }

        public List<Card> Cards { get; set; }
    }
}
