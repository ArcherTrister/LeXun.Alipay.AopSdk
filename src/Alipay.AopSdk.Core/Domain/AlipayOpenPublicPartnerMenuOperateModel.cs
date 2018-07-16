using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicPartnerMenuOperateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicPartnerMenuOperateModel : AopObject
	{
		/// <summary>
		///     行为参数
		/// </summary>
		[JsonProperty("action_param")]
		public string ActionParam { get; set; }

		/// <summary>
		///     行为类型(in，out，api)
		/// </summary>
		[JsonProperty("action_type")]
		public string ActionType { get; set; }

		/// <summary>
		///     协议号
		/// </summary>
		[JsonProperty("agreement_id")]
		public string AgreementId { get; set; }

		/// <summary>
		///     服务窗id
		/// </summary>
		[JsonProperty("public_id")]
		public string PublicId { get; set; }

		/// <summary>
		///     第三方账号ID ,银行卡号/户号/手机号
		/// </summary>
		[JsonProperty("third_account_id")]
		public string ThirdAccountId { get; set; }

		/// <summary>
		///     支付宝用户id
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}