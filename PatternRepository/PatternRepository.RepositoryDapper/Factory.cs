using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace PatternRepository.RepositoryDapper
{
    public class Factory : IDisposable
    {
        public IDbConnection connection { get; }

        public Factory()
        {
            var Provider = new Helper("Provider").GetConnectionString();
            var connectionString = new Helper("ConnectionString").GetConnectionString();

            switch (Provider)
            {
                case "SQLITE":
                    connection = new SQLiteConnection();
                    break;
                default:
                    break;
            }
            connection.ConnectionString = connectionString;
        }
        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
