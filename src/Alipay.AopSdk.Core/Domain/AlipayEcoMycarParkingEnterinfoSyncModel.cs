using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoMycarParkingEnterinfoSyncModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoMycarParkingEnterinfoSyncModel : AopObject
	{
		/// <summary>
		///     车牌号
		/// </summary>
		[JsonProperty("car_number")]
		public string CarNumber { get; set; }

		/// <summary>
		///     车辆入场的时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制
		/// </summary>
		[JsonProperty("in_time")]
		public string InTime { get; set; }

		/// <summary>
		///     支付宝停车场ID ，系统唯一
		/// </summary>
		[JsonProperty("parking_id")]
		public string ParkingId { get; set; }
	}
}