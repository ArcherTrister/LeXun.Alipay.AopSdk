using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ValidDateInfo Data Structure.
	/// </summary>
	[Serializable]
	public class ValidDateInfo : AopObject
	{
		/// <summary>
		///     截至时间
		/// </summary>
		[JsonProperty("end_time")]
		public string EndTime { get; set; }

		/// <summary>
		///     相对有效期
		/// </summary>
		[JsonProperty("relative_time")]
		public PeriodInfo RelativeTime { get; set; }

		/// <summary>
		///     开始时间
		/// </summary>
		[JsonProperty("start_time")]
		public string StartTime { get; set; }

		/// <summary>
		///     时间模式,RELATIVE=相对时间，RELATIVE=绝对模式
		/// </summary>
		[JsonProperty("time_mode")]
		public string TimeMode { get; set; }
	}
}