using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiItemStateResponse.
	/// </summary>
	public class KoubeiItemStateResponse : AopResponse
	{
		/// <summary>
		///     口碑体系内部商品的唯一标识
		/// </summary>
		[JsonProperty("item_id")]
		public string ItemId { get; set; }

		/// <summary>
		///     即入参中的request_id
		/// </summary>
		[JsonProperty("request_id")]
		public string RequestId { get; set; }
	}
}