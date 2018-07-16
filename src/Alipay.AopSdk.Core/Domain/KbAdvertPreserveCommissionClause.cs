using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbAdvertPreserveCommissionClause Data Structure.
	/// </summary>
	[Serializable]
	public class KbAdvertPreserveCommissionClause : AopObject
	{
		/// <summary>
		///     user_id：支付宝账户ID(2088开头)  logon_id：登陆账号
		/// </summary>
		[JsonProperty("claimer_id_type")]
		public string ClaimerIdType { get; set; }

		/// <summary>
		///     认领人
		/// </summary>
		[JsonProperty("claimers")]
		
		public List<string> Claimers { get; set; }
	}
}