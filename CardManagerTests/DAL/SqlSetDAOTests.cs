using CardManager.DAL;
using CardManager.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;

namespace CardManagerTests.DAL
{
    [TestClass]
    public class SqlSetDAOTests : SqlDAOTest
    {
        [TestMethod]
        public void AddSet_AddsRowToTable()
        {
            int initialRowCount = GetRowCount("Set");

            ISetDAO dao = new SqlSetDAO(connectionString);
            dao.AddSet(new Set()
            {
                Name = "Test Set",
                ReleaseDate = DateTime.Today
            });

            int finalRowCount = GetRowCount("Set");

            Assert.AreEqual(1, finalRowCount - initialRowCount);
        }

        [TestMethod]
        public void AddSet_TestAddedValues()
        {
            ISetDAO dao = new SqlSetDAO(connectionString);
            Set newSet = new Set()
            {
                Name = "Test Set",
                ReleaseDate = DateTime.Now
            };

            dao.AddSet(newSet);

            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT Id, Name, ReleaseDate FROM [dbo].[Set] WHERE Id=@id;";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", newSet.SetId);

            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Assert.AreEqual(newSet.SetId, (int)reader["Id"]);
                Assert.AreEqual(newSet.Name, (string)reader["Name"]);
                Assert.AreEqual(newSet.ReleaseDate, (DateTime)reader["ReleaseDate"]);
            } else
            {
                Assert.Fail();
            }
        }
    }
}
