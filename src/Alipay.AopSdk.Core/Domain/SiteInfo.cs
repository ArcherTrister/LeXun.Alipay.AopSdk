using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     SiteInfo Data Structure.
	/// </summary>
	[Serializable]
	public class SiteInfo : AopObject
	{
		/// <summary>
		///     测试账号
		/// </summary>
		[JsonProperty("account")]
		public string Account { get; set; }

		/// <summary>
		///     测试密码
		/// </summary>
		[JsonProperty("password")]
		public string Password { get; set; }

		/// <summary>
		///     站点名称
		/// </summary>
		[JsonProperty("site_name")]
		public string SiteName { get; set; }

		/// <summary>
		///     网站：01  APP  : 02  服务窗:03  公众号:04  其他:05
		/// </summary>
		[JsonProperty("site_type")]
		public string SiteType { get; set; }

		/// <summary>
		///     站点地址
		/// </summary>
		[JsonProperty("site_url")]
		public string SiteUrl { get; set; }
	}
}