using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     GroupMemberInfo Data Structure.
	/// </summary>
	[Serializable]
	public class GroupMemberInfo : AopObject
	{
		/// <summary>
		///     用户在这个群里的昵称
		/// </summary>
		[JsonProperty("group_nickname")]
		public string GroupNickname { get; set; }

		/// <summary>
		///     个人昵称
		/// </summary>
		[JsonProperty("nickname")]
		public string Nickname { get; set; }

		/// <summary>
		///     用户的uid
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}