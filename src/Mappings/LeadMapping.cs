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
    internal class LeadMapping
    {
        public LeadMapping()
        {
            TypeAdapterConfig<ILead, LeadDTO>
                .NewConfig()
                .Map(dest => dest.id, src => src.Id)
                .Map(dest => dest.name, src => src.Name)
                .Map(dest => dest.main_contact, src => src.MainContactId == 0 ? null : new Element { id = src.MainContactId })
                .Map(dest => dest.closest_task_at, src => src.NearestTaskAt.GetUnixTimeSeconds())
                .Map(dest => dest.closed_at, src => src.ClosedAt.GetUnixTimeSeconds())
                .Map(dest => dest.is_deleted, src => src.IsDeleted)
                .Map(dest => dest.status_id, src => src.Status)
                .Map(dest => dest.sale, src => src.Price)
                .Map(dest => dest.loss_reason_id, src => src.LossReason)
                .Map(dest => dest.pipeline, src => src.Pipeline == 0? null : new Element { id = src.Pipeline })
                .Map(dest => dest.pipeline_id, src => src.Pipeline)
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

            TypeAdapterConfig<LeadDTO, ILead>
                .NewConfig()
                .MapWith(src => src.Adapt<Lead>());

            TypeAdapterConfig<LeadDTO, Lead>
                .NewConfig()
                .Map(dest => dest.Id, src => src.id)
                .Map(dest => dest.Name, src => src.name)
                .Map(dest => dest.MainContactId, src => src.main_contact == null ? default : src.main_contact.id)
                .Map(dest => dest.NearestTaskAt, src => src.closest_task_at.GetDateTimeFromUnixTime())
                .Map(dest => dest.ClosedAt, src => src.closed_at.GetDateTimeFromUnixTime())
                .Map(dest => dest.IsDeleted, src => src.is_deleted)
                .Map(dest => dest.Status, src => src.status_id)
                .Map(dest => dest.Price, src => src.sale)
                .Map(dest => dest.LossReason, src => src.loss_reason_id)
                .Map(dest => dest.Pipeline, src => src.pipeline == null? default : src.pipeline.id)
                .Map(dest => dest.ResponsibleUserId, src => src.responsible_user_id)
                .Map(dest => dest.CreatedBy, src => src.created_by)
                .Map(dest => dest.CreatedAt, src => src.created_at.GetDateTimeFromUnixTime())
                .Map(dest => dest.UpdatedAt, src => src.updated_at.GetDateTimeFromUnixTime())
                .Map(dest => dest.AccountId, src => src.account_id)
                .Map(dest => dest.GroupId, src => src.group_id)
                .Map(dest => dest.Tags, src => src.tags)
                .Map(dest => dest.CustomFields, src => src.custom_fields)
                .Map(dest => dest.Contacts, src => src.contacts)
                .Map(dest => dest.Company, src => src.company);
        }
    }
}
