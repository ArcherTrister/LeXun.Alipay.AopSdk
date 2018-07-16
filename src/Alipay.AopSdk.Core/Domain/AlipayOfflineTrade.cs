using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOfflineTrade Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOfflineTrade : AopObject
	{
		/// <summary>
		///     交易实际发生时间
		/// </summary>
		[JsonProperty("actual_order_time")]
		public string ActualOrderTime { get; set; }

		/// <summary>
		///     交易金额
		/// </summary>
		[JsonProperty("amount")]
		public string Amount { get; set; }

		/// <summary>
		///     交易扩展信息,json格式字符串。
		/// </summary>
		[JsonProperty("order_biz_context")]
		public string OrderBizContext { get; set; }

		/// <summary>
		///     支付宝外部交易号，唯一表示一笔商户支付宝交易。商户必须保证唯一。
		/// </summary>
		[JsonProperty("out_trade_no")]
		public string OutTradeNo { get; set; }

		/// <summary>
		///     原始脱机操作记录
		/// </summary>
		[JsonProperty("records")]
		
		public List<string> Records { get; set; }

		/// <summary>
		///     如果该值为空，则默认为商户签约账号对应的支付宝用户ID
		/// </summary>
		[JsonProperty("seller_login_name")]
		public string SellerLoginName { get; set; }

		/// <summary>
		///     脱机交易标题
		/// </summary>
		[JsonProperty("subject")]
		public string Subject { get; set; }

		/// <summary>
		///     用户id
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}