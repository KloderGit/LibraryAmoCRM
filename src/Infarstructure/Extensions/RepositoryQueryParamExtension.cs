using LibraryAmoCRM.Infarstructure.QueryParams;
using LibraryAmoCRM.Interfaces;
using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace LibraryAmoCRM.Infarstructure.Extensions
{
    public static class RepositoryQueryParamExtension
    {
        public static IQueryableRepository<T> Filter<T,U>(this IQueryableRepository<T> source, Expression<Func<U, bool>> predicate)
        {
            source.CreateQuery(predicate);
            return source;
        }

        public static IQueryableRepository<LeadDTO> Filter(this IQueryableRepository<LeadDTO> source, Expression<Func<LeadFilter, bool>> predicate)
        {
            source.CreateQuery(predicate);
            return source;
        }


        public static IQueryableRepository<ContactDTO> Filter(this IQueryableRepository<ContactDTO> source, Expression<Func<ContactFilter, bool>> predicate)
        {
            source.CreateQuery(predicate);
            return source;
        }

        public static IQueryableRepository<Contact> Filter(this IQueryableRepository<Contact> source, Expression<Func<ContactFilter, bool>> predicate)
        {
            source.CreateQuery(predicate);
            return source;
        }

        public static IQueryableRepository<LibraryAmoCRM.DTO.ContactDTO> Filter(this IQueryableRepository<LibraryAmoCRM.DTO.ContactDTO> source, Expression<Func<ContactFilter, bool>> predicate)
        {
            source.CreateQuery(predicate);
            return source;
        }




        public static IQueryableRepository<CompanyDTO> Filter(this IQueryableRepository<CompanyDTO> source, Expression<Func<ContactFilter, bool>> predicate)
        {
            source.CreateQuery(predicate);
            return source;
        }

        public static IQueryableRepository<TaskDTO> Filter(this IQueryableRepository<TaskDTO> source, Expression<Func<TaskFilter, bool>> predicate)
        {
            source.CreateQuery(predicate);
            return source;
        }

        public static IQueryableRepository<NoteDTO> Filter(this IQueryableRepository<NoteDTO> source, Expression<Func<NoteFilter, bool>> predicate)
        {
            source.CreateQuery(predicate);
            return source;
        }
    }
}
