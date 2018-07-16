using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbAdvertContentPassword Data Structure.
	/// </summary>
	[Serializable]
	public class KbAdvertContentPassword : AopObject
	{
		/// <summary>
		///     红包口令
		/// </summary>
		[JsonProperty("password")]
		public string Password { get; set; }

		/// <summary>
		///     红包口令分享地址
		/// </summary>
		[JsonProperty("share_page_url")]
		public string SharePageUrl { get; set; }
	}
}