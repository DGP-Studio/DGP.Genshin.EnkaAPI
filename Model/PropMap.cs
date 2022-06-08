using Newtonsoft.Json;

namespace DGP.Genshin.EnkaAPI.Model;

public class PropMap
{
    [JsonProperty("1001")]
    public TypeValue A1001 { get; set; } = default!;

    /// <summary>
    /// 角色突破等级
    /// </summary>
    [JsonProperty("1002")]
    public TypeValue A1002 { get; set; } = default!;

    [JsonProperty("1003")]
    public TypeValue A1003 { get; set; } = default!;

    [JsonProperty("1004")]
    public TypeValue A1004 { get; set; } = default!;

    /// <summary>
    /// 当前角色等级
    /// </summary>
    [JsonProperty("4001")]
    public TypeValue A4001 { get; set; } = default!;

    [JsonProperty("10010")]
    public TypeValue A10010 { get; set; } = default!;
}
