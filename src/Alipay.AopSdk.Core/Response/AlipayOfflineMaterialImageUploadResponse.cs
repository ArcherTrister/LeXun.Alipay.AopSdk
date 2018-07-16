using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOfflineMaterialImageUploadResponse.
	/// </summary>
	public class AlipayOfflineMaterialImageUploadResponse : AopResponse
	{
		/// <summary>
		///     图片/视频在商家中心的唯一标识
		/// </summary>
		[JsonProperty("image_id")]
		public string ImageId { get; set; }

		/// <summary>
		///     图片/视频的访问地址（为了防止盗链，该地址不允许嵌在其他页面展示，只能在新页面展示）
		/// </summary>
		[JsonProperty("image_url")]
		public string ImageUrl { get; set; }
	}
}