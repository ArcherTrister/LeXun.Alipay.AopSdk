using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayDataDataserviceBillDownloadurlQueryResponse.
	/// </summary>
	public class AlipayDataDataserviceBillDownloadurlQueryResponse : AopResponse
	{
		/// <summary>
		///     账单下载地址链接，获取连接后30秒后未下载，链接地址失效。
		/// </summary>
		[JsonProperty("bill_download_url")]
		public string BillDownloadUrl { get; set; }
	}
}