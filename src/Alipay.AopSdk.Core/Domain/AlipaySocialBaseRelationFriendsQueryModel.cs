using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipaySocialBaseRelationFriendsQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipaySocialBaseRelationFriendsQueryModel : AopObject
	{
		/// <summary>
		///     获取类型。1=获取双向好友   2=获取双向+单向好友
		/// </summary>
		[JsonProperty("get_type")]
		public long GetType { get; set; }

		/// <summary>
		///     好友列表中是否返回自己， true=返回   false=不返回    默认false
		/// </summary>
		[JsonProperty("include_self")]
		public bool IncludeSelf { get; set; }
	}
}