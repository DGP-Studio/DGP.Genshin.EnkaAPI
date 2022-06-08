using Newtonsoft.Json;

namespace DGP.Genshin.EnkaAPI.Model;

/// <summary>
/// Enka API 响应
/// </summary>
public class EnkaResponse
{
    /// <summary>
    /// 玩家基础信息
    /// </summary>
    [JsonProperty("playerInfo")]
    public PlayerInfo PlayerInfo { get; set; } = default!;

    /// <summary>
    /// 展示的角色详细信息列表
    /// </summary>
    [JsonProperty("avatarInfoList")]
    public IList<AvatarInfo> AvatarInfoList { get; set; } = default!;

    /// <summary>
    /// 刷新剩余秒数
    /// 生存时间值
    /// </summary>
    [JsonProperty("ttl")]
    public int Ttl { get; set; }
}
