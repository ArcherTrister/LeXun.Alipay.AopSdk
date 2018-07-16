using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingDataCustomreportSaveModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingDataCustomreportSaveModel : AopObject
	{
		/// <summary>
		///     自定义报表规则条件信息
		/// </summary>
		[JsonProperty("report_condition_info")]
		public CustomReportCondition ReportConditionInfo { get; set; }
	}
}