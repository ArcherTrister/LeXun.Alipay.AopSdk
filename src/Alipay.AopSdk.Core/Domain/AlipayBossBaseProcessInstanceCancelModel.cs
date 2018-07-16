using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayBossBaseProcessInstanceCancelModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayBossBaseProcessInstanceCancelModel : AopObject
	{
		/// <summary>
		///     备注
		/// </summary>
		[JsonProperty("memo")]
		public string Memo { get; set; }

		/// <summary>
		///     处理人域账号
		/// </summary>
		[JsonProperty("operator")]
		public string Operator { get; set; }

		/// <summary>
		///     流程全局唯一ID
		/// </summary>
		[JsonProperty("puid")]
		public string Puid { get; set; }
	}
}