using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     RefundDetail Data Structure.
	/// </summary>
	[Serializable]
	public class RefundDetail : AopObject
	{
		/// <summary>
		///     交易退款金额
		/// </summary>
		[JsonProperty("refund_amount")]
		public string RefundAmount { get; set; }

		/// <summary>
		///     退款备注
		/// </summary>
		[JsonProperty("refund_memo")]
		public string RefundMemo { get; set; }

		/// <summary>
		///     退分润列表
		/// </summary>
		[JsonProperty("refund_royaltys")]
		
		public List<RefundRoyaltyInfo> RefundRoyaltys { get; set; }

		/// <summary>
		///     退补差金额
		/// </summary>
		[JsonProperty("refund_suppl_amount")]
		public string RefundSupplAmount { get; set; }

		/// <summary>
		///     退补差备注
		/// </summary>
		[JsonProperty("refund_suppl_memo")]
		public string RefundSupplMemo { get; set; }

		/// <summary>
		///     支付宝交易号
		/// </summary>
		[JsonProperty("trade_no")]
		public string TradeNo { get; set; }
	}
}