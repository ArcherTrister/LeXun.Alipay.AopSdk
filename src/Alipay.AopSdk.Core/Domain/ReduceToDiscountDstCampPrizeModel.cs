using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ReduceToDiscountDstCampPrizeModel Data Structure.
	/// </summary>
	[Serializable]
	public class ReduceToDiscountDstCampPrizeModel : AopObject
	{
		/// <summary>
		///     折扣预算ID
		/// </summary>
		[JsonProperty("budget_id")]
		public string BudgetId { get; set; }

		/// <summary>
		///     奖品id
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		///     单次优惠上限(元)
		/// </summary>
		[JsonProperty("max_discount_amt")]
		public string MaxDiscountAmt { get; set; }

		/// <summary>
		///     折扣幅度减至必须为0.3到1之间的小数(保留小数点后2位)
		/// </summary>
		[JsonProperty("reduce_to_discount_rate")]
		public string ReduceToDiscountRate { get; set; }
	}
}