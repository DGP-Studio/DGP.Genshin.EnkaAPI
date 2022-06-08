using Newtonsoft.Json;

namespace DGP.Genshin.EnkaAPI.Model;

public class TypeValue
{
    /// <summary>
    /// 类型Id
    /// </summary>
    [JsonProperty("type")]
    public int Type { get; set; }

    /// <summary>
    /// 值
    /// </summary>
    [JsonProperty("ival")]
    public string Ival { get; set; } = default!;

    [JsonProperty("val")]
    [Obsolete("useless")]
    public string? Val { get; set; }
}
