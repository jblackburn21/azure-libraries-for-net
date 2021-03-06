// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Azure.Management.Logic.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for PartnerType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PartnerType
    {
        [EnumMember(Value = "NotSpecified")]
        NotSpecified,
        [EnumMember(Value = "B2B")]
        B2B
    }
    internal static class PartnerTypeEnumExtension
    {
        internal static string ToSerializedValue(this PartnerType? value)
        {
            return value == null ? null : ((PartnerType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this PartnerType value)
        {
            switch( value )
            {
                case PartnerType.NotSpecified:
                    return "NotSpecified";
                case PartnerType.B2B:
                    return "B2B";
            }
            return null;
        }

        internal static PartnerType? ParsePartnerType(this string value)
        {
            switch( value )
            {
                case "NotSpecified":
                    return PartnerType.NotSpecified;
                case "B2B":
                    return PartnerType.B2B;
            }
            return null;
        }
    }
}
