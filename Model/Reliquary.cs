using Newtonsoft.Json;

namespace DGP.Genshin.EnkaAPI.Model;

public class Reliquary
{
    /// <summary>
    /// 等级 +20 = 21
    /// [1,21]
    /// </summary>
    [JsonProperty("level")]
    public int Level { get; set; }

    /// <summary>
    /// 主属性Id
    /// </summary>
    [JsonProperty("mainPropId")]
    public int MainPropId { get; set; }

    /// <summary>
    /// 强化属性Id
    /// </summary>
    [JsonProperty("appendPropIdList")]
    public IList<int> AppendPropIdList { get; set; } = default!;
}
