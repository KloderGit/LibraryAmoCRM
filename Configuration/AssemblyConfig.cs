using LibraryAmoCRM.Implements;
using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Configuration
{
    internal class AssemblyConfig
    {
        public Url Url { get; }
        public string User { get; }
        public string Password { get; }

        public AssemblyConfig(string account, string user, string hash)
        {
            Url = new Url(account);
            User = user;
            Password = hash;
        }


    }

    public enum Catalogs
    {
        Programs = 2173
    }
}