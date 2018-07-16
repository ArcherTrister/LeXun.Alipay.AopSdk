using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     NewsfeedMediaVideoInfo Data Structure.
	/// </summary>
	[Serializable]
	public class NewsfeedMediaVideoInfo : AopObject
	{
		/// <summary>
		///     高度
		/// </summary>
		[JsonProperty("height")]
		public string Height { get; set; }

		/// <summary>
		///     视频缩略图的ID（支持djangoId）
		/// </summary>
		[JsonProperty("img_id")]
		public string ImgId { get; set; }

		/// <summary>
		///     视频的id（支持djangoId）
		/// </summary>
		[JsonProperty("video_id")]
		public string VideoId { get; set; }

		/// <summary>
		///     宽度
		/// </summary>
		[JsonProperty("width")]
		public string Width { get; set; }
	}
}