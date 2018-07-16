using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ExRefRateInfoVO Data Structure.
	/// </summary>
	[Serializable]
	public class ExRefRateInfoVO : AopObject
	{
		/// <summary>
		///     货币对
		/// </summary>
		[JsonProperty("currency_pair")]
		public string CurrencyPair { get; set; }

		/// <summary>
		///     基础币种
		/// </summary>
		[JsonProperty("datum_currency")]
		public string DatumCurrency { get; set; }

		/// <summary>
		///     牌价类型，表示站在用户角度，对目标币种的交易方向，01表示买入，02表示卖出
		/// </summary>
		[JsonProperty("price_type")]
		public string PriceType { get; set; }

		/// <summary>
		///     报价日期，格式为YYYYMMDD
		/// </summary>
		[JsonProperty("pub_date")]
		public string PubDate { get; set; }

		/// <summary>
		///     报价时间
		/// </summary>
		[JsonProperty("pub_time")]
		public string PubTime { get; set; }

		/// <summary>
		///     汇率，表示一单位基准币种等于多少目标币种，小数点后最多精确到8位
		/// </summary>
		[JsonProperty("rate")]
		public string Rate { get; set; }

		/// <summary>
		///     目标币种
		/// </summary>
		[JsonProperty("target_currency")]
		public string TargetCurrency { get; set; }
	}
}