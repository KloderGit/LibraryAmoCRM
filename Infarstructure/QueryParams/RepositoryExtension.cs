using LibraryAmoCRM.Interfaces;
using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public static class RepositoryExtension
    {
        public static IRepository<LeadDTO> Filter(this IRepository<LeadDTO> item, Action<LeadFilter> action) 
        {
            var param = new LeadFilter();
            action( param );
            var pair = param.result;

            var titem = (IQueryParam)item;

            titem.QueryParameters.Add( pair );

            return item;
        }

        public static IRepository<ContactDTO> Filter(this IRepository<ContactDTO> item, Action<CustomerFilter> action) 
        {
            var param = new CustomerFilter();
            action( param );
            var pair = param.result;

            var titem = (IQueryParam)item;

            titem.QueryParameters.Add( pair );

            return item;
        }

        public static IRepository<CompanyDTO> Filter(this IRepository<CompanyDTO> item, Action<CustomerFilter> action)
        {
            var param = new CustomerFilter();
            action( param );
            var pair = param.result;

            var titem = (IQueryParam)item;

            titem.QueryParameters.Add( pair );

            return item;
        }

        public static IRepository<TaskDTO> Filter(this IRepository<TaskDTO> item, Action<TaskFilter> action)
        {
            var param = new TaskFilter();
            action( param );
            var pair = param.result;

            var titem = (IQueryParam)item;

            titem.QueryParameters.Add( pair );

            return item;
        }

        public static IRepository<NoteDTO> Filter(this IRepository<NoteDTO> item, Action<NoteFilter> action)
        {
            var param = new NoteFilter();
            action( param );
            var pair = param.result;

            var titem = (IQueryParam)item;

            titem.QueryParameters.Add( pair );

            return item;
        }
    }
}
