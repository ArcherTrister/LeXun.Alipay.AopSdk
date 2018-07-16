using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     PubChannelDTO Data Structure.
	/// </summary>
	[Serializable]
	public class PubChannelDTO : AopObject
	{
		/// <summary>
		///     扩展信息，无需配置
		/// </summary>
		[JsonProperty("ext_info")]
		public string ExtInfo { get; set; }

		/// <summary>
		///     1、SHOP_DETAIL:店铺详情页   2、PAYMENT_RESULT: 支付成功页（支付成功页暂不支持）
		/// </summary>
		[JsonProperty("pub_channel")]
		public string PubChannel { get; set; }
	}
}