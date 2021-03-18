using CardManager.DAL;
using CardManager.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;

namespace CardManagerTests.DAL
{
    [TestClass]
    public class SqlCardDAOTests : SqlDAOTest
    {
        [TestMethod]
        public void AddCard_AddsCardToTable()
        {
            int initialRowCount = GetRowCount("Card");

            ICardDAO dao = new SqlCardDAO(connectionString);
            dao.AddCard(new Card()
            {
                CardId = "TES-001",
                SetId = TestSetId,
                Name = "TestCard",
                Color = "Red",
                Type = "Tamer"
            });

            int finalRowCount = GetRowCount("Card");

            Assert.AreEqual(1, finalRowCount - initialRowCount);
        }

        [TestMethod]
        public void AddCard_TestAddedValues()
        {
            ICardDAO dao = new SqlCardDAO(connectionString);
            Card newCard = new Card()
            {
                CardId = "TES-001",
                SetId = TestSetId,
                Name = "TestCard",
                Color = "Red",
                Type = "Tamer"
            };

            dao.AddCard(newCard);

            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT Id, SetId, Name, Color, Type FROM [dbo].[Card] WHERE Id = @id;";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", newCard.CardId);

            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Assert.AreEqual(newCard.CardId, (string)reader["Id"]);
                Assert.AreEqual(newCard.SetId, (int)reader["SetId"]);
                Assert.AreEqual(newCard.Name, (string)reader["Name"]);
                Assert.AreEqual(newCard.Color, (string)reader["Color"]);
                Assert.AreEqual(newCard.Type, (string)reader["Type"]);
            } else
            {
                Assert.Fail();
            }
        }
    }
}
