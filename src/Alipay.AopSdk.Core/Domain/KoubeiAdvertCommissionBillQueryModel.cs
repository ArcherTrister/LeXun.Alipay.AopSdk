using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiAdvertCommissionBillQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiAdvertCommissionBillQueryModel : AopObject
	{
		/// <summary>
		///     账期(格式为yyyyMM)
		/// </summary>
		[JsonProperty("date")]
		public string Date { get; set; }

		/// <summary>
		///     账单类型  deal-交易账单  settle-结算账单
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }
	}
}