namespace LocalApi23CSharp.Types;

using NJ = Newtonsoft.Json;

/// <summary>
/// Order
/// </summary>
public class Order
{
    [NJ.JsonProperty(
        "complete",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public bool? Complete { get; set; }

    [NJ.JsonProperty(
        "id",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public int? Id { get; set; }

    [NJ.JsonProperty(
        "petId",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public int? PetId { get; set; }

    [NJ.JsonProperty(
        "quantity",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public int? Quantity { get; set; }

    [NJ.JsonProperty(
        "shipDate",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public string? ShipDate { get; set; }

    /// <summary>
    /// Order Status
    /// </summary>
    [NJ.JsonProperty(
        "status",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public OrderStatusEnum? Status { get; set; }

    public override string ToString()
    {
        return NJ.JsonConvert.SerializeObject(this);
    }
}
