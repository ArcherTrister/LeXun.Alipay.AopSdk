using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayYebLqdDataResult Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayYebLqdDataResult : AopObject
	{
		/// <summary>
		///     申购预测，单位:元
		/// </summary>
		[JsonProperty("predict_purchase_amt")]
		public string PredictPurchaseAmt { get; set; }

		/// <summary>
		///     赎回预测,单位:元
		/// </summary>
		[JsonProperty("predict_redeem_amt")]
		public string PredictRedeemAmt { get; set; }

		/// <summary>
		///     预测日期，格式为yyyymmdd
		/// </summary>
		[JsonProperty("target_date")]
		public string TargetDate { get; set; }
	}
}