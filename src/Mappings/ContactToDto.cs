using LibraryAmoCRM.DTO;
using LibraryAmoCRM.Interfaces;
using LibraryAmoCRM.Models;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Mappings
{
    internal class ContactToDto : ToDtoFunction
    {
        public ContactToDto()
        {
            TypeAdapterConfig<ICustomField, CustomField>
                .ForType()
                .Map(dest => dest.id, src => src.Id)
                .Map(dest => dest.name, src => src.Name)
                .Map(dest => dest.code, src => src.Code)
                .Map(dest => dest.is_system, src => src.IsSystem);

            TypeAdapterConfig<IContact, ContactDTO>
                .ForType()
                .Map(dest => dest.id, src => src.Id)
                .Map(dest => dest.name, src => src.Name)
                .Map(dest => dest.responsible_user_id, src => src.ResponsibleUserId)
                .Map(dest => dest.created_by, src => src.CreatedBy)
                .Map(dest => dest.created_at, src => GetUnixTimeSeconds(src.CreatedAt))
                .Map(dest => dest.updated_at, src => GetUnixTimeSeconds(src.UpdatedAt))
                .Map(dest => dest.account_id, src => src.AccountId)
                .Map(dest => dest.group_id, src => src.GroupId)
                .Map(dest => dest.closest_task_at, src => GetUnixTimeSeconds(src.ClosestTaskAt))
                .Map(dest => dest.updated_by, src => src.UpdatedBy)
                .Map(dest => dest.custom_fields, src => src.CustomFields)
                .Map(dest => dest.tags, src => src.Tags);
                //.Map(dest => dest.leads, src => src.Leads)
                //.Map(dest => dest.company, src => src.Company);

            TypeAdapterConfig<ISimpleObject, EntityDTO>
                .ForType()
                .Map(dest => dest.id, src => src.Id)
                .Map(dest => dest.name, src => src.Name);
        }
    }
}
