using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
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

        protected int GetRowCount(string tableName)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = $"SELECT COUNT(*) FROM [dbo].[{tableName}];";

            SqlCommand cmd = new SqlCommand(query, conn);

            return (int)cmd.ExecuteScalar();
        }
    }
}
