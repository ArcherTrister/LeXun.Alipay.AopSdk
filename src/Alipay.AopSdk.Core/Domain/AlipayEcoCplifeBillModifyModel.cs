using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoCplifeBillModifyModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoCplifeBillModifyModel : AopObject
	{
		/// <summary>
		///     待修改的物业费账单应收明细条目列表，一次最多修改1000条明细条目。如果明细条目已被支付或在支付中，则无法被修改。接口会返回无法修改的明细条目ID列表。
		/// </summary>
		[JsonProperty("bill_entry_list")]
		
		public List<CPBillModifySet> BillEntryList { get; set; }

		/// <summary>
		///     支付宝社区小区统一编号，必须在物业账号名下存在。
		/// </summary>
		[JsonProperty("community_id")]
		public string CommunityId { get; set; }
	}
}