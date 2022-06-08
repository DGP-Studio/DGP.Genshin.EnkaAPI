using Newtonsoft.Json;

namespace DGP.Genshin.EnkaAPI.Model;

public class Weapon
{
    /// <summary>
    /// 等级
    /// </summary>
    [JsonProperty("level")]
    public int Level { get; set; }

    /// <summary>
    /// 突破等级
    /// </summary>
    [JsonProperty("promoteLevel")]
    public int PromoteLevel { get; set; }

    /// <summary>
    /// 精炼 相较于实际等级 -1
    /// </summary>
    [JsonProperty("affixMap")]
    public IDictionary<string, int> AffixMap { get; set; } = default!;
}
