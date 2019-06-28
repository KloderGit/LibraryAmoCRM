using LibraryAmoCRM.DTO;
using LibraryAmoCRM.Extensions;
using LibraryAmoCRM.Interfaces;
using LibraryAmoCRM.Models;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Mappings
{
    internal class ContactMapping
    {
        public ContactMapping()
        {
            TypeAdapterConfig<IContact, ContactDTO>
                .NewConfig()
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
                .Map(dest => dest.company, src => src.Company);

            TypeAdapterConfig<ContactDTO, Contact>
                .NewConfig()
                .Map(dest => dest.Id, src => src.id)
                .Map(dest => dest.Name, src => src.name)
                .Map(dest => dest.ResponsibleUserId, src => src.responsible_user_id)
                .Map(dest => dest.CreatedBy, src => src.created_by)
                .Map(dest => dest.CreatedAt, src => src.created_at.GetDateTimeFromUnixTime())
                .Map(dest => dest.UpdatedAt, src => src.updated_at.GetDateTimeFromUnixTime())
                .Map(dest => dest.AccountId, src => src.account_id)
                .Map(dest => dest.GroupId, src => src.group_id)
                .Map(dest => dest.ClosestTaskAt, src => src.closest_task_at.GetDateTimeFromUnixTime())
                .Map(dest => dest.UpdatedBy, src => src.updated_by)
                .Map(dest => dest.CustomFields, src => src.custom_fields)
                .Map(dest => dest.Tags, src => src.tags)
                .Map(dest => dest.Leads, src => src.leads)
                .Map(dest => dest.Customers, src => src.customers)
                .Map(dest => dest.Company, src => src.company);
        }
    }
}
