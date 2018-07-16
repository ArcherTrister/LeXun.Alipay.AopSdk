using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicQrcodeCreateResponse.
	/// </summary>
	public class AlipayOpenPublicQrcodeCreateResponse : AopResponse
	{
		/// <summary>
		///     二维码图片地址，可跳转到实际图片
		/// </summary>
		[JsonProperty("code_img")]
		public string CodeImg { get; set; }

		/// <summary>
		///     二维码有效时间，单位（秒）。永久码暂时忽略该信息
		/// </summary>
		[JsonProperty("expire_second")]
		public string ExpireSecond { get; set; }
	}
}