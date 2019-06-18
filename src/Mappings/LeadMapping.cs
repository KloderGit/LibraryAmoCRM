using LibraryAmoCRM.DTO;
using LibraryAmoCRM.Extensions;
using LibraryAmoCRM.Interfaces;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Mappings
{
    internal class LeadMapping
    {
        public LeadMapping()
        {
            TypeAdapterConfig<ILead, LeadDTO>
                .ForType()
                .Map(dest => dest.id, src => src.Id)
                .Map(dest => dest.name, src => src.Name)
                .Map(dest => dest.main_contact, src => src.MainContactId)
                .Map(dest => dest.closest_task_at, src => src.NearestTaskAt.GetUnixTimeSeconds())
                .Map(dest => dest.closed_at, src => src.ClosedAt.GetUnixTimeSeconds())
                .Map(dest => dest.is_deleted, src => src.IsDeleted)
                .Map(dest => dest.status_id, src => src.Status)
                .Map(dest => dest.sale, src => src.Price)
                .Map(dest => dest.loss_reason_id, src => src.LossReason)
                .Map(dest => dest.pipeline, src => src.Pipeline)
                .Map(dest => dest.responsible_user_id, src => src.ResponsibleUserId)
                .Map(dest => dest.created_by, src => src.CreatedBy)
                .Map(dest => dest.created_at, src => src.CreatedAt.GetUnixTimeSeconds())
                .Map(dest => dest.updated_at, src => src.UpdatedAt.GetUnixTimeSeconds())
                .Map(dest => dest.account_id, src => src.AccountId)
                .Map(dest => dest.group_id, src => src.GroupId)
                .Map(dest => dest.tags, src => src.Tags)
                .Map(dest => dest.custom_fields, src => src.CustomFields)
                .Map(dest => dest.contacts, src => src.Contacts)
                .Map(dest => dest.company, src => src.Company);
        }
    }
}
