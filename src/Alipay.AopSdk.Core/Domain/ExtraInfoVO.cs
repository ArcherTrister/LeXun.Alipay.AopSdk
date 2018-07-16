using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ExtraInfoVO Data Structure.
	/// </summary>
	[Serializable]
	public class ExtraInfoVO : AopObject
	{
		/// <summary>
		///     是否是taomaomao好友关系
		/// </summary>
		[JsonProperty("maomao_friend")]
		public bool MaomaoFriend { get; set; }

		/// <summary>
		///     是否注册taomaomao游戏
		/// </summary>
		[JsonProperty("maomao_register")]
		public bool MaomaoRegister { get; set; }

		/// <summary>
		///     支付宝对应的taobao_id
		/// </summary>
		[JsonProperty("taobao_id")]
		public string TaobaoId { get; set; }
	}
}