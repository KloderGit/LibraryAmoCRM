using ServiceLibraryAmoCRM.Implements;
using ServiceLibraryAmoCRM.Models;
using System;

namespace ServiceLibraryAmoCRM.Infarstructure.QueryParams
{
    public static class AddParamRepositoryExtension
    {
        public static CommonRepository<LeadDTO> Param(this CommonRepository<LeadDTO> item, Action<Param> action)
        {
            var param = new Param();
            action(param);
            var pair = param.result;

            item.QueryParameters.Add(pair);

            return item;
        }

        public static CommonRepository<ContactDTO> Param(this CommonRepository<ContactDTO> item, Action<Param> action)
        {
            var param = new Param();
            action(param);
            var pair = param.result;

            item.QueryParameters.Add(pair);

            return item;
        }

        public static CommonRepository<CompanyDTO> Param(this CommonRepository<CompanyDTO> item, Action<Param> action)
        {
            var param = new Param();
            action(param);
            var pair = param.result;

            item.QueryParameters.Add(pair);

            return item;
        }

        public static CommonRepository<NoteDTO> Param(this CommonRepository<NoteDTO> item, Action<Param> action)
        {
            var param = new Param();
            action(param);
            var pair = param.result;

            item.QueryParameters.Add(pair);

            return item;
        }

        public static CommonRepository<TaskDTO> Param(this CommonRepository<TaskDTO> item, Action<Param> action)
        {
            var param = new Param();
            action(param);
            var pair = param.result;

            item.QueryParameters.Add(pair);

            return item;
        }
    }
}
