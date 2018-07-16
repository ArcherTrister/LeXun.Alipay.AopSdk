using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipaySocialBaseChatGroupCreateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipaySocialBaseChatGroupCreateModel : AopObject
	{
		/// <summary>
		///     请求唯一id（用户id+时间戳+随机数），防止重复建群
		/// </summary>
		[JsonProperty("client_id")]
		public string ClientId { get; set; }

		/// <summary>
		///     群名称
		/// </summary>
		[JsonProperty("group_name")]
		public string GroupName { get; set; }
	}
}