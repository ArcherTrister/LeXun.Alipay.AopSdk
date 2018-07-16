using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbAdvertCommissionClausePercentageResponse Data Structure.
	/// </summary>
	[Serializable]
	public class KbAdvertCommissionClausePercentageResponse : AopObject
	{
		/// <summary>
		///     分佣比例(100以内精度2位的非负小数)
		/// </summary>
		[JsonProperty("commission_rate")]
		public string CommissionRate { get; set; }

		/// <summary>
		///     封顶金额(精度2位的非负小数)
		/// </summary>
		[JsonProperty("max_limit")]
		public string MaxLimit { get; set; }
	}
}