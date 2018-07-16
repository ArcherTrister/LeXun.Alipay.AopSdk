using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMsaasMediarecogVoiceMediaaudioUploadResponse.
	/// </summary>
	public class AlipayMsaasMediarecogVoiceMediaaudioUploadResponse : AopResponse
	{
		/// <summary>
		///     扩展字段
		/// </summary>
		[JsonProperty("extinfo_a")]
		public string ExtinfoA { get; set; }

		/// <summary>
		///     扩展字段
		/// </summary>
		[JsonProperty("extinfo_b")]
		public string ExtinfoB { get; set; }

		/// <summary>
		///     结果memo
		/// </summary>
		[JsonProperty("result_memo")]
		public string ResultMemo { get; set; }

		/// <summary>
		///     结果状态
		/// </summary>
		[JsonProperty("result_status")]
		public string ResultStatus { get; set; }
	}
}