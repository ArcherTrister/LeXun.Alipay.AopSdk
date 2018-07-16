using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicAccountResetModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicAccountResetModel : AopObject
	{
		/// <summary>
		///     需要重置的协议号，商户会员在支付宝服务窗账号中的唯一标识
		/// </summary>
		[JsonProperty("agreement_id")]
		public string AgreementId { get; set; }

		/// <summary>
		///     绑定帐号，建议在开发者的系统中保持唯一性
		/// </summary>
		[JsonProperty("bind_account_no")]
		public string BindAccountNo { get; set; }

		/// <summary>
		///     开发者期望在服务窗首页看到的关于该用户的显示信息，最长10个字符
		/// </summary>
		[JsonProperty("display_name")]
		public string DisplayName { get; set; }

		/// <summary>
		///     要绑定的商户会员对应的支付宝userid，2088开头长度为16位的字符串
		/// </summary>
		[JsonProperty("from_user_id")]
		public string FromUserId { get; set; }

		/// <summary>
		///     要绑定的商户会员的真实姓名，最长10个汉字
		/// </summary>
		[JsonProperty("real_name")]
		public string RealName { get; set; }

		/// <summary>
		///     备注信息，开发者可以通过该字段纪录其他的额外信息
		/// </summary>
		[JsonProperty("remark")]
		public string Remark { get; set; }
	}
}