using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ExtCategory Data Structure.
	/// </summary>
	[Serializable]
	public class ExtCategory : AopObject
	{
		/// <summary>
		///     品类编码
		/// </summary>
		[JsonProperty("category_code")]
		public string CategoryCode { get; set; }

		/// <summary>
		///     品类名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     父品类编码。顶级类目此值为0
		/// </summary>
		[JsonProperty("parent_id")]
		public string ParentId { get; set; }
	}
}