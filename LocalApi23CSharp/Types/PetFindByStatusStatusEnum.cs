namespace LocalApi23CSharp.Types;

using NJ = Newtonsoft.Json;
using SRS = System.Runtime.Serialization;

/// <summary>
/// Status values that need to be considered for filter
/// </summary>
[NJ.JsonConverter(typeof(NJ.Converters.StringEnumConverter))]
public enum PetFindByStatusStatusEnum
{
    [SRS.EnumMember(Value = "available")]
    Available,

    [SRS.EnumMember(Value = "pending")]
    Pending,

    [SRS.EnumMember(Value = "sold")]
    Sold,
}
