﻿using CardManager.Models;
using System;
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
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "INSERT INTO [dbo].[Set](Name, ReleaseDate) " +
                           "VALUES (@name, @releaseDate); " +
                           "SELECT CAST(SCOPE_IDENTITY() as Int);";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", set.Name);
            cmd.Parameters.AddWithValue("@releaseDate", set.ReleaseDate);

            set.SetId = (int)cmd.ExecuteScalar();
        }
    }
}
