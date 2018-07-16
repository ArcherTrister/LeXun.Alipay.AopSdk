using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     OldComplextMockModel Data Structure.
	/// </summary>
	[Serializable]
	public class OldComplextMockModel : AopObject
	{
		/// <summary>
		///     biz_num
		/// </summary>
		[JsonProperty("biz_num")]
		public long BizNum { get; set; }

		/// <summary>
		///     biz_type
		/// </summary>
		[JsonProperty("biz_type")]
		public string BizType { get; set; }

		/// <summary>
		///     简单model
		/// </summary>
		[JsonProperty("simple_mock_model")]
		public SimpleMockModel SimpleMockModel { get; set; }
	}
}