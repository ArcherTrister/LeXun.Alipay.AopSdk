using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbAdvertAddChannelRequest Data Structure.
	/// </summary>
	[Serializable]
	public class KbAdvertAddChannelRequest : AopObject
	{
		/// <summary>
		///     描述信息(页面上不展现)
		/// </summary>
		[JsonProperty("memo")]
		public string Memo { get; set; }

		/// <summary>
		///     渠道名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     类型可以通过koubei.advert.data.conf.query查询  OFFLINE：线下推广
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }
	}
}