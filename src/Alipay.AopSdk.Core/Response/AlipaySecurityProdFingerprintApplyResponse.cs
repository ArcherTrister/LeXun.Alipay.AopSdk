using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipaySecurityProdFingerprintApplyResponse.
	/// </summary>
	public class AlipaySecurityProdFingerprintApplyResponse : AopResponse
	{
		/// <summary>
		///     IFAA标准中的校验类型，目前1为指纹
		/// </summary>
		[JsonProperty("auth_type")]
		public string AuthType { get; set; }

		/// <summary>
		///     设备的唯一ID，IFAA标准体系中的设备的唯一标识，用于关联设备的开通状态
		/// </summary>
		[JsonProperty("device_id")]
		public string DeviceId { get; set; }

		/// <summary>
		///     IFAA标准中用于关联IFAA Server和业务方Server开通状态的token，此token用于后续校验和注销操作。
		/// </summary>
		[JsonProperty("token")]
		public string Token { get; set; }
	}
}