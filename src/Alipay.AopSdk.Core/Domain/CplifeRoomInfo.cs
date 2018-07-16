using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     CplifeRoomInfo Data Structure.
	/// </summary>
	[Serializable]
	public class CplifeRoomInfo : AopObject
	{
		/// <summary>
		///     房间的完整门牌地址
		/// </summary>
		[JsonProperty("address")]
		public string Address { get; set; }

		/// <summary>
		///     房屋所在楼栋名称。例如“1栋”，“1幢”等
		/// </summary>
		[JsonProperty("building")]
		public string Building { get; set; }

		/// <summary>
		///     房屋所在的组团名称。例如“一期”，“东区”，“香桂苑”等
		/// </summary>
		[JsonProperty("group")]
		public string Group { get; set; }

		/// <summary>
		///     商户系统小区房屋唯一ID标示.
		/// </summary>
		[JsonProperty("out_room_id")]
		public string OutRoomId { get; set; }

		/// <summary>
		///     房屋所在房号。例如“1101室”，“11B室”等
		/// </summary>
		[JsonProperty("room")]
		public string Room { get; set; }

		/// <summary>
		///     房屋所在单元名称。例如“一单元”，“二单元”等
		/// </summary>
		[JsonProperty("unit")]
		public string Unit { get; set; }
	}
}