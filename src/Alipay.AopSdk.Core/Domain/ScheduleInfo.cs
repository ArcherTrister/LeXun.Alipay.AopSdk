using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ScheduleInfo Data Structure.
	/// </summary>
	[Serializable]
	public class ScheduleInfo : AopObject
	{
		/// <summary>
		///     根据定义的间隔长度跟单位，将date的时间切分，例如将2016-11-29整天按30分钟为一段切分为48段： 111111111111111111111111111111111110000011111111 ，
		///     其中0表示不可用，1表示可用
		/// </summary>
		[JsonProperty("bitmap")]
		public string Bitmap { get; set; }

		/// <summary>
		///     时间，默认YYYY-MM-DD格式，如果是单位是月，就填写YYYY-01-01格式，如果单位是周和日，就是YYYY-MM-01格式
		/// </summary>
		[JsonProperty("date")]
		public string Date { get; set; }
	}
}