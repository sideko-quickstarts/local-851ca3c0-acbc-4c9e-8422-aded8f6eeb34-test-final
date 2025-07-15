namespace LocalApi23CSharp.Types;

using NJ = Newtonsoft.Json;
using SRS = System.Runtime.Serialization;

/// <summary>
/// Order Status
/// </summary>
[NJ.JsonConverter(typeof(NJ.Converters.StringEnumConverter))]
public enum OrderStatusEnum
{
    [SRS.EnumMember(Value = "approved")]
    Approved,

    [SRS.EnumMember(Value = "delivered")]
    Delivered,

    [SRS.EnumMember(Value = "placed")]
    Placed,
}
