using Newtonsoft.Json;

namespace DGP.Genshin.EnkaAPI.Model;

public class ReliquaryMainstat
{
    [JsonProperty("mainPropId")]
    public string MainPropId { get; set; } = default!;

    [JsonProperty("statValue")]
    public double StatValue { get; set; }
}
