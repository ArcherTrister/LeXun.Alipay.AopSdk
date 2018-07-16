using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingProductContext Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingProductContext : AopObject
	{
		/// <summary>
		///     客户端client_id
		/// </summary>
		[JsonProperty("client_id")]
		public string ClientId { get; set; }

		/// <summary>
		///     product需要接入的时候和支付宝码平台约定。  目前仅支持建行app使用ccb_wallet
		/// </summary>
		[JsonProperty("product")]
		public string Product { get; set; }

		/// <summary>
		///     版本号
		/// </summary>
		[JsonProperty("product_version")]
		public string ProductVersion { get; set; }
	}
}