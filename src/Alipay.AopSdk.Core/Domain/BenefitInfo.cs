using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     BenefitInfo Data Structure.
	/// </summary>
	[Serializable]
	public class BenefitInfo : AopObject
	{
		/// <summary>
		///     权益信息id
		/// </summary>
		[JsonProperty("benefit_info_id")]
		public string BenefitInfoId { get; set; }

		/// <summary>
		///     权益名称
		/// </summary>
		[JsonProperty("benefit_name")]
		public string BenefitName { get; set; }

		/// <summary>
		///     权益中文名称
		/// </summary>
		[JsonProperty("benefit_name_cn")]
		public string BenefitNameCn { get; set; }

		/// <summary>
		///     权益类型(会员等级: MemberGrade)
		/// </summary>
		[JsonProperty("benefit_type")]
		public string BenefitType { get; set; }

		/// <summary>
		///     权益发放时间
		/// </summary>
		[JsonProperty("dispatch_dt")]
		public string DispatchDt { get; set; }

		/// <summary>
		///     权益失效时间
		/// </summary>
		[JsonProperty("end_dt")]
		public string EndDt { get; set; }

		/// <summary>
		///     权益生效时间
		/// </summary>
		[JsonProperty("start_dt")]
		public string StartDt { get; set; }

		/// <summary>
		///     权益当前状态       * 待生效：WAIT  * 生效：VALID  * 失效：INVALID
		/// </summary>
		[JsonProperty("status")]
		public string Status { get; set; }
	}
}