using LibraryAmoCRM.Configuration;
using LibraryAmoCRM.Implements;
using LibraryAmoCRM.Interfaces;
using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;

namespace LibraryAmoCRM.Infarstructure.QueryParams
{
    public static class AddParamRepositoryExtension
    {

        public static CommonRepository<LeadDTO> SetParam(this CommonRepository<LeadDTO> item, Action<Param> action)
        {
            var param = new Param();
            action(param);
            var pair = param.result;

            item.QueryParameters.Add(pair);

            return item;
        }

        public static CommonRepository<ContactDTO> SetParam(this CommonRepository<ContactDTO> item, Action<Param> action)
        {
            var param = new Param();
            action(param);
            var pair = param.result;

            item.QueryParameters.Add(pair);

            return item;
        }

        public static CommonRepository<CompanyDTO> SetParam(this CommonRepository<CompanyDTO> item, Action<Param> action)
        {
            var param = new Param();
            action(param);
            var pair = param.result;

            item.QueryParameters.Add(pair);

            return item;
        }

        public static CommonRepository<NoteDTO> SetParam(this CommonRepository<NoteDTO> item, Action<Param> action)
        {
            var param = new Param();
            action(param);
            var pair = param.result;

            item.QueryParameters.Add(pair);

            return item;
        }

        public static CommonRepository<TaskDTO> SetParam(this CommonRepository<TaskDTO> item, Action<Param> action)
        {
            var param = new Param();
            action(param);
            var pair = param.result;

            item.QueryParameters.Add(pair);

            return item;
        }


        public static CommonRepository<CatalogDTO> SetParam(this CommonRepository<CatalogDTO> item, Action<CatalogParam> action)
        {
            var param = new CatalogParam();
            action(param);
            var pair = param.result;

            item.QueryParameters.Add(pair);

            return item;
        }

        //public static ICommonRepository<TResult> SetParam<TResult>(this ICommonRepository<TResult> item, Action<Param> action) where TResult : CoreDTO
        //{
        //    var param = new Param();
        //    action(param);
        //    var pair = param.result;

        //    (CommonRepository<TResult>)item.QueryParameters.Add(pair);

        //    return item;
        //}



    }
}
