using LibraryAmoCRM.Configuration;
using LibraryAmoCRM.Implements;
using LibraryAmoCRM.Models;
using System.Reflection;

namespace LibraryAmoCRM
{
    public class DataManager
    {
        AssemblyConfig config;
        AmoHTTPClient httpConfig;

        public DataManager(string account, string user, string hash)
        {
            config = new AssemblyConfig(account, user, hash);
            httpConfig = new AmoHTTPClient(config);
            httpConfig.Auth();
        }

        CommonRepository<LeadDTO> _leads;
        CommonRepository<ContactDTO> _contacts;
        CommonRepository<CompanyDTO> _companies;
        CommonRepository<TaskDTO> _tasks;

        CommonRepository<CatalogDTO> _catalogs;

        CommonRepository<NoteDTO> _notesLead;
        CommonRepository<NoteDTO> _notesContact;
        CommonRepository<NoteDTO> _notesCompany;
        CommonRepository<NoteDTO> _notesTask;

        //CatalogRepository _catalogs;

        public CommonRepository<LeadDTO> Leads => _leads ?? (_leads = new CommonRepository<LeadDTO>( httpConfig.GetClient( config.Url.Lead ) ));
        public CommonRepository<NoteDTO> NotesLead => _notesLead ?? (_notesLead = new CommonRepository<NoteDTO>(httpConfig.GetClient(config.Url.NotesLead)));

        public CommonRepository<ContactDTO> Contacts => _contacts ?? (_contacts = new CommonRepository<ContactDTO>(httpConfig.GetClient(config.Url.Contact)));
        public CommonRepository<NoteDTO> NotesContact => _notesContact ?? (_notesContact = new CommonRepository<NoteDTO>(httpConfig.GetClient(config.Url.NotesContact)));

        public CommonRepository<CompanyDTO> Companies => _companies ?? (_companies = new CommonRepository<CompanyDTO>(httpConfig.GetClient(config.Url.Company)));
        public CommonRepository<NoteDTO> NotesCompany => _notesCompany ?? (_notesCompany = new CommonRepository<NoteDTO>(httpConfig.GetClient(config.Url.NotesCompany)));

        public CommonRepository<TaskDTO> Tasks => _tasks ?? (_tasks = new CommonRepository<TaskDTO>(httpConfig.GetClient(config.Url.Task)));
        public CommonRepository<NoteDTO> NotesTask => _notesTask ?? (_notesTask = new CommonRepository<NoteDTO>(httpConfig.GetClient(config.Url.NotesTask)));


        public CommonRepository<CatalogDTO> Catalogs => _catalogs ?? (_catalogs = new CommonRepository<CatalogDTO>(httpConfig.GetClient(config.Url.Catalog)));


        //public CatalogRepository Catalogs => _catalogs ?? (_catalogs = new CatalogRepository(httpConfig.GetClient(config.Url.Task)));


        public CommonRepository<T> Repository<T>() where T : CoreDTO
        {
            var properties = typeof(DataManager).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            CommonRepository<T> result = null;

            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(CommonRepository<T>))
                {
                    result = property.GetValue(this) as CommonRepository<T>;
                }
            }

            return result;
        }
    }
}
