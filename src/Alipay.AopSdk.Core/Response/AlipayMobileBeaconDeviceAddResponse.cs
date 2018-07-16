using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobileBeaconDeviceAddResponse.
	/// </summary>
	public class AlipayMobileBeaconDeviceAddResponse : AopResponse
	{
		/// <summary>
		///     请求操作成功与否，200为成功
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     请求的处理结果
		/// </summary>
		[JsonProperty("msg")]
		public string Msg { get; set; }
	}
}