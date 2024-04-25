﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using euroskill2025;
//
//    var container = Container.FromJson(jsonString);
using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace euroskill2025
{
    
    public partial class Container
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("blockId")]
        public long BlockId { get; set; }

        [JsonProperty("bayNum")]
        public long BayNum { get; set; }

        [JsonProperty("stackNum")]
        public long StackNum { get; set; }

        [JsonProperty("tierNum")]
        public long TierNum { get; set; }

        [JsonProperty("arrivedAt")]
        public DateTimeOffset ArrivedAt { get; set; }
    }

    public partial class Container
    {
        public static List<Container> FromJson(string json) => JsonConvert.DeserializeObject<List<Container>>(json, euroskill2025.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<Container> self) => JsonConvert.SerializeObject(self, euroskill2025.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}