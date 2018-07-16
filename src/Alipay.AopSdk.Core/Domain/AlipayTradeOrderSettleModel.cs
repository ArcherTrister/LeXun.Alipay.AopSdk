using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayTradeOrderSettleModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayTradeOrderSettleModel : AopObject
	{
		/// <summary>
		///     操作员id
		/// </summary>
		[JsonProperty("operator_id")]
		public string OperatorId { get; set; }

		/// <summary>
		///     结算请求流水号 开发者自行生成并保证唯一性
		/// </summary>
		[JsonProperty("out_request_no")]
		public string OutRequestNo { get; set; }

		/// <summary>
		///     分账明细信息
		/// </summary>
		[JsonProperty("royalty_parameters")]
		
		public List<OpenApiRoyaltyDetailInfoPojo> RoyaltyParameters { get; set; }

		/// <summary>
		///     支付宝订单号
		/// </summary>
		[JsonProperty("trade_no")]
		public string TradeNo { get; set; }
	}
}