using CardManager.Models;
using System;

namespace CardManager.DAL
{
    class SqlSetDAO : ISetDAO
    {
        private readonly string connectionString;

        public SqlSetDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddSet(Set set)
        {
            throw new NotImplementedException();
        }
    }
}
