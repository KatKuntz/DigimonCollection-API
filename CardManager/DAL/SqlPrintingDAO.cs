using CardManager.Models;
using System;

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
            throw new NotImplementedException();
        }
    }
}
