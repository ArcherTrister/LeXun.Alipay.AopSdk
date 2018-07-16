using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicInfoModifyResponse.
	/// </summary>
	public class AlipayOpenPublicInfoModifyResponse : AopResponse
	{
		/// <summary>
		///     服务窗审核状态描述，如果审核驳回则有相关的驳回理由
		/// </summary>
		[JsonProperty("audit_desc")]
		public string AuditDesc { get; set; }

		/// <summary>
		///     服务窗审核状态，对于系统商而言，只有三个状态，AUDITING：审核中，AUDIT_FAILED：审核驳回，AUDIT_SUCCESS：审核通过。
		/// </summary>
		[JsonProperty("audit_status")]
		public string AuditStatus { get; set; }
	}
}