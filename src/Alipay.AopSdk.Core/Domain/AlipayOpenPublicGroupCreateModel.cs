using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicGroupCreateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicGroupCreateModel : AopObject
	{
		/// <summary>
		///     标签规则，满足该规则的粉丝将被圈定，标签id不能重复
		/// </summary>
		[JsonProperty("label_rule")]
		
		public List<ComplexLabelRule> LabelRule { get; set; }

		/// <summary>
		///     分组名称，仅支持中文、字母、数字、下划线的组合。
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}