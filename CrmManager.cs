using LibraryAmoCRM.Configuration;
using LibraryAmoCRM.Implements;
using LibraryAmoCRM.Infarstructure.QueryParams;
using LibraryAmoCRM.Interfaces;
using LibraryAmoCRM.Models;
using LibraryAmoCRM.Models.SysModels;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Net.Http;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryAmoCRM
{
    public class CrmManager : IDataManager
    {
        public Account Account { get; set; }

        Serilog.ILogger logger;
        ILoggerFactory loggerFactory;
        Microsoft.Extensions.Logging.ILogger currentLogger;

        string assamblyName;

        Connection connection;

        public CrmManager(Connection connection)
        {
            this.connection = connection;

            this.logger = new LoggerConfiguration()
                .WriteTo.Seq("http://logs.fitness-pro.ru:5341")
                .CreateLogger();

            assamblyName = GetType().Assembly.GetName().Name;

            Account = Fields.GetAccount().Result;
        }

        public CrmManager(Connection connection, ILoggerFactory loggerFactory)
        {
            this.loggerFactory = loggerFactory;
            this.currentLogger = loggerFactory.CreateLogger(this.ToString());

            this.connection = connection;

            Account = Fields.GetAccount().Result;
        }


        IRepository<LeadDTO> _leads;
        IRepository<ContactDTO> _contacts;
        IRepository<CompanyDTO> _companies;
        IRepository<TaskDTO> _tasks;
        IRepository<NoteDTO> _notes;
        IRepository<CatalogDTO> _catalogs;

        FieldsRepository _fields;


        public IRepository<LeadDTO> Leads => _leads ?? (_leads = new Repository<LeadDTO>( connection, loggerFactory));

        public IRepository<ContactDTO> Contacts => _contacts ?? (_contacts = new Repository<ContactDTO>( connection, loggerFactory));

        public IRepository<CompanyDTO> Companies => _companies ?? (_companies = new Repository<CompanyDTO>( connection, loggerFactory));

        public IRepository<TaskDTO> Tasks => _tasks ?? (_tasks = new Repository<TaskDTO>( connection, loggerFactory));

        public IRepository<NoteDTO> Notes => _notes ?? ( _notes = new Repository<NoteDTO>( connection, loggerFactory) );

        public IRepository<CatalogDTO> Catalogs => _catalogs ?? (_catalogs = new Repository<CatalogDTO>( connection, loggerFactory));


        public FieldsRepository Fields => _fields ?? (_fields = new FieldsRepository(connection));


        public IRepository<T> Repository<T>() where T : CoreDTO
        {
            var properties = typeof(CrmManager).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            IRepository<T> result = null;

            foreach (var property in properties)
            {
                if (property.PropertyType == typeof( IRepository<T>))
                {
                    result = property.GetValue(this) as IRepository<T>;
                }
            }

            return result;
        }
    }
}
