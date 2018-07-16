using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ShopCategoryConfigInfo Data Structure.
	/// </summary>
	[Serializable]
	public class ShopCategoryConfigInfo : AopObject
	{
		/// <summary>
		///     类目ID
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		///     是否是叶子节点
		/// </summary>
		[JsonProperty("is_leaf")]
		public string IsLeaf { get; set; }

		/// <summary>
		///     类目层级
		/// </summary>
		[JsonProperty("level")]
		public string Level { get; set; }

		/// <summary>
		///     类目层级路径
		/// </summary>
		[JsonProperty("link")]
		public string Link { get; set; }

		/// <summary>
		///     类目名称
		/// </summary>
		[JsonProperty("nm")]
		public string Nm { get; set; }
	}
}