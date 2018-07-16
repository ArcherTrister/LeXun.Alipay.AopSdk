using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEbppCommonBillQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEbppCommonBillQueryModel : AopObject
	{
		/// <summary>
		///     支付宝账单流水号（取自创建账单接口返回的alipay_order_no字段）
		/// </summary>
		[JsonProperty("bill_no")]
		public string BillNo { get; set; }
	}
}