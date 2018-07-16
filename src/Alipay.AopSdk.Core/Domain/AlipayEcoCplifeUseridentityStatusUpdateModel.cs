using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoCplifeUseridentityStatusUpdateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoCplifeUseridentityStatusUpdateModel : AopObject
	{
		/// <summary>
		///     业务明细
		/// </summary>
		[JsonProperty("biz_details")]
		public string BizDetails { get; set; }

		/// <summary>
		///     当前业务状态
		/// </summary>
		[JsonProperty("biz_state")]
		public string BizState { get; set; }

		/// <summary>
		///     业务单据ID
		/// </summary>
		[JsonProperty("req_id")]
		public string ReqId { get; set; }
	}
}