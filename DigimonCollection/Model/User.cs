using System.Collections.Generic;

namespace DigimonCollection.Model
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public List<Collection> Collections { get; }
    }
}
