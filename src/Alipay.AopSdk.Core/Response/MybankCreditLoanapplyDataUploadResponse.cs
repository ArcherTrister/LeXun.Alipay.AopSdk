using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     MybankCreditLoanapplyDataUploadResponse.
	/// </summary>
	public class MybankCreditLoanapplyDataUploadResponse : AopResponse
	{
		/// <summary>
		///     数据在网商银行内部系统的唯一ID。由网商银行融资平台的系统生成，返回给外部机构。
		/// </summary>
		[JsonProperty("data_id")]
		public string DataId { get; set; }
	}
}