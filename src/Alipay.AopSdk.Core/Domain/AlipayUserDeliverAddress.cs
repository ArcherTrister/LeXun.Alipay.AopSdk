using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayUserDeliverAddress Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayUserDeliverAddress : AopObject
	{
		/// <summary>
		///     地址
		/// </summary>
		[JsonProperty("address")]
		public string Address { get; set; }

		/// <summary>
		///     区域编码
		/// </summary>
		[JsonProperty("address_code")]
		public string AddressCode { get; set; }

		/// <summary>
		///     是否默认收货地址
		/// </summary>
		[JsonProperty("default_deliver_address")]
		public string DefaultDeliverAddress { get; set; }

		/// <summary>
		///     区/县
		/// </summary>
		[JsonProperty("deliver_area")]
		public string DeliverArea { get; set; }

		/// <summary>
		///     市
		/// </summary>
		[JsonProperty("deliver_city")]
		public string DeliverCity { get; set; }

		/// <summary>
		///     收货人全名
		/// </summary>
		[JsonProperty("deliver_fullname")]
		public string DeliverFullname { get; set; }

		/// <summary>
		///     收货地址的联系人移动电话
		/// </summary>
		[JsonProperty("deliver_mobile")]
		public string DeliverMobile { get; set; }

		/// <summary>
		///     收货地址的联系人固定电话
		/// </summary>
		[JsonProperty("deliver_phone")]
		public string DeliverPhone { get; set; }

		/// <summary>
		///     省
		/// </summary>
		[JsonProperty("deliver_province")]
		public string DeliverProvince { get; set; }

		/// <summary>
		///     邮编
		/// </summary>
		[JsonProperty("zip")]
		public string Zip { get; set; }
	}
}