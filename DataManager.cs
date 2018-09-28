using LibraryAmoCRM.Configuration;
using LibraryAmoCRM.Implements;
using LibraryAmoCRM.Models;
using LibraryAmoCRM.Models.SysModels;
using Serilog;
using System;
using System.Reflection;
using System.Threading;

namespace LibraryAmoCRM
{
    public class DataManager
    {
        AssemblyConfig config;
        AmoHTTPClient httpConfig;

        QueryPerSecond lastQueryTime = new QueryPerSecond();

        public Account Account { get; set; }

        ILogger logger;

        public DataManager(string account, string user, string hash)
        {
            config = new AssemblyConfig(account, user, hash);
            httpConfig = new AmoHTTPClient(config);

            this.logger = new LoggerConfiguration()
                    .WriteTo.Seq("http://logs.fitness-pro.ru:5341")
                    .CreateLogger();

            httpConfig.Auth(null);


            TimerCallback tm = new TimerCallback(httpConfig.Auth);
            Timer keepConnection = new Timer(tm, null, 780000, 780000);

            Account = Fields.GetAccount().Result;

            logger.Information("AmoCRM Datamanager Start");
        }

        CommonRepository<LeadDTO> _leads;
        CommonRepository<ContactDTO> _contacts;
        CommonRepository<CompanyDTO> _companies;
        CommonRepository<TaskDTO> _tasks;

        FieldsRepository _fields;

        CommonRepository<CatalogDTO> _catalogs;

        CommonRepository<NoteDTO> _notesLead;
        CommonRepository<NoteDTO> _notesContact;
        CommonRepository<NoteDTO> _notesCompany;
        CommonRepository<NoteDTO> _notesTask;

        //CatalogRepository _catalogs;

        public CommonRepository<LeadDTO> Leads => _leads ?? (_leads = new CommonRepository<LeadDTO>( httpConfig.GetClient( config.Url.Lead ), lastQueryTime, logger));
        public CommonRepository<NoteDTO> NotesLead => _notesLead ?? (_notesLead = new CommonRepository<NoteDTO>(httpConfig.GetClient(config.Url.NotesLead), lastQueryTime, logger));

        public CommonRepository<ContactDTO> Contacts => _contacts ?? (_contacts = new CommonRepository<ContactDTO>(httpConfig.GetClient(config.Url.Contact), lastQueryTime, logger));
        public CommonRepository<NoteDTO> NotesContact => _notesContact ?? (_notesContact = new CommonRepository<NoteDTO>(httpConfig.GetClient(config.Url.NotesContact), lastQueryTime, logger));

        public CommonRepository<CompanyDTO> Companies => _companies ?? (_companies = new CommonRepository<CompanyDTO>(httpConfig.GetClient(config.Url.Company), lastQueryTime, logger));
        public CommonRepository<NoteDTO> NotesCompany => _notesCompany ?? (_notesCompany = new CommonRepository<NoteDTO>(httpConfig.GetClient(config.Url.NotesCompany), lastQueryTime, logger));

        public CommonRepository<TaskDTO> Tasks => _tasks ?? (_tasks = new CommonRepository<TaskDTO>(httpConfig.GetClient(config.Url.Task), lastQueryTime, logger));
        public CommonRepository<NoteDTO> NotesTask => _notesTask ?? (_notesTask = new CommonRepository<NoteDTO>(httpConfig.GetClient(config.Url.NotesTask), lastQueryTime, logger));


        public CommonRepository<CatalogDTO> Catalogs => _catalogs ?? (_catalogs = new CommonRepository<CatalogDTO>(httpConfig.GetClient(config.Url.Catalog), lastQueryTime, logger));


        public FieldsRepository Fields => _fields ?? (_fields = new FieldsRepository(httpConfig.GetClient(config.Url.Fields)));


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
