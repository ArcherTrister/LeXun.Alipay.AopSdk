using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     SaleProduct Data Structure.
	/// </summary>
	[Serializable]
	public class SaleProduct : AopObject
	{
		/// <summary>
		///     宝贝来源 例如：TAOBAO ALIPAY
		/// </summary>
		[JsonProperty("channel_type")]
		public string ChannelType { get; set; }

		/// <summary>
		///     销售产品DB ID
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		///     面额
		/// </summary>
		[JsonProperty("market_price")]
		public string MarketPrice { get; set; }

		/// <summary>
		///     充值产品提供商
		/// </summary>
		[JsonProperty("product_provider")]
		public ProductProvider ProductProvider { get; set; }

		/// <summary>
		///     销售价格
		/// </summary>
		[JsonProperty("sale_price")]
		public string SalePrice { get; set; }

		/// <summary>
		///     产品状态, 0为不可用，1为可用
		/// </summary>
		[JsonProperty("status")]
		public string Status { get; set; }
	}
}