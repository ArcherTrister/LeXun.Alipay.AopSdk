using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     MybankCreditLoantradeLoanrelationQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class MybankCreditLoantradeLoanrelationQueryModel : AopObject
	{
		/// <summary>
		///     工商注册号或者身份证号码
		/// </summary>
		[JsonProperty("cert_no")]
		public string CertNo { get; set; }

		/// <summary>
		///     当客户为公司时，certtype是全国组织机构代码证书。当客户为个人时，是居民身份证
		/// </summary>
		[JsonProperty("cert_type")]
		public string CertType { get; set; }

		/// <summary>
		///     预留的扩展字段
		/// </summary>
		[JsonProperty("ext_params")]
		public string ExtParams { get; set; }

		/// <summary>
		///     政策码
		/// </summary>
		[JsonProperty("loan_policy_code")]
		public string LoanPolicyCode { get; set; }

		/// <summary>
		///     当客户是公司时，entityname是公司名全称；当客户是个人时，entityname是姓名
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     产品码
		/// </summary>
		[JsonProperty("product_code")]
		public string ProductCode { get; set; }
	}
}