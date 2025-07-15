namespace LocalApi23CSharp.Types;

using NJ = Newtonsoft.Json;

/// <summary>
/// Pet
/// </summary>
public class Pet
{
    [NJ.JsonProperty(
        "category",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public Category? Category { get; set; }

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
    public PetStatusEnum? Status { get; set; }

    [NJ.JsonProperty(
        "tags",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public List<Tag>? Tags { get; set; }

    public override string ToString()
    {
        return NJ.JsonConvert.SerializeObject(this);
    }
}
