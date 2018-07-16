using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayDataItemDescription Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayDataItemDescription : AopObject
	{
		/// <summary>
		///     标题下的描述列表
		/// </summary>
		[JsonProperty("details")]
		
		public List<string> Details { get; set; }

		/// <summary>
		///     明细图片列表
		/// </summary>
		[JsonProperty("images")]
		
		public List<string> Images { get; set; }

		/// <summary>
		///     描述标题，不得超过15个中文字符
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		///     套餐使用说明链接，必须是https的地址链接
		/// </summary>
		[JsonProperty("url")]
		public string Url { get; set; }
	}
}