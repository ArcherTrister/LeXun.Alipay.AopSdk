using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicAccountCreateResponse.
	/// </summary>
	public class AlipayOpenPublicAccountCreateResponse : AopResponse
	{
		/// <summary>
		///     协议号，商户会员在支付宝服务窗账号中的唯一标识
		/// </summary>
		[JsonProperty("agreement_id")]
		public string AgreementId { get; set; }
	}
}