using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbAdvertMissionQueryResponse Data Structure.
	/// </summary>
	[Serializable]
	public class KbAdvertMissionQueryResponse : AopObject
	{
		/// <summary>
		///     任务结束时间
		/// </summary>
		[JsonProperty("gmt_end")]
		public string GmtEnd { get; set; }

		/// <summary>
		///     任务开始时间
		/// </summary>
		[JsonProperty("gmt_start")]
		public string GmtStart { get; set; }

		/// <summary>
		///     分佣任务ID
		/// </summary>
		[JsonProperty("mission_id")]
		public string MissionId { get; set; }

		/// <summary>
		///     推广状态  EFFECTIVE-有效  INVALID-无效
		/// </summary>
		[JsonProperty("promote_status")]
		public string PromoteStatus { get; set; }

		/// <summary>
		///     分佣标的信息
		/// </summary>
		[JsonProperty("subjects")]
		
		public List<KbAdvertMissionSubject> Subjects { get; set; }
	}
}