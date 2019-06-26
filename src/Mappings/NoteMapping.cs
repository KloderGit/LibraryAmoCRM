using LibraryAmoCRM.DTO;
using LibraryAmoCRM.Extensions;
using LibraryAmoCRM.Interfaces;
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
                .ForType()
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
                .Map(dest => dest.element_type, src => src.ElementType)
                .Map(dest => dest.element_type, src => src.ElementType);

            TypeAdapterConfig<INoteParam, NoteParamsDTO>
                .ForType()
                .Map(dest => dest.service, src => src.Service)
                .Map(dest => dest.text, src => src.Text);
        }
    }
}
