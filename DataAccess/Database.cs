using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class Database : IDatabase
    {
        public List<Dictionary<string, object>> GetData(IConnection connection)
        {
            throw new NotImplementedException();
        }

        public string GetDatabaseName()
        {
            throw new NotImplementedException();
        }

        public IConnection GetNewConnection(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
