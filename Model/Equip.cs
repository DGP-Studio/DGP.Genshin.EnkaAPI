using Newtonsoft.Json;

namespace DGP.Genshin.EnkaAPI.Model;

public class Equip
{
    /// <summary>
    /// 物品Id
    /// </summary>
    [JsonProperty("itemId")]
    public int ItemId { get; set; }

    /// <summary>
    /// 圣遗物
    /// </summary>
    [JsonProperty("reliquary")]
    public Reliquary? Reliquary { get; set; }

    [JsonProperty("flat")]
    public Flat Flat { get; set; } = default!;

    /// <summary>
    /// 武器
    /// </summary>
    [JsonProperty("weapon")]
    public Weapon? Weapon { get; set; }
}
