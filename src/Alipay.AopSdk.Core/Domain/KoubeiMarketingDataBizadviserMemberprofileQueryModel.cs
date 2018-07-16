using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingDataBizadviserMemberprofileQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingDataBizadviserMemberprofileQueryModel : AopObject
	{
		/// <summary>
		///     会员分层，可传 ALL/4/3/2/1  五个值  传ALL查询所有分层的汇总；  传4查询 流失客层级的；  传3查询 过客层级的；  传2查询 新客层级的；  传1查询 回头客层级的；
		/// </summary>
		[JsonProperty("member_grade")]
		public string MemberGrade { get; set; }
	}
}