namespace LocalApi23CSharp.Resources.Pet;

using NJ = Newtonsoft.Json;

/// <summary>
/// DeleteRequest
/// </summary>
public class DeleteRequest
{
    /// <summary>
    /// Pet id to delete
    /// </summary>
    [NJ.JsonProperty("petId", Required = NJ.Required.Always)]
    public int PetId { get; set; }

    public override string ToString()
    {
        return NJ.JsonConvert.SerializeObject(this);
    }
}

/// <summary>
/// FindByStatusRequest
/// </summary>
public class FindByStatusRequest
{
    /// <summary>
    /// Status values that need to be considered for filter
    /// </summary>
    [NJ.JsonProperty(
        "status",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public Types.PetFindByStatusStatusEnum? Status { get; set; }

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
    /// ID of pet to return
    /// </summary>
    [NJ.JsonProperty("petId", Required = NJ.Required.Always)]
    public int PetId { get; set; }

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
        "category",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public Types.Category? Category { get; set; }

    [NJ.JsonProperty(
        "id",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public int? Id { get; set; }

    [NJ.JsonProperty("name", Required = NJ.Required.Always)]
    public string Name { get; set; } = string.Empty;

    [NJ.JsonProperty("photoUrls", Required = NJ.Required.Always)]
    public List<string> PhotoUrls { get; set; } = new();

    /// <summary>
    /// pet status in the store
    /// </summary>
    [NJ.JsonProperty(
        "status",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public Types.PetStatusEnum? Status { get; set; }

    [NJ.JsonProperty(
        "tags",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public List<Types.Tag>? Tags { get; set; }

    public override string ToString()
    {
        return NJ.JsonConvert.SerializeObject(this);
    }
}

/// <summary>
/// UploadImageRequest
/// </summary>
public class UploadImageRequest
{
    [NJ.JsonProperty("data", Required = NJ.Required.Always)]
    public Core.UploadFile Data { get; set; } = default!;

    /// <summary>
    /// ID of pet to update
    /// </summary>
    [NJ.JsonProperty("petId", Required = NJ.Required.Always)]
    public int PetId { get; set; }

    /// <summary>
    /// Additional Metadata
    /// </summary>
    [NJ.JsonProperty(
        "additionalMetadata",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public string? AdditionalMetadata { get; set; }

    public override string ToString()
    {
        return NJ.JsonConvert.SerializeObject(this);
    }
}

/// <summary>
/// UpdateRequest
/// </summary>
public class UpdateRequest
{
    [NJ.JsonProperty(
        "category",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public Types.Category? Category { get; set; }

    [NJ.JsonProperty(
        "id",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public int? Id { get; set; }

    [NJ.JsonProperty("name", Required = NJ.Required.Always)]
    public string Name { get; set; } = string.Empty;

    [NJ.JsonProperty("photoUrls", Required = NJ.Required.Always)]
    public List<string> PhotoUrls { get; set; } = new();

    /// <summary>
    /// pet status in the store
    /// </summary>
    [NJ.JsonProperty(
        "status",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public Types.PetStatusEnum? Status { get; set; }

    [NJ.JsonProperty(
        "tags",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public List<Types.Tag>? Tags { get; set; }

    public override string ToString()
    {
        return NJ.JsonConvert.SerializeObject(this);
    }
}
