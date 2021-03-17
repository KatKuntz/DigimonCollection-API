using CardManager.Models;
using CardManager.Utility;
using System.Data.SqlClient;

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
            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = "INSERT INTO [dbo].[Set](Name, ReleaseDate) " +
                               "VALUES (@name, @releaseDate); " +
                               "SELECT CAST(SCOPE_IDENTITY() as Int);";

                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", set.Name);
                cmd.Parameters.AddWithValue("@releaseDate", set.ReleaseDate);

                set.SetId = (int)cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new DAOException("Failed to add set", ex);
            }
        }
    }
}
