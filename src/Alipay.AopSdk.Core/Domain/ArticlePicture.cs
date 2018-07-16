using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ArticlePicture Data Structure.
	/// </summary>
	[Serializable]
	public class ArticlePicture : AopObject
	{
		/// <summary>
		///     图片的描述
		/// </summary>
		[JsonProperty("desc")]
		public string Desc { get; set; }

		/// <summary>
		///     图片上传到素材中心后生成的id
		/// </summary>
		[JsonProperty("location")]
		public string Location { get; set; }

		/// <summary>
		///     图片名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     "DISH"："菜品"，"ENVIRONMENT"："环境"，"SHOPHEAD"："门头照"，"OTHER"："其他"
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }
	}
}