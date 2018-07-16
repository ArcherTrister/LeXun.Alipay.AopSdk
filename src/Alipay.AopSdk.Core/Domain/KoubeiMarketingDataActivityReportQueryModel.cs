using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingDataActivityReportQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingDataActivityReportQueryModel : AopObject
	{
		/// <summary>
		///     查询报表数据的业务日期列表，精确到天，格式为yyyymmdd，支持列表格式，数据按天返回
		/// </summary>
		[JsonProperty("biz_date")]
		public string BizDate { get; set; }

		/// <summary>
		///     活动id
		/// </summary>
		[JsonProperty("camp_id")]
		public string CampId { get; set; }
	}
}