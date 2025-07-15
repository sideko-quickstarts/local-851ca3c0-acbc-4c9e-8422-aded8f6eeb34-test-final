namespace LocalApi23CSharp.Types;

using NJ = Newtonsoft.Json;

/// <summary>
/// Tag
/// </summary>
public class Tag
{
    [NJ.JsonProperty(
        "id",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public int? Id { get; set; }

    [NJ.JsonProperty(
        "name",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public string? Name { get; set; }

    public override string ToString()
    {
        return NJ.JsonConvert.SerializeObject(this);
    }
}
