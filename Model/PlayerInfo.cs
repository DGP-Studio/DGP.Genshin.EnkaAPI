using Newtonsoft.Json;

namespace DGP.Genshin.EnkaAPI.Model;

/// <summary>
/// 玩家信息
/// </summary>
public class PlayerInfo
{
    /// <summary>
    /// 昵称
    /// </summary>
    [JsonProperty("nickname")]
    public string Nickname { get; set; } = default!;

    /// <summary>
    /// 等级
    /// </summary>
    [JsonProperty("level")]
    public int Level { get; set; }

    /// <summary>
    /// 签名
    /// </summary>
    [JsonProperty("signature")]
    public string Signature { get; set; } = default!;

    /// <summary>
    /// 世界等级
    /// </summary>
    [JsonProperty("worldLevel")]
    public int WorldLevel { get; set; }

    /// <summary>
    /// 名片的Id
    /// </summary>
    [JsonProperty("nameCardId")]
    public int NameCardId { get; set; }

    /// <summary>
    /// 完成的成就个数
    /// </summary>
    [JsonProperty("finishAchievementNum")]
    public int FinishAchievementNum { get; set; }

    /// <summary>
    /// 深渊层数
    /// </summary>
    [JsonProperty("towerFloorIndex")]
    public int TowerFloorIndex { get; set; }

    /// <summary>
    /// 深渊间数
    /// </summary>
    [JsonProperty("towerLevelIndex")]
    public int TowerLevelIndex { get; set; }

    /// <summary>
    /// 展示的角色信息
    /// </summary>
    [JsonProperty("showAvatarInfoList")]
    public IList<ShowAvatarInfo> ShowAvatarInfoList { get; set; } = default!;

    /// <summary>
    /// 展示的名片信息
    /// </summary>
    [JsonProperty("showNameCardIdList")]
    public IList<int> ShowNameCardIdList { get; set; } = default!;

    /// <summary>
    /// 头像信息
    /// </summary>
    [JsonProperty("profilePicture")]
    public ProfilePicture ProfilePicture { get; set; } = default!;
}
