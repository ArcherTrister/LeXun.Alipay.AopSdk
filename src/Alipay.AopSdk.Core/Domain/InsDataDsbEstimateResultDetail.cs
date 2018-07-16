using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     InsDataDsbEstimateResultDetail Data Structure.
	/// </summary>
	[Serializable]
	public class InsDataDsbEstimateResultDetail : AopObject
	{
		/// <summary>
		///     受损程度
		/// </summary>
		[JsonProperty("damage_degree")]
		public string DamageDegree { get; set; }

		/// <summary>
		///     受损程度中文描述
		/// </summary>
		[JsonProperty("damage_degree_desc")]
		public string DamageDegreeDesc { get; set; }

		/// <summary>
		///     受损类型
		/// </summary>
		[JsonProperty("damage_type")]
		public string DamageType { get; set; }

		/// <summary>
		///     受损类型中文描述
		/// </summary>
		[JsonProperty("damage_type_desc")]
		public string DamageTypeDesc { get; set; }

		/// <summary>
		///     工时项目代码
		/// </summary>
		[JsonProperty("hourly_code")]
		public string HourlyCode { get; set; }

		/// <summary>
		///     工时费
		/// </summary>
		[JsonProperty("hourly_wage")]
		public string HourlyWage { get; set; }

		/// <summary>
		///     配件OE码
		/// </summary>
		[JsonProperty("oe_code")]
		public string OeCode { get; set; }

		/// <summary>
		///     是否旧件回收，true或false
		/// </summary>
		[JsonProperty("old_recycle")]
		public bool OldRecycle { get; set; }

		/// <summary>
		///     配件费用
		/// </summary>
		[JsonProperty("parts_cost")]
		public string PartsCost { get; set; }

		/// <summary>
		///     零件管理费，单位：元
		/// </summary>
		[JsonProperty("parts_manage_fee")]
		public string PartsManageFee { get; set; }

		/// <summary>
		///     配件名称
		/// </summary>
		[JsonProperty("parts_name")]
		public string PartsName { get; set; }

		/// <summary>
		///     残值扣除，单位：元
		/// </summary>
		[JsonProperty("remain_value")]
		public string RemainValue { get; set; }

		/// <summary>
		///     维修方案
		/// </summary>
		[JsonProperty("repair_type")]
		public string RepairType { get; set; }

		/// <summary>
		///     维修方案中文描述
		/// </summary>
		[JsonProperty("repair_type_desc")]
		public string RepairTypeDesc { get; set; }
	}
}