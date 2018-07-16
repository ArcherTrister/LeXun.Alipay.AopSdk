using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     PointCard Data Structure.
	/// </summary>
	[Serializable]
	public class PointCard : AopObject
	{
		/// <summary>
		///     工具的描述
		/// </summary>
		[JsonProperty("desc")]
		public string Desc { get; set; }

		/// <summary>
		///     工具的有效期的结束时间（必须晚于活动的结束时间）
		/// </summary>
		[JsonProperty("end_time")]
		public string EndTime { get; set; }

		/// <summary>
		///     工具的LOGO文件ID
		/// </summary>
		[JsonProperty("logo")]
		public string Logo { get; set; }

		/// <summary>
		///     工具的名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     工具的有效期的起始时间
		/// </summary>
		[JsonProperty("start_time")]
		public string StartTime { get; set; }

		/// <summary>
		///     工具类型，目前支持：  集点卡：POINT_CARD
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }
	}
}