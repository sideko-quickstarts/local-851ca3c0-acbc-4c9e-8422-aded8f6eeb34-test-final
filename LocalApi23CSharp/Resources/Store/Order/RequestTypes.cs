namespace LocalApi23CSharp.Resources.Store.Order;

using NJ = Newtonsoft.Json;

/// <summary>
/// DeleteRequest
/// </summary>
public class DeleteRequest
{
    /// <summary>
    /// ID of the order that needs to be deleted
    /// </summary>
    [NJ.JsonProperty("orderId", Required = NJ.Required.Always)]
    public int OrderId { get; set; }

    public override string ToString()
    {
        return NJ.JsonConvert.SerializeObject(this);
    }
}

/// <summary>
/// GetRequest
/// </summary>
public class GetRequest
{
    /// <summary>
    /// ID of order that needs to be fetched
    /// </summary>
    [NJ.JsonProperty("orderId", Required = NJ.Required.Always)]
    public int OrderId { get; set; }

    public override string ToString()
    {
        return NJ.JsonConvert.SerializeObject(this);
    }
}

/// <summary>
/// CreateRequest
/// </summary>
public class CreateRequest
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
    public Types.OrderStatusEnum? Status { get; set; }

    public override string ToString()
    {
        return NJ.JsonConvert.SerializeObject(this);
    }
}
