using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiCateringTablecodeQueryResponse.
	/// </summary>
	public class KoubeiCateringTablecodeQueryResponse : AopResponse
	{
		/// <summary>
		///     返回值为shop_code表示只返回了门店码 返回值为table_code表示返回了桌码跟门店码
		/// </summary>
		[JsonProperty("code_flag")]
		public string CodeFlag { get; set; }

		/// <summary>
		///     门店id
		/// </summary>
		[JsonProperty("shop_id")]
		public string ShopId { get; set; }

		/// <summary>
		///     桌码
		/// </summary>
		[JsonProperty("table_num")]
		public string TableNum { get; set; }
	}
}