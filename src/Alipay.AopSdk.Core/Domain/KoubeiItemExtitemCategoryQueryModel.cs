using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiItemExtitemCategoryQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiItemExtitemCategoryQueryModel : AopObject
	{
		/// <summary>
		///     父品类编码. (查询顶级类目时值传0)
		/// </summary>
		[JsonProperty("parent_id")]
		public string ParentId { get; set; }
	}
}