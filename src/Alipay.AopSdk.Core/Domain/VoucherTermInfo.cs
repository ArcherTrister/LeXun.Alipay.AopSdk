using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     VoucherTermInfo Data Structure.
	/// </summary>
	[Serializable]
	public class VoucherTermInfo : AopObject
	{
		/// <summary>
		///     描述信息
		/// </summary>
		[JsonProperty("descriptions")]
		
		public List<string> Descriptions { get; set; }

		/// <summary>
		///     详情title
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }
	}
}