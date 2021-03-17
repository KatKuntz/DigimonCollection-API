using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;

namespace CardManagerTests.DAL
{
    public abstract class SqlDAOTest
    {
        protected const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=DigimonDB;Integrated Security=true";
        private TransactionScope transaction;

        [TestInitialize]
        public void InitTest()
        {
            transaction = new TransactionScope();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            transaction.Dispose();
        }
    }
}
