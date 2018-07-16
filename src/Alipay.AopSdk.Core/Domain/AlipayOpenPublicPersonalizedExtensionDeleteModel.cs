using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicPersonalizedExtensionDeleteModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicPersonalizedExtensionDeleteModel : AopObject
	{
		/// <summary>
		///     一套扩展区的key，删除默认扩展区时传入default ，查询扩展区列表可以获得每套扩展区的key
		/// </summary>
		[JsonProperty("extension_key")]
		public string ExtensionKey { get; set; }
	}
}