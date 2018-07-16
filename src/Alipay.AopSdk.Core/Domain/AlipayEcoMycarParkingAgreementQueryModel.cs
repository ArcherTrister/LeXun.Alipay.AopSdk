using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoMycarParkingAgreementQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoMycarParkingAgreementQueryModel : AopObject
	{
		/// <summary>
		///     车牌，用户车辆进场时ISV设备识别到的车辆牌照
		/// </summary>
		[JsonProperty("car_number")]
		public string CarNumber { get; set; }
	}
}