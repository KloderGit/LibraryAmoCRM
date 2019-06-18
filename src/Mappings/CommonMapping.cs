using LibraryAmoCRM.DTO;
using LibraryAmoCRM.Interfaces;
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

            TypeAdapterConfig<ICustomField, DTO.CustomFieldDTO>
                .ForType()
                .Map(dest => dest.id, src => src.Id)
                .Map(dest => dest.name, src => src.Name)
                .Map(dest => dest.code, src => src.Code)
                .Map(dest => dest.is_system, src => src.IsSystem)
                .Map(dest => dest.values, src => src.Values);

            TypeAdapterConfig<ICustomFieldValue, CustomFieldValueDTO>
                .ForType()
                .Map(dest => dest.@enum, src => src.Enum)
                .Map(dest => dest.value, src => src.Value);
        }
    }
}
