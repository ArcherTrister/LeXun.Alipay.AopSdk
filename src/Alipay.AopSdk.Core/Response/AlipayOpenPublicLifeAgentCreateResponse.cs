using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicLifeAgentCreateResponse.
	/// </summary>
	public class AlipayOpenPublicLifeAgentCreateResponse : AopResponse
	{
		/// <summary>
		///     外部入驻申请单据号
		/// </summary>
		[JsonProperty("out_biz_no")]
		public string OutBizNo { get; set; }
	}
}