using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcoEduKtBillingSendResponse.
	/// </summary>
	public class AlipayEcoEduKtBillingSendResponse : AopResponse
	{
		/// <summary>
		///     支付宝－中小学－教育缴费的账单号
		/// </summary>
		[JsonProperty("order_no")]
		public string OrderNo { get; set; }

		/// <summary>
		///     支付宝-中小学-教育缴费生成的学生唯一编号
		/// </summary>
		[JsonProperty("student_no")]
		public string StudentNo { get; set; }
	}
}