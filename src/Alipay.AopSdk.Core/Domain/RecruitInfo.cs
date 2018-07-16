using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     RecruitInfo Data Structure.
	/// </summary>
	[Serializable]
	public class RecruitInfo : AopObject
	{
		/// <summary>
		///     招商结束时间
		/// </summary>
		[JsonProperty("end_time")]
		public string EndTime { get; set; }

		/// <summary>
		///     是否参与门店参与了招商
		/// </summary>
		[JsonProperty("exclude_constraint_shops")]
		public bool ExcludeConstraintShops { get; set; }

		/// <summary>
		///     招商方案id
		/// </summary>
		[JsonProperty("plan_id")]
		public string PlanId { get; set; }

		/// <summary>
		///     招商开始时间
		/// </summary>
		[JsonProperty("start_time")]
		public string StartTime { get; set; }

		/// <summary>
		///     招商状态
		/// </summary>
		[JsonProperty("status")]
		public string Status { get; set; }
	}
}