using System.Collections.Generic;

namespace DigimonCollection.Model
{
    public class Collection
    {
        public int Id { get; set; }
        public List<OwnedPrinting> OwnedPrintings { get; set; }
    }
}
