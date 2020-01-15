using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class Connection : IConnection
    {
        private bool isOpen;
        private string username;
        public IDatabase Database => throw new NotImplementedException();

        public void Close()
        {
            if (isOpen) isOpen = false;
            else throw new ConnectionClosedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public string GetPassword()
        {
            throw new NotImplementedException();
        }

        public string GetUsername()
        {
            return username;
        }

        public bool IsOpen()
        {
            return isOpen;
        }

        public void Open()
        {
            throw new NotImplementedException();
        }
    }
}
