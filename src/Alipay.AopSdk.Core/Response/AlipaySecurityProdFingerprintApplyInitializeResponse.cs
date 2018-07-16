using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipaySecurityProdFingerprintApplyInitializeResponse.
	/// </summary>
	public class AlipaySecurityProdFingerprintApplyInitializeResponse : AopResponse
	{
		/// <summary>
		///     server_response:服务端返回的协议体数据，对应《IFAA本地免密技术规范》中的IFAFMessage，内容中包含服务端的校验数据。
		/// </summary>
		[JsonProperty("server_response")]
		public string ServerResponse { get; set; }
	}
}