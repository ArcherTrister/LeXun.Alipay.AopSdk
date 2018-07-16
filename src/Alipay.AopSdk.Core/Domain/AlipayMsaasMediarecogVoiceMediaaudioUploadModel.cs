using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMsaasMediarecogVoiceMediaaudioUploadModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMsaasMediarecogVoiceMediaaudioUploadModel : AopObject
	{
		/// <summary>
		///     base64编码的声音数据
		/// </summary>
		[JsonProperty("data")]
		public string Data { get; set; }

		/// <summary>
		///     扩展字段
		/// </summary>
		[JsonProperty("extinfo_a")]
		public string ExtinfoA { get; set; }

		/// <summary>
		///     扩展字段
		/// </summary>
		[JsonProperty("extinfo_b")]
		public string ExtinfoB { get; set; }

		/// <summary>
		///     扩展字段
		/// </summary>
		[JsonProperty("extinfo_c")]
		public string ExtinfoC { get; set; }

		/// <summary>
		///     扩展字段
		/// </summary>
		[JsonProperty("extinfo_d")]
		public string ExtinfoD { get; set; }

		/// <summary>
		///     时间戳
		/// </summary>
		[JsonProperty("labeltime")]
		public string Labeltime { get; set; }

		/// <summary>
		///     媒体名称
		/// </summary>
		[JsonProperty("vname")]
		public string Vname { get; set; }

		/// <summary>
		///     媒体类型
		/// </summary>
		[JsonProperty("vtype")]
		public string Vtype { get; set; }
	}
}