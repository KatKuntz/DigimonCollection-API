using CardManager.Models;
using System;

namespace CardManager.DAL
{
    class SqlCardDAO : ICardDAO
    {
        private readonly string connectionString;

        public SqlCardDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddCard(Card card)
        {
            throw new NotImplementedException();
        }
    }
}
