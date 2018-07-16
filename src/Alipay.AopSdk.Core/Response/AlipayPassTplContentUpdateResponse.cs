using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayPassTplContentUpdateResponse.
	/// </summary>
	public class AlipayPassTplContentUpdateResponse : AopResponse
	{
		/// <summary>
		///     业务错误码
		/// </summary>
		[JsonProperty("error_code")]
		public string ErrorCode { get; set; }

		/// <summary>
		///     业务结果数据：包含serialNumber, pass_Id和操作类型
		/// </summary>
		[JsonProperty("result")]
		public string Result { get; set; }

		/// <summary>
		///     操作是否成功标识：T标识成功；F标识失败
		/// </summary>
		[JsonProperty("success")]
		public string Success { get; set; }
	}
}