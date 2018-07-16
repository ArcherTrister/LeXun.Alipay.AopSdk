using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayCodeRecoResult Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayCodeRecoResult : AopObject
	{
		/// <summary>
		///     识别的验证码内容
		/// </summary>
		[JsonProperty("content")]
		public string Content { get; set; }
	}
}