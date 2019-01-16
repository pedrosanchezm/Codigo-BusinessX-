using System;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PatternRepository.DAL
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
                AddJsonFile("appsettings").
                Build();
            return Configuration.GetConnectionString(KeyName);
        }
    }
}
