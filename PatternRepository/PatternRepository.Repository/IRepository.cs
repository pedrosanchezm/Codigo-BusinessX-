using System;
using System.Collections.Generic;

namespace PatternRepository.Repository
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll(string query);
    }
}
