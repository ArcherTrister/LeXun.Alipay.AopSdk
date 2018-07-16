using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoMycarParkingCardidQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoMycarParkingCardidQueryModel : AopObject
	{
		/// <summary>
		///     如果商户订单号为空，停车场id和车牌号不能为空，商户订单号优先查询
		/// </summary>
		[JsonProperty("car_number")]
		public string CarNumber { get; set; }

		/// <summary>
		///     用户支付成功而设备商状态没一起同步过来，手动执行查询
		/// </summary>
		[JsonProperty("parking_id")]
		public string ParkingId { get; set; }

		/// <summary>
		///     查询订单时间（不传值为当日时间），格式"yyyy-MM-dd"
		/// </summary>
		[JsonProperty("sel_time")]
		public string SelTime { get; set; }

		/// <summary>
		///     车主平台交易号，不能跟停车场编号和车牌号同时为空
		/// </summary>
		[JsonProperty("transaction_no")]
		public string TransactionNo { get; set; }
	}
}