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
    internal class TaskMapping
    {
        public TaskMapping()
        {
            TypeAdapterConfig<ITask, TaskDTO>
                .NewConfig()
                .Map(dest => dest.id, src => src.Id)
                .Map(dest => dest.text, src => src.Text)
                .Map(dest => dest.is_completed, src => src.IsCompleted)
                .Map(dest => dest.complete_till_at, src => src.CompleteTillAt.GetUnixTimeSeconds())
                .Map(dest => dest.task_type, src => src.TaskType)
                .Map(dest => dest.responsible_user_id, src => src.ResponsibleUserId)
                .Map(dest => dest.created_by, src => src.CreatedBy)
                .Map(dest => dest.created_at, src => src.CreatedAt.GetUnixTimeSeconds())
                .Map(dest => dest.updated_at, src => src.UpdatedAt.GetUnixTimeSeconds())
                .Map(dest => dest.account_id, src => src.AccountId)
                .Map(dest => dest.group_id, src => src.GroupId)
                .Map(dest => dest.element_id, src => src.ElementId)
                .Map(dest => dest.element_type, src => src.ElementType)
                .Map(dest => dest.result, src => src.Result);

            TypeAdapterConfig<IToDoObject, IntentDTO>
                .NewConfig()
                .Map(dest => dest.id, src => src.Id)
                .Map(dest => dest.text, src => src.Text);


            TypeAdapterConfig<TaskDTO, ITask>
                .NewConfig()
                .MapWith(src => src.Adapt<Task>());

            TypeAdapterConfig<TaskDTO, Task>
                .NewConfig()
                .Map(dest => dest.Id, src => src.id)
                .Map(dest => dest.Text, src => src.text)
                .Map(dest => dest.IsCompleted, src => src.is_completed)
                .Map(dest => dest.CompleteTillAt, src => src.complete_till_at.GetDateTimeFromUnixTime())
                .Map(dest => dest.TaskType, src => src.task_type)
                .Map(dest => dest.ResponsibleUserId, src => src.responsible_user_id)
                .Map(dest => dest.CreatedBy, src => src.created_by)
                .Map(dest => dest.CreatedAt, src => src.created_at.GetDateTimeFromUnixTime())
                .Map(dest => dest.UpdatedAt, src => src.updated_at.GetDateTimeFromUnixTime())
                .Map(dest => dest.AccountId, src => src.account_id)
                .Map(dest => dest.GroupId, src => src.group_id)
                .Map(dest => dest.ElementId, src => src.element_id)
                .Map(dest => dest.ElementType, src => src.element_type)
                .Map(dest => dest.Result, src => src.result);

            TypeAdapterConfig<IntentDTO, IToDoObject>
                .NewConfig()
                .MapWith(src => src.Adapt<ServiceObject>());

            TypeAdapterConfig<IntentDTO, ServiceObject>
                .NewConfig()
                .Map(dest => dest.Id, src => src.id)
                .Map(dest => dest.Text, src => src.text);
        }
    }
}
