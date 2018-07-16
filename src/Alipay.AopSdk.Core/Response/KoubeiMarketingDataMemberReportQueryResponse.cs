using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingDataMemberReportQueryResponse.
	/// </summary>
	public class KoubeiMarketingDataMemberReportQueryResponse : AopResponse
	{
		/// <summary>
		///     查询成功时返回json格式数据
		/// </summary>
		[JsonProperty("report_data")]
		public string ReportData { get; set; }
	}
}