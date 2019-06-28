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
    internal class NoteMapping
    {
        public NoteMapping()
        {
            TypeAdapterConfig<INote, NoteDTO>
                .NewConfig()
                .Map(dest => dest.id, src => src.Id)
                .Map(dest => dest.text, src => src.Text)
                .Map(dest => dest.@params, src => src.Params)
                .Map(dest => dest.is_editable, src => src.IsEditable)
                .Map(dest => dest.attachment, src => src.Attachment)
                .Map(dest => dest.note_type, src => src.NoteType)
                .Map(dest => dest.responsible_user_id, src => src.ResponsibleUserId)
                .Map(dest => dest.created_by, src => src.CreatedBy)
                .Map(dest => dest.created_at, src => src.CreatedAt.GetUnixTimeSeconds())
                .Map(dest => dest.updated_at, src => src.UpdatedAt.GetUnixTimeSeconds())
                .Map(dest => dest.account_id, src => src.AccountId)
                .Map(dest => dest.group_id, src => src.GroupId)
                .Map(dest => dest.element_id, src => src.ElementId)
                .Map(dest => dest.element_type, src => src.ElementType);

            TypeAdapterConfig<INoteParam, NoteParamsDTO>
                .NewConfig()
                .Map(dest => dest.service, src => src.Service)
                .Map(dest => dest.text, src => src.Text)
                .Map(dest => dest.uniq, src => src.Uniq)
                .Map(dest => dest.src, src => src.Src)
                .Map(dest => dest.sender, src => src.Sender)
                .Map(dest => dest.phone, src => src.Phone)
                .Map(dest => dest.link, src => src.Link)
                .Map(dest => dest.html, src => src.Html)
                .Map(dest => dest.from, src => src.From)
                .Map(dest => dest.duration, src => src.Duration)
                .Map(dest => dest.call_status, src => src.CallStatus)
                .Map(dest => dest.call_result, src => src.CallResult);


            TypeAdapterConfig<NoteDTO, Note>
                .NewConfig()
                .Map(dest => dest.Id, src => src.id)
                .Map(dest => dest.Text, src => src.text)
                .Map(dest => dest.Params, src => src.@params)
                .Map(dest => dest.IsEditable, src => src.is_editable)
                .Map(dest => dest.Attachment, src => src.attachment)
                .Map(dest => dest.NoteType, src => src.note_type)
                .Map(dest => dest.ResponsibleUserId, src => src.responsible_user_id)
                .Map(dest => dest.CreatedBy, src => src.created_by)
                .Map(dest => dest.CreatedAt, src => src.created_at.GetDateTimeFromUnixTime())
                .Map(dest => dest.UpdatedAt, src => src.updated_at.GetDateTimeFromUnixTime())
                .Map(dest => dest.AccountId, src => src.account_id)
                .Map(dest => dest.GroupId, src => src.group_id)
                .Map(dest => dest.ElementId, src => src.element_id)
                .Map(dest => dest.ElementType, src => src.element_type);

            TypeAdapterConfig<NoteParamsDTO, INoteParam>
                .NewConfig()
                .MapWith(src => src.Adapt<NoteParam>());

            TypeAdapterConfig<NoteParamsDTO, NoteParam>
                .NewConfig()
                .Map(dest => dest.Service, src => src.service)
                .Map(dest => dest.Text, src => src.text)
                .Map(dest => dest.Uniq, src => src.uniq)
                .Map(dest => dest.Src, src => src.src)
                .Map(dest => dest.Sender, src => src.sender)
                .Map(dest => dest.Phone, src => src.phone)
                .Map(dest => dest.Link, src => src.link)
                .Map(dest => dest.Html, src => src.html)
                .Map(dest => dest.From, src => src.from)
                .Map(dest => dest.Duration, src => src.duration)
                .Map(dest => dest.CallStatus, src => src.call_status)
                .Map(dest => dest.CallResult, src => src.call_result);
        }
    }
}
