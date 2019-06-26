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
                .ForType()
                .Map(dest => dest.id, src => src.Id)
                .Map(dest => dest.name, src => src.Name);

            TypeAdapterConfig<EntityDTO, ISimpleObject>
                .ForType()
                .MapWith(src => src.Adapt<SimpleObject>());

            TypeAdapterConfig<EntityDTO, SimpleObject>
                .ForType()
                .Map(dest => dest.Id, src => src.id)
                .Map(dest => dest.Name, src => src.name);


            TypeAdapterConfig<ICustomField, CustomFieldDTO>
                .ForType()
                .Map(dest => dest.id, src => src.Id)
                .Map(dest => dest.name, src => src.Name)
                .Map(dest => dest.code, src => src.Code)
                .Map(dest => dest.is_system, src => src.IsSystem)
                .Map(dest => dest.values, src => src.Values);

            TypeAdapterConfig<CustomFieldDTO, ICustomField>
                .ForType()
                .MapWith(src => src.Adapt<CustomField>());

            TypeAdapterConfig<CustomFieldDTO, CustomField>
                .ForType()
                .Map(dest => dest.Id, src => src.id)
                .Map(dest => dest.Name, src => src.name)
                .Map(dest => dest.Code, src => src.code)
                .Map(dest => dest.IsSystem, src => src.is_system)
                .Map(dest => dest.Values, src => src.values);



            TypeAdapterConfig<ICustomFieldValue, CustomFieldValueDTO>
                .ForType()
                .Map(dest => dest.@enum, src => src.Enum)
                .Map(dest => dest.value, src => src.Value);

            TypeAdapterConfig<CustomFieldValueDTO, ICustomFieldValue>
                .ForType()
                .MapWith(src => src.Adapt<CustomFieldValue>());

            TypeAdapterConfig<CustomFieldValueDTO, CustomFieldValue>
                .ForType()
                .Map(dest => dest.Enum, src => src.@enum)
                .Map(dest => dest.Value, src => src.value);
        }
    }
}
