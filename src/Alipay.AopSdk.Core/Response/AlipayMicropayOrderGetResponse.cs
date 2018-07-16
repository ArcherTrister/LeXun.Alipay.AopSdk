using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMicropayOrderGetResponse.
	/// </summary>
	public class AlipayMicropayOrderGetResponse : AopResponse
	{
		/// <summary>
		///     冻结订单详情
		/// </summary>
		[JsonProperty("micro_pay_order_detail")]
		public MicroPayOrderDetail MicroPayOrderDetail { get; set; }
	}
}