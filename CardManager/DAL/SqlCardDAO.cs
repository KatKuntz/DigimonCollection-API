using CardManager.Models;
using CardManager.Utility;
using System;
using System.Data.SqlClient;

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
            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = "INSERT INTO [dbo].[Card](Id, SetId, Name, Color, Type) " +
                               "VALUES (@id, @setId, @name, @color, @type);";

                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(new SqlParameter[]
                {
                new SqlParameter("@id", card.CardId),
                new SqlParameter("@setId", card.SetId),
                new SqlParameter("@name", card.Name),
                new SqlParameter("@color", card.Color),
                new SqlParameter("@type", card.Type)
                });

                if (cmd.ExecuteNonQuery() != 1)
                {
                    throw new DAOException("Attempt to add card changed more than one row");
                }
            } 
            catch (SqlException ex)
            {
                throw new DAOException("Failed to add card", ex);
            }
        }
    }
}
