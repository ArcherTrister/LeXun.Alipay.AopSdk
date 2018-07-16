using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicShortlinkCreateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicShortlinkCreateModel : AopObject
	{
		/// <summary>
		///     对于场景ID的描述，商户自己定义
		/// </summary>
		[JsonProperty("remark")]
		public string Remark { get; set; }

		/// <summary>
		///     短链接对应的场景ID，该ID由商户自己定义
		/// </summary>
		[JsonProperty("scene_id")]
		public string SceneId { get; set; }
	}
}