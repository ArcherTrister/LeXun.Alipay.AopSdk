using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     RoyaltyInfo Data Structure.
	/// </summary>
	[Serializable]
	public class RoyaltyInfo : AopObject
	{
		/// <summary>
		///     分账明细的信息，可以描述多条分账指令，json数组。
		/// </summary>
		[JsonProperty("royalty_detail_infos")]
		
		public List<RoyaltyDetailInfos> RoyaltyDetailInfos { get; set; }

		/// <summary>
		///     分账类型  卖家的分账类型，目前只支持传入ROYALTY（普通分账类型）。
		/// </summary>
		[JsonProperty("royalty_type")]
		public string RoyaltyType { get; set; }
	}
}