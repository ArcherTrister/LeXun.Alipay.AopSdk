using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoMycarPromoVoucherVerifyModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoMycarPromoVoucherVerifyModel : AopObject
	{
		/// <summary>
		///     订单编号
		/// </summary>
		[JsonProperty("order_no")]
		public string OrderNo { get; set; }

		/// <summary>
		///     订单状态 1. 待支付 4. 交易关闭 6. 待发货 53. 已评价 55. 已核销 56. 交易完成
		/// </summary>
		[JsonProperty("order_status")]
		public string OrderStatus { get; set; }

		/// <summary>
		///     核销码
		/// </summary>
		[JsonProperty("sms_code")]
		public string SmsCode { get; set; }
	}
}