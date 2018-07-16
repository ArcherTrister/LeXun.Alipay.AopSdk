using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     OpenPromoBudget Data Structure.
	/// </summary>
	[Serializable]
	public class OpenPromoBudget : AopObject
	{
		/// <summary>
		///     预算数量，支持1～999999999之间。默认为999999999
		/// </summary>
		[JsonProperty("budget_total")]
		public string BudgetTotal { get; set; }

		/// <summary>
		///     预算类型，现在支持CAMP_BUDGET_AMOUNT：表示数量预算
		/// </summary>
		[JsonProperty("budget_type")]
		public string BudgetType { get; set; }
	}
}