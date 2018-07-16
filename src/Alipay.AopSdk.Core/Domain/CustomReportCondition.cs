using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     CustomReportCondition Data Structure.
	/// </summary>
	[Serializable]
	public class CustomReportCondition : AopObject
	{
		/// <summary>
		///     规则KEY-为空则为创建规则，否则更新规则
		/// </summary>
		[JsonProperty("condition_key")]
		public string ConditionKey { get; set; }

		/// <summary>
		///     明细数据标签
		/// </summary>
		[JsonProperty("data_tags")]
		
		public List<DataTag> DataTags { get; set; }

		/// <summary>
		///     分组过滤条件
		/// </summary>
		[JsonProperty("filter_tags")]
		
		public List<FilterTag> FilterTags { get; set; }

		/// <summary>
		///     分组数据标签集合
		///     注意：这个是JSON数组，必须以[开头，以]结尾，[]外层不能加双引号"",正确案例["orpt_ubase_age","orpt_ubase_birthday_mm"]，错误案例："["orpt_ubase_age","orpt_ubase_birthday_mm"]"
		/// </summary>
		[JsonProperty("group_tags")]
		public string GroupTags { get; set; }

		/// <summary>
		///     规则描述
		/// </summary>
		[JsonProperty("memo")]
		public string Memo { get; set; }

		/// <summary>
		///     自定义报表名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     排序数据标签集合
		///     注意：这个是JSON数组，必须以[开头，以]结尾，[]外层不能加双引号"",正确案例[{"code":"orpt_ubase_age","sortBy":"DESC"}]，错误案例："[{"code":"orpt_ubase_age","sortBy":"DESC"}]"
		/// </summary>
		[JsonProperty("sort_tags")]
		public string SortTags { get; set; }
	}
}