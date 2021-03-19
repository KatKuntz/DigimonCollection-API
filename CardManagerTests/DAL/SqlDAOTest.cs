using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Transactions;

namespace CardManagerTests.DAL
{
    public abstract class SqlDAOTest
    {
        protected const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=DigimonDB;Integrated Security=true";
        private TransactionScope transaction;

        protected int TestSetId { get; private set; }
        protected string TestCardId { get; private set; }

        [TestInitialize]
        public void InitTest()
        {
            transaction = new TransactionScope();
            SeedDatabase();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            transaction.Dispose();
        }

        private void SeedDatabase()
        {
            string query = File.ReadAllText("TestData.sql");

            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            using SqlCommand cmd = new SqlCommand(query, conn);

            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                TestSetId = (int)reader["testSetId"];
                TestCardId = (string)reader["testCardId"];
            }
            else
            {
                throw new Exception("Failed to initialize test data.");
            }
        }

        protected int GetRowCount(string tableName)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = $"SELECT COUNT(*) FROM [dbo].[{tableName}];";

            using SqlCommand cmd = new SqlCommand(query, conn);

            return (int)cmd.ExecuteScalar();
        }
    }
}
