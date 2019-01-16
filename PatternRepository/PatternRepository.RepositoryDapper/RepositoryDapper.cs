using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternRepository.Repository;

namespace PatternRepository.RepositoryDapper
{
    public class RepositoryDapper<T> : IRepository<T> where T: class
    {
        public IEnumerable<T> GetAll(string query)
        {
            using (var connection = new Factory().connection)
            {
                return connection.Query<T>(query).ToList();
            }
        }
    }
}
