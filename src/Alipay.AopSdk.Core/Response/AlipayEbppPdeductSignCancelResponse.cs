using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEbppPdeductSignCancelResponse.
	/// </summary>
	public class AlipayEbppPdeductSignCancelResponse : AopResponse
	{
		/// <summary>
		///     支付宝代扣协议ID
		/// </summary>
		[JsonProperty("agreement_id")]
		public string AgreementId { get; set; }

		/// <summary>
		///     支付宝协议状态。解约成功则返回success
		/// </summary>
		[JsonProperty("agreement_status")]
		public string AgreementStatus { get; set; }

		/// <summary>
		///     商户代扣协议ID
		/// </summary>
		[JsonProperty("out_agreement_id")]
		public string OutAgreementId { get; set; }
	}
}