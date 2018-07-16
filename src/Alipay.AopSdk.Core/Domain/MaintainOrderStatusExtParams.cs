using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     MaintainOrderStatusExtParams Data Structure.
	/// </summary>
	[Serializable]
	public class MaintainOrderStatusExtParams : AopObject
	{
		/// <summary>
		///     编码
		/// </summary>
		[JsonProperty("logistics_code")]
		public string LogisticsCode { get; set; }

		/// <summary>
		///     快递发货商
		/// </summary>
		[JsonProperty("logistics_company")]
		public string LogisticsCompany { get; set; }

		/// <summary>
		///     快递单号
		/// </summary>
		[JsonProperty("logistics_no")]
		public string LogisticsNo { get; set; }

		/// <summary>
		///     4S订单状态
		/// </summary>
		[JsonProperty("order_status_txt")]
		public string OrderStatusTxt { get; set; }

		/// <summary>
		///     收货地址
		/// </summary>
		[JsonProperty("receiver_addr")]
		public string ReceiverAddr { get; set; }

		/// <summary>
		///     发货地址
		/// </summary>
		[JsonProperty("sender_addr")]
		public string SenderAddr { get; set; }
	}
}