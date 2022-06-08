using Newtonsoft.Json;

namespace DGP.Genshin.EnkaAPI.Model;

public class Flat
{
    /// <summary>
    /// 名称
    /// </summary>
    [JsonProperty("nameTextMapHash")]
    public string NameTextMapHash { get; set; } = default!;

    /// <summary>
    /// 套装名称
    /// </summary>
    [JsonProperty("setNameTextMapHash")]
    public string SetNameTextMapHash { get; set; } = default!;

    /// <summary>
    /// 等级
    /// </summary>
    [JsonProperty("rankLevel")]
    public int RankLevel { get; set; }

    /// <summary>
    /// 圣遗物主属性
    /// </summary>
    [JsonProperty("reliquaryMainstat")]
    public ReliquaryMainstat ReliquaryMainstat { get; set; } = default!;

    /// <summary>
    /// 圣遗物副属性
    /// </summary>
    [JsonProperty("reliquarySubstats")]
    public IList<ReliquarySubstat> ReliquarySubstats { get; set; } = default!;

    /// <summary>
    /// 物品类型
    /// </summary>
    [JsonProperty("itemType")]
    public string ItemType { get; set; } = default!;

    /// <summary>
    /// 图标
    /// </summary>
    [JsonProperty("icon")]
    public string Icon { get; set; } = default!;

    /// <summary>
    /// 圣遗物类型
    /// </summary>
    [JsonProperty("equipType")]
    public string EquipType { get; set; } = default!;

    /// <summary>
    /// 武器主副属性
    /// 0 基础攻击力
    /// 1 主属性
    /// </summary>
    [JsonProperty("weaponStats")]
    public IList<WeaponStat>? WeaponStats { get; set; }
}
