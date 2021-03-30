namespace DigimonCollection.Model
{
    public class Printing
    {
        public int Id { get; set; }
        public string ArtUrl { get; set; }

        public int CardId { get; set; }
        public Card Card { get; set; }
    }
}
