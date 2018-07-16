using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipaySecurityRiskPolicyQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipaySecurityRiskPolicyQueryModel : AopObject
	{
		/// <summary>
		///     风险类型：表示风险处理或风险咨询——process/advice
		/// </summary>
		[JsonProperty("risk_type")]
		public string RiskType { get; set; }

		/// <summary>
		///     安全场景参数
		/// </summary>
		[JsonProperty("security_scene")]
		public SecurityScene SecurityScene { get; set; }

		/// <summary>
		///     服务上下文包括环境信息和用户信息
		/// </summary>
		[JsonProperty("service_context")]
		public ServiceContext ServiceContext { get; set; }
	}
}