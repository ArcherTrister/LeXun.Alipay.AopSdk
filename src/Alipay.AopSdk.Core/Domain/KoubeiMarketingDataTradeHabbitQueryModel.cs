using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingDataTradeHabbitQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingDataTradeHabbitQueryModel : AopObject
	{
		/// <summary>
		///     业务日期
		/// </summary>
		[JsonProperty("biz_date")]
		public string BizDate { get; set; }

		/// <summary>
		///     门店列表,门店用逗号分割，最多支持10个门店。  不填时,则为商户维度汇总数据
		/// </summary>
		[JsonProperty("store_ids")]
		public string StoreIds { get; set; }
	}
}