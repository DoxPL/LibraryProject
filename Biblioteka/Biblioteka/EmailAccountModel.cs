using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class EmailAccountModel
    {
        private string host;
        private string username;
        private string password;
        private string address;
        
        public EmailAccountModel(string host, string address, string login, string pass)
        {
            this.host = host;
            this.username = login;
            this.password = pass;
            this.address = address;
        }

        public string getHost()
        {
            return this.host;
        }

        public string getLogin()
        {
            return this.username;
        }

        public string getPasswd()
        {
            return this.password;
        }

        public string getAddress()
        {
            return this.address;
        }

    }
}
