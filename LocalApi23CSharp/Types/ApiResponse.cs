namespace LocalApi23CSharp.Types;

using NJ = Newtonsoft.Json;

/// <summary>
/// ApiResponse
/// </summary>
public class ApiResponse
{
    [NJ.JsonProperty(
        "code",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public int? Code { get; set; }

    [NJ.JsonProperty(
        "message",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public string? Message { get; set; }

    [NJ.JsonProperty(
        "type",
        Required = NJ.Required.Default,
        NullValueHandling = NJ.NullValueHandling.Ignore
    )]
    public string? Type { get; set; }

    public override string ToString()
    {
        return NJ.JsonConvert.SerializeObject(this);
    }
}
