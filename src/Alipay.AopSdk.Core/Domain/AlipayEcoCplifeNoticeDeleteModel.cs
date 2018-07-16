using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoCplifeNoticeDeleteModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoCplifeNoticeDeleteModel : AopObject
	{
		/// <summary>
		///     待删除通知的支付宝小区ID，如果为空，则在所有小区下线该通知.
		/// </summary>
		[JsonProperty("community_id_set")]
		
		public List<string> CommunityIdSet { get; set; }

		/// <summary>
		///     待删除的通知ID,(见alipay.eco.cplife.notice.publish接口返回参数列表.)
		/// </summary>
		[JsonProperty("notice_id")]
		public string NoticeId { get; set; }
	}
}