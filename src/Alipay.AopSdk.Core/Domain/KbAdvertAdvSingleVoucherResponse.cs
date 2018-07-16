using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbAdvertAdvSingleVoucherResponse Data Structure.
	/// </summary>
	[Serializable]
	public class KbAdvertAdvSingleVoucherResponse : AopObject
	{
		/// <summary>
		///     广告内容模型
		/// </summary>
		[JsonProperty("adv_content_list")]
		
		public List<KbAdvertAdvContentResponse> AdvContentList { get; set; }

		/// <summary>
		///     广告内容（广告内容请使用新的属性adv_content_list，此属性仍会保留）
		/// </summary>
		[JsonProperty("content")]
		public KbAdvertAdvContent Content { get; set; }

		/// <summary>
		///     券标的
		/// </summary>
		[JsonProperty("voucher")]
		public KbAdvertSubjectVoucherResponse Voucher { get; set; }
	}
}