using CardManager.DAL;
using CardManager.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;

namespace CardManagerTests.DAL
{
    [TestClass]
    public class SqlPrintingDAOTests : SqlDAOTest
    {
        [TestMethod]
        public void AddPrinting_AddsRowToTable()
        {
            int initialRowCount = GetRowCount("Printing");

            IPrintingDAO dao = new SqlPrintingDAO(connectionString);
            dao.AddPrinting(new Printing()
            {
                CardId = TestCardId,
                AlternateArt = false
            });

            int finalRowCount = GetRowCount("Printing");

            Assert.AreEqual(1, finalRowCount - initialRowCount);
        }

        [TestMethod]
        public void AddPrinting_TestAddedValues()
        {
            IPrintingDAO dao = new SqlPrintingDAO(connectionString);
            Printing newPrinting = new Printing()
            {
                CardId = TestCardId,
                AlternateArt = false
            };

            dao.AddPrinting(newPrinting);

            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT Id, CardId, AlternateArt FROM [dbo].[Printing] WHERE Id=@id;";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", newPrinting.PrintingId);

            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Assert.AreEqual(newPrinting.PrintingId, (int)reader["Id"]);
                Assert.AreEqual(newPrinting.CardId, (string)reader["CardId"]);
                Assert.AreEqual(newPrinting.AlternateArt, (bool)reader["AlternateArt"]);
            }
            else
            {
                Assert.Fail("Failed to read printing from database");
            }
        }
    }
}
