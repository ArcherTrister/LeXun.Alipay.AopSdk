using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ZhimaMerchantOrderRentCancelModel Data Structure.
	/// </summary>
	[Serializable]
	public class ZhimaMerchantOrderRentCancelModel : AopObject
	{
		/// <summary>
		///     信用借还订单号
		/// </summary>
		[JsonProperty("order_no")]
		public string OrderNo { get; set; }

		/// <summary>
		///     信用借还的产品码:w1010100000000002858
		/// </summary>
		[JsonProperty("product_code")]
		public string ProductCode { get; set; }
	}
}