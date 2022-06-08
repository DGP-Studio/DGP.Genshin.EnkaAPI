using Newtonsoft.Json;

namespace DGP.Genshin.EnkaAPI.Model;

public class AvatarInfo
{
    /// <summary>
    /// 角色Id
    /// </summary>
    [JsonProperty("avatarId")]
    public int AvatarId { get; set; }

    /// <summary>
    /// 基础属性
    /// </summary>
    [JsonProperty("propMap")]
    public PropMap PropMap { get; set; } = default!;

    /// <summary>
    /// 属性Map
    /// </summary>
    [JsonProperty("fightPropMap")]
    public IDictionary<string, double> FightPropMap { get; set; } = default!;

    /// <summary>
    /// 技能组Id
    /// </summary>
    [JsonProperty("skillDepotId")]
    public int SkillDepotId { get; set; }

    [JsonProperty("inherentProudSkillList")]
    public IList<int> InherentProudSkillList { get; set; } = default!;

    [JsonProperty("skillLevelMap")]
    public IDictionary<string, int> SkillLevelMap { get; set; } = default!;

    /// <summary>
    /// 装备列表
    /// 最后一个为武器
    /// </summary>
    [JsonProperty("equipList")]
    public IList<Equip> EquipList { get; set; } = default!;

    /// <summary>
    /// 好感度信息
    /// </summary>
    [JsonProperty("fetterInfo")]
    public FetterInfo FetterInfo { get; set; } = default!;

    [JsonProperty("talentIdList")]
    public IList<int> TalentIdList { get; set; } = default!;

    /// <summary>
    /// 皮肤Id
    /// </summary>
    [JsonProperty("costumeId")]
    public int? CostumeId { get; set; }

    [JsonProperty("proudSkillExtraLevelMap")]
    public ProudSkillExtraLevelMap ProudSkillExtraLevelMap { get; set; } = default!;
}
