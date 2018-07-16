using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     Video Data Structure.
	/// </summary>
	[Serializable]
	public class Video : AopObject
	{
		/// <summary>
		///     调用alipay.offline.material.image.upload接口将视频上传到素材中心后，生成的ID
		/// </summary>
		[JsonProperty("location")]
		public string Location { get; set; }

		/// <summary>
		///     视频名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}