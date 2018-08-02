using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLibraryAmoCRM.Configuration
{
    internal class Config
    {
        public Url Url { get; }
        public string User { get; }
        public string Password { get; }

        public Config(string account, string user, string hash)
        {
            Url = new Url(account);
            User = user;
            Password = hash;
        }


    }


}
