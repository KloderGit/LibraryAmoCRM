using LibraryAmoCRM.DTO;
using LibraryAmoCRM.Interfaces;
using LibraryAmoCRM.Models;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Mappings
{
    internal class CommonMapping
    {
        public CommonMapping()
        {
            TypeAdapterConfig<ISimpleObject, EntityDTO>
                .NewConfig()
                .Map(dest => dest.id, src => src.Id)
                .Map(dest => dest.name, src => src.Name);

            TypeAdapterConfig<EntityDTO, ISimpleObject>
                .NewConfig()
                .MapWith(src => src.Adapt<SimpleObject>());

            TypeAdapterConfig<EntityDTO, SimpleObject>
                .NewConfig()
                .Map(dest => dest.Id, src => src.id)
                .Map(dest => dest.Name, src => src.name);


            TypeAdapterConfig<ICustomField, CustomFieldDTO>
                .NewConfig()
                .Map(dest => dest.id, src => src.Id)
                .Map(dest => dest.name, src => src.Name)
                .Map(dest => dest.code, src => src.Code)
                .Map(dest => dest.is_system, src => src.IsSystem)
                .Map(dest => dest.values, src => src.Values);

            TypeAdapterConfig<CustomFieldDTO, ICustomField>
                .NewConfig()
                .MapWith(src => src.Adapt<CustomField>());

            TypeAdapterConfig<CustomFieldDTO, CustomField>
                .NewConfig()
                .Map(dest => dest.Id, src => src.id)
                .Map(dest => dest.Name, src => src.name)
                .Map(dest => dest.Code, src => src.code)
                .Map(dest => dest.IsSystem, src => src.is_system)
                .Map(dest => dest.Values, src => src.values);



            TypeAdapterConfig<ICustomFieldValue, CustomFieldValueDTO>
                .NewConfig()
                .Map(dest => dest.@enum, src => src.Enum)
                .Map(dest => dest.value, src => src.Value);

            TypeAdapterConfig<CustomFieldValueDTO, ICustomFieldValue>
                .NewConfig()
                .MapWith(src => src.Adapt<CustomFieldValue>());

            TypeAdapterConfig<CustomFieldValueDTO, CustomFieldValue>
                .NewConfig()
                .Map(dest => dest.Enum, src => src.@enum)
                .Map(dest => dest.Value, src => src.value);
        }
    }
}
