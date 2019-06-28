using LibraryAmoCRM.DTO;
using LibraryAmoCRM.Extensions;
using LibraryAmoCRM.Interfaces;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Mappings
{
    internal class TaskMapping
    {
        public TaskMapping()
        {
            TypeAdapterConfig<ITask, TaskDTO>
                .NewConfig()
                .Map(dest => dest.id, src => src.Id)
                .Map(dest => dest.text, src => src.Text)
                .Map(dest => dest.is_completed, src => src.IsCompleted)
                .Map(dest => dest.complete_till_at, src => src.CompleteTillAt)
                .Map(dest => dest.task_type, src => src.TaskType)
                .Map(dest => dest.responsible_user_id, src => src.ResponsibleUserId)
                .Map(dest => dest.created_by, src => src.CreatedBy)
                .Map(dest => dest.created_at, src => src.CreatedAt.GetUnixTimeSeconds())
                .Map(dest => dest.updated_at, src => src.UpdatedAt.GetUnixTimeSeconds())
                .Map(dest => dest.account_id, src => src.AccountId)
                .Map(dest => dest.group_id, src => src.GroupId)
                .Map(dest => dest.element_id, src => src.ElementId)
                .Map(dest => dest.element_type, src => src.ElementType)
                .Map(dest => dest.element_type, src => src.ElementType)
                .Map(dest => dest.result, src => src.Result);

            TypeAdapterConfig<IToDoObject, IntentDTO>
                .NewConfig()
                .Map(dest => dest.id, src => src.Id)
                .Map(dest => dest.text, src => src.Text);
        }
    }
}
