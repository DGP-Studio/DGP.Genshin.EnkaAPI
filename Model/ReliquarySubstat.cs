using Newtonsoft.Json;

namespace DGP.Genshin.EnkaAPI.Model;

public class ReliquarySubstat
{
    [JsonProperty("appendPropId")]
    public string AppendPropId { get; set; } = default!;

    [JsonProperty("statValue")]
    public double StatValue { get; set; }
}
