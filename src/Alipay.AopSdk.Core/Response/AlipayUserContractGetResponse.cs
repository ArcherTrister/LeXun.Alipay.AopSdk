using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayUserContractGetResponse.
	/// </summary>
	public class AlipayUserContractGetResponse : AopResponse
	{
		/// <summary>
		///     支付宝用户订购信息
		/// </summary>
		[JsonProperty("alipay_contract")]
		public AlipayContract AlipayContract { get; set; }
	}
}