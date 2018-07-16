using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCashvoucherTemplateModifyResponse.
	/// </summary>
	public class AlipayMarketingCashvoucherTemplateModifyResponse : AopResponse
	{
		/// <summary>
		///     模板修改时的状态，I表示草稿状态所有入参都修改了，S表示生效状态仅修改了publish_end_time
		/// </summary>
		[JsonProperty("status")]
		public string Status { get; set; }
	}
}