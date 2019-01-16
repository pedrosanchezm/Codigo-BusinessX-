using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace PatternRepository.RepositoryDapper
{
    public class Helper
    {
        private readonly string KeyName;

        public Helper(string keyname)
        {
            KeyName = keyname;
        }

        public string GetConnectionString()
        {
            var Configuration = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("appsettings.json").
                Build();
            return Configuration.GetConnectionString(KeyName);
        }
    }
}
