using LibraryAmoCRM.Configuration;
using LibraryAmoCRM.Implements;
using LibraryAmoCRM.Infarstructure.QueryParams;
using LibraryAmoCRM.Interfaces;
using LibraryAmoCRM.Models;
using LibraryAmoCRM.Models.SysModels;
using Serilog;
using System;
using System.Net.Http;
using System.Reflection;
using System.Threading;

namespace LibraryAmoCRM
{
    public class CrmManager : IDataManager
    {
        public Account Account { get; set; }

        ILogger logger;

        string assamblyName;

        Connection connection;

        public CrmManager(Connection connection)
        {
            this.connection = connection;

            this.logger = new LoggerConfiguration()
                .WriteTo.Seq( "http://logs.fitness-pro.ru:5341" )
                .CreateLogger();

            assamblyName = GetType().Assembly.GetName().Name;

            Account = Fields.GetAccount().Result;

            logger.Debug( $"{assamblyName} | Datamanager Start" );
        }


        IRepository<LeadDTO> _leads;
        IRepository<ContactDTO> _contacts;
        IRepository<CompanyDTO> _companies;
        IRepository<TaskDTO> _tasks;
        IRepository<NoteDTO> _notes;
        IRepository<CatalogDTO> _catalogs;

        FieldsRepository _fields;


        public IRepository<LeadDTO> Leads => _leads ?? (_leads = new Repository<LeadDTO>( connection, logger));

        public IRepository<ContactDTO> Contacts => _contacts ?? (_contacts = new Repository<ContactDTO>( connection, logger));

        public IRepository<CompanyDTO> Companies => _companies ?? (_companies = new Repository<CompanyDTO>( connection, logger));

        public IRepository<TaskDTO> Tasks => _tasks ?? (_tasks = new Repository<TaskDTO>( connection, logger));

        public IRepository<NoteDTO> Notes => _notes ?? ( _notes = new Repository<NoteDTO>( connection, logger ) );

        public IRepository<CatalogDTO> Catalogs => _catalogs ?? (_catalogs = new Repository<CatalogDTO>( connection, logger));


        public FieldsRepository Fields => _fields ?? (_fields = new FieldsRepository(connection.GetClient<Account>()));


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
