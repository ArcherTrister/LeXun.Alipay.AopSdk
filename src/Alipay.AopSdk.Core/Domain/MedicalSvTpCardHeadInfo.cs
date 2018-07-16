using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     MedicalSvTpCardHeadInfo Data Structure.
	/// </summary>
	[Serializable]
	public class MedicalSvTpCardHeadInfo : AopObject
	{
		/// <summary>
		///     模板头部图标：开发者提供公网图片地址  图片大小（长*宽,单位px）81*81
		/// </summary>
		[JsonProperty("header_icon")]
		public string HeaderIcon { get; set; }

		/// <summary>
		///     模板头部标题,开发者自定义
		/// </summary>
		[JsonProperty("header_title")]
		public string HeaderTitle { get; set; }
	}
}