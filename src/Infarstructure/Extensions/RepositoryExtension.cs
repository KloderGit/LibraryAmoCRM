using LibraryAmoCRM.Infarstructure.QueryParamFilters;
using LibraryAmoCRM.Infarstructure.QueryParams;
using LibraryAmoCRM.Interfaces;
using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryAmoCRM.Infarstructure.Extensions
{
    public static class RepositoryExtension
    {
        //public static T FindById<T>(this IQueryableRepository<T> source, int id)
        //{
        //    source.Filter<T, CoreFilter>(x => x.Id == id);
        //    var result = source.Execute<T>() as IEnumerable<T>;
        //    return result.FirstOrDefault();
        //}

        //public static IQueryableRepository<T> FindByPhone<T>(this IQueryableRepository<T> source, string phone) where T: ContactDTO
        //{
        //    var queryParam = new PhoneParamFilter(phone).ToString();

        //    source.Filter<T, ContactFilter>(x => x.Phone == queryParam);
        //    return source;
        //}
    }
}
