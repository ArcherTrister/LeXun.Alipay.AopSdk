using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCardBenefitModifyResponse.
	/// </summary>
	public class AlipayMarketingCardBenefitModifyResponse : AopResponse
	{
		/// <summary>
		///     权益修改结果；true成功：false失败
		/// </summary>
		[JsonProperty("result")]
		public bool Result { get; set; }
	}
}