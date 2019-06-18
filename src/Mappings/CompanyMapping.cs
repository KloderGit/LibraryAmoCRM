using LibraryAmoCRM.DTO;
using LibraryAmoCRM.Extensions;
using LibraryAmoCRM.Interfaces;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Mappings
{
    internal class CompanyMapping
    {
        public CompanyMapping()
        {
            TypeAdapterConfig<ICompany, CompanyDTO>
                .ForType()
                .Map(dest => dest.id, src => src.Id)
                .Map(dest => dest.name, src => src.Name)
                .Map(dest => dest.responsible_user_id, src => src.ResponsibleUserId)
                .Map(dest => dest.created_by, src => src.CreatedBy)
                .Map(dest => dest.created_at, src => src.CreatedAt.GetUnixTimeSeconds())
                .Map(dest => dest.updated_at, src => src.UpdatedAt.GetUnixTimeSeconds())
                .Map(dest => dest.account_id, src => src.AccountId)
                .Map(dest => dest.group_id, src => src.GroupId)
                .Map(dest => dest.closest_task_at, src => src.ClosestTaskAt.GetUnixTimeSeconds())
                .Map(dest => dest.updated_by, src => src.UpdatedBy)
                .Map(dest => dest.custom_fields, src => src.CustomFields)
                .Map(dest => dest.tags, src => src.Tags)
                .Map(dest => dest.leads, src => src.Leads)
                .Map(dest => dest.customers, src => src.Customers)
                .Map(dest => dest.contacts, src => src.Contacts);
        }
    }
}
