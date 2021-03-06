// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Microsoft.Azure.Management.Compute.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AccessLevel.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccessLevel
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Read")]
        Read
    }
    internal static class AccessLevelEnumExtension
    {
        internal static string ToSerializedValue(this AccessLevel? value)  =>
            value == null ? null : ((AccessLevel)value).ToSerializedValue();

        internal static string ToSerializedValue(this AccessLevel value)
        {
            switch( value )
            {
                case AccessLevel.None:
                    return "None";
                case AccessLevel.Read:
                    return "Read";
            }
            return null;
        }

        internal static AccessLevel? ParseAccessLevel(this string value)
        {
            switch( value )
            {
                case "None":
                    return AccessLevel.None;
                case "Read":
                    return AccessLevel.Read;
            }
            return null;
        }
    }
}
