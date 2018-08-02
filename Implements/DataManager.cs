using ServiceLibraryAmoCRM.Configuration;
using ServiceLibraryAmoCRM.Models;

namespace ServiceLibraryAmoCRM.Implements
{
    public class DataManager
    {
        Config config;
        AmoHTTPClient httpConfig;

        public DataManager(string account, string user, string hash)
        {
            config = new Config(account, user, hash);
            httpConfig = new AmoHTTPClient(config);
            httpConfig.Auth();
        }

        CommonRepository<LeadDTO> _leads;
        CommonRepository<ContactDTO> _contacts;
        CommonRepository<CompanyDTO> _companies;
        CommonRepository<TaskDTO> _tasks;

        CommonRepository<NoteDTO> _notesLead;
        CommonRepository<NoteDTO> _notesContact;
        CommonRepository<NoteDTO> _notesCompany;
        CommonRepository<NoteDTO> _notesTask;

        public CommonRepository<LeadDTO> Leads => _leads ?? (_leads = new CommonRepository<LeadDTO>( httpConfig.GetClient( config.Url.Lead ) ));
        public CommonRepository<NoteDTO> NotesLead => _notesLead ?? (_notesLead = new CommonRepository<NoteDTO>(httpConfig.GetClient(config.Url.NotesLead)));

        public CommonRepository<ContactDTO> Contacts => _contacts ?? (_contacts = new CommonRepository<ContactDTO>(httpConfig.GetClient(config.Url.Contact)));
        public CommonRepository<NoteDTO> NotesContact => _notesContact ?? (_notesContact = new CommonRepository<NoteDTO>(httpConfig.GetClient(config.Url.NotesContact)));

        public CommonRepository<CompanyDTO> Companies => _companies ?? (_companies = new CommonRepository<CompanyDTO>(httpConfig.GetClient(config.Url.Company)));
        public CommonRepository<NoteDTO> NotesCompany => _notesCompany ?? (_notesCompany = new CommonRepository<NoteDTO>(httpConfig.GetClient(config.Url.NotesCompany)));

        public CommonRepository<TaskDTO> Tasks => _tasks ?? (_tasks = new CommonRepository<TaskDTO>(httpConfig.GetClient(config.Url.Task)));
        public CommonRepository<NoteDTO> NotesTask => _notesTask ?? (_notesTask = new CommonRepository<NoteDTO>(httpConfig.GetClient(config.Url.NotesTask)));

    }
}
