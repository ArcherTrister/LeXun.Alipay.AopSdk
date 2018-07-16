using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     GradeDiscountPoint Data Structure.
	/// </summary>
	[Serializable]
	public class GradeDiscountPoint : AopObject
	{
		/// <summary>
		///     蚂蚁会员权益配置的ID
		/// </summary>
		[JsonProperty("benefit_id")]
		public long BenefitId { get; set; }

		/// <summary>
		///     各个等级的等级折扣后的积分
		/// </summary>
		[JsonProperty("discount_point")]
		public string DiscountPoint { get; set; }

		/// <summary>
		///     蚂蚁会员等级
		/// </summary>
		[JsonProperty("grade")]
		public string Grade { get; set; }
	}
}