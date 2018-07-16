using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayCommerceCityfacilitatorVoucherBatchqueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayCommerceCityfacilitatorVoucherBatchqueryModel : AopObject
	{
		/// <summary>
		///     城市编码请参考查询：http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/201504/t20150415_712722.html；  已支持城市：广州 440100，深圳
		///     440300，杭州330100。
		/// </summary>
		[JsonProperty("city_code")]
		public string CityCode { get; set; }

		/// <summary>
		///     支付宝交易号列表
		/// </summary>
		[JsonProperty("trade_nos")]
		
		public List<string> TradeNos { get; set; }
	}
}