using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipaySocialBaseChatGinfoQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipaySocialBaseChatGinfoQueryModel : AopObject
	{
		/// <summary>
		///     群id
		/// </summary>
		[JsonProperty("group_id")]
		public string GroupId { get; set; }
	}
}