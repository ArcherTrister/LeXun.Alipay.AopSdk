using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayTrustUserRiskidentifyGetResponse.
	/// </summary>
	public class AlipayTrustUserRiskidentifyGetResponse : AopResponse
	{
		/// <summary>
		///     行业关注名单识别结果
		/// </summary>
		[JsonProperty("ali_trust_risk_identify")]
		public AliTrustRiskIdentify AliTrustRiskIdentify { get; set; }
	}
}