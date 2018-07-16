using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AgreementParams Data Structure.
	/// </summary>
	[Serializable]
	public class AgreementParams : AopObject
	{
		/// <summary>
		///     支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ）
		/// </summary>
		[JsonProperty("agreement_no")]
		public string AgreementNo { get; set; }

		/// <summary>
		///     鉴权申请token，其格式和内容，由支付宝定义。在需要做支付鉴权校验时，该参数不能为空。
		/// </summary>
		[JsonProperty("apply_token")]
		public string ApplyToken { get; set; }

		/// <summary>
		///     鉴权确认码，在需要做支付鉴权校验时，该参数不能为空
		/// </summary>
		[JsonProperty("auth_confirm_no")]
		public string AuthConfirmNo { get; set; }
	}
}