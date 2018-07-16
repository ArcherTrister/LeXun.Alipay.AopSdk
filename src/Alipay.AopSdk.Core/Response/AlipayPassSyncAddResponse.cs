using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayPassSyncAddResponse.
	/// </summary>
	public class AlipayPassSyncAddResponse : AopResponse
	{
		/// <summary>
		///     成功时返回的业务参数信息。
		/// </summary>
		[JsonProperty("biz_result")]
		public string BizResult { get; set; }

		/// <summary>
		///     当新增alipass不成功时，产生的错误码。
		/// </summary>
		[JsonProperty("error_code")]
		public string ErrorCode { get; set; }

		/// <summary>
		///     成功标识
		/// </summary>
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}