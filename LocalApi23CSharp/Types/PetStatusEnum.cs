namespace LocalApi23CSharp.Types;

using NJ = Newtonsoft.Json;
using SRS = System.Runtime.Serialization;

/// <summary>
/// pet status in the store
/// </summary>
[NJ.JsonConverter(typeof(NJ.Converters.StringEnumConverter))]
public enum PetStatusEnum
{
    [SRS.EnumMember(Value = "available")]
    Available,

    [SRS.EnumMember(Value = "pending")]
    Pending,

    [SRS.EnumMember(Value = "sold")]
    Sold,
}
