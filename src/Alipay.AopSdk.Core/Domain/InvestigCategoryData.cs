using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     InvestigCategoryData Data Structure.
	/// </summary>
	[Serializable]
	public class InvestigCategoryData : AopObject
	{
		/// <summary>
		///     数据项
		/// </summary>
		[JsonProperty("category")]
		public string Category { get; set; }

		/// <summary>
		///     采集的数据的版本号。
		/// </summary>
		[JsonProperty("data_version")]
		public string DataVersion { get; set; }

		/// <summary>
		///     实体code
		/// </summary>
		[JsonProperty("entity_code")]
		public string EntityCode { get; set; }

		/// <summary>
		///     实体名
		/// </summary>
		[JsonProperty("entity_name")]
		public string EntityName { get; set; }

		/// <summary>
		///     实体类别
		/// </summary>
		[JsonProperty("entity_type")]
		public string EntityType { get; set; }

		/// <summary>
		///     征信模型结果,以JSON格式输出，包括征信评分creditScore、不准入原因refuseReasons、模型标识码modelIdCode三个字段
		/// </summary>
		[JsonProperty("model_result_object")]
		public string ModelResultObject { get; set; }

		/// <summary>
		///     采集状态
		/// </summary>
		[JsonProperty("state")]
		public string State { get; set; }
	}
}