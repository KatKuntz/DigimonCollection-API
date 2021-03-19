using CardManager.Models;
using CardManager.Utility;
using System.Data.SqlClient;

namespace CardManager.DAL
{
    class SqlPrintingDAO : IPrintingDAO
    {
        private readonly string connectionString;

        public SqlPrintingDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddPrinting(Printing printing)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = "INSERT INTO Printing(CardId, AlternateArt) " +
                               "VALUES (@cardId, @altArt);" +
                               "SELECT CAST(SCOPE_IDENTITY() AS Int);";

                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(new SqlParameter[]
                {
                    new SqlParameter("@cardId", printing.CardId),
                    new SqlParameter("@altArt", printing.AlternateArt)
                });

                printing.PrintingId = (int)cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new DAOException("Failed to add printing", ex);
            }
        }
    }
}
