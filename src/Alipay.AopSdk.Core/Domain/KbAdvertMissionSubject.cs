using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbAdvertMissionSubject Data Structure.
	/// </summary>
	[Serializable]
	public class KbAdvertMissionSubject : AopObject
	{
		/// <summary>
		///     分佣条款信息
		/// </summary>
		[JsonProperty("commission_clause_list")]
		
		public List<KbAdvertCommissionClause> CommissionClauseList { get; set; }

		/// <summary>
		///     标的对象的业务ID，如果标的为商品，则subject_biz_id为商品ID
		/// </summary>
		[JsonProperty("subject_biz_id")]
		public string SubjectBizId { get; set; }

		/// <summary>
		///     标的类型  voucher-券
		/// </summary>
		[JsonProperty("subject_type")]
		public string SubjectType { get; set; }
	}
}