using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoMycarMaintainBizorderQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoMycarMaintainBizorderQueryModel : AopObject
	{
		/// <summary>
		///     车主平台生成的订单号。
		/// </summary>
		[JsonProperty("order_no")]
		public string OrderNo { get; set; }
	}
}