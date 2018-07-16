using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     GroupSetting Data Structure.
	/// </summary>
	[Serializable]
	public class GroupSetting : AopObject
	{
		/// <summary>
		///     群名称
		/// </summary>
		[JsonProperty("group_name")]
		public string GroupName { get; set; }

		/// <summary>
		///     是否开放群成员邀请
		/// </summary>
		[JsonProperty("is_openinv")]
		public bool IsOpeninv { get; set; }

		/// <summary>
		///     群公告
		/// </summary>
		[JsonProperty("public_notice")]
		public string PublicNotice { get; set; }
	}
}