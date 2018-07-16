using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     GetRuleInfo Data Structure.
	/// </summary>
	[Serializable]
	public class GetRuleInfo : AopObject
	{
		/// <summary>
		///     截至时间
		/// </summary>
		[JsonProperty("end_time")]
		public string EndTime { get; set; }

		/// <summary>
		///     发放次数限制
		/// </summary>
		[JsonProperty("get_count_limit")]
		public PeriodInfo GetCountLimit { get; set; }

		/// <summary>
		///     开始时间
		/// </summary>
		[JsonProperty("start_time")]
		public string StartTime { get; set; }
	}
}