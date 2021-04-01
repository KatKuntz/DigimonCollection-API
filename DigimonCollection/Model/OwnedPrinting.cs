namespace DigimonCollection.Model
{
    public class OwnedPrinting
    {
        public int Id { get; set; }

        public Printing Printing { get; set; }
        public int Count { get; set; }
    }
}
