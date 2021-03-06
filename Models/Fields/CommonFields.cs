﻿using Newtonsoft.Json;
using LibraryAmoCRM.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models
{
    public abstract class CommonFields: IHaveIdSingle
    {
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}