using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoCplifeResidentinfoUploadModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoCplifeResidentinfoUploadModel : AopObject
	{
		/// <summary>
		///     请求流水号，由商户自定义，在商户系统内唯一标示一次业务请求。
		/// </summary>
		[JsonProperty("batch_id")]
		public string BatchId { get; set; }

		/// <summary>
		///     业主所在物业小区ID(支付宝平台唯一小区ID标示)
		/// </summary>
		[JsonProperty("community_id")]
		public string CommunityId { get; set; }

		/// <summary>
		///     请求上传的住户信息列表，单次至多上传200条住户信息.
		/// </summary>
		[JsonProperty("resident_info")]
		
		public List<CplifeResidentInfo> ResidentInfo { get; set; }
	}
}