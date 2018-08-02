using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLibraryAmoCRM.Configuration
{
    internal class Url
    {
        Uri _baseUrl { get; }

        public Uri Auth { get => new Uri(_baseUrl, "private/api/auth.php"); }

        public Uri Lead { get => new Uri(_baseUrl, "api/v2/leads"); }
        public Uri NotesLead { get => new Uri(_baseUrl, "api/v2/notes?type=lead"); }

        public Uri Contact { get => new Uri(_baseUrl, "api/v2/contacts"); }
        public Uri NotesContact { get => new Uri(_baseUrl, "api/v2/notes?type=contact"); }

        public Uri Company { get => new Uri(_baseUrl, "api/v2/companies"); }
        public Uri NotesCompany { get => new Uri(_baseUrl, "api/v2/notes?type=company"); }

        public Uri Task { get => new Uri(_baseUrl, "api/v2/tasks"); }
        public Uri NotesTask { get => new Uri(_baseUrl, "api/v2/notes?type=task"); }

        public Url(string account)
        {
            _baseUrl = new Uri($"https://{account}.amocrm.ru/");
        }
    }

}
