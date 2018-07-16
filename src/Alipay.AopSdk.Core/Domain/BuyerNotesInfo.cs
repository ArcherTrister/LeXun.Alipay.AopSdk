using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     BuyerNotesInfo Data Structure.
	/// </summary>
	[Serializable]
	public class BuyerNotesInfo : AopObject
	{
		/// <summary>
		///     标题下的描述列表，列表类型，每项不得为空,最多10项，总长度不能超过2600个中文字符
		/// </summary>
		[JsonProperty("details")]
		
		public List<string> Details { get; set; }

		/// <summary>
		///     描述标题，不得超过15个中文字符
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }
	}
}