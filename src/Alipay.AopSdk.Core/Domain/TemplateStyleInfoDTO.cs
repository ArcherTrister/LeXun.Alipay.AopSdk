using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     TemplateStyleInfoDTO Data Structure.
	/// </summary>
	[Serializable]
	public class TemplateStyleInfoDTO : AopObject
	{
		/// <summary>
		///     背景图片Id，通过接口（alipay.offline.material.image.upload）上传图片    图片说明：2M以内，格式：bmp、png、jpeg、jpg、gif；  尺寸不小于1020*643px；
		///     图片不得有圆角，不得拉伸变形
		/// </summary>
		[JsonProperty("background_id")]
		public string BackgroundId { get; set; }

		/// <summary>
		///     背景色
		/// </summary>
		[JsonProperty("bg_color")]
		public string BgColor { get; set; }

		/// <summary>
		///     品牌商名称
		/// </summary>
		[JsonProperty("brand_name")]
		public string BrandName { get; set; }

		/// <summary>
		///     钱包端显示名称（字符串长度）
		/// </summary>
		[JsonProperty("card_show_name")]
		public string CardShowName { get; set; }

		/// <summary>
		///     注意：此字段已废弃。  卡片颜色
		/// </summary>
		[JsonProperty("color")]
		public string Color { get; set; }

		/// <summary>
		///     特色信息，用于领卡预览
		/// </summary>
		[JsonProperty("feature_descriptions")]
		
		public List<string> FeatureDescriptions { get; set; }

		/// <summary>
		///     设置是否在卡面展示（个人头像）图片信息，默认不展示；  当前仅用于身份验证信息类型的个人头像图片；  图片id随创建卡/更新卡时传入；  详见会员卡产品文档。
		/// </summary>
		[JsonProperty("front_image_enable")]
		public bool FrontImageEnable { get; set; }

		/// <summary>
		///     设置是否在卡面展示文案信息，默认不展示；  文案信息分行展示，最多展示3行文案，每行文案分为label和value两部分；  文案实际内容随创建卡/更新卡时传入；  详见会员卡产品说明文档。
		/// </summary>
		[JsonProperty("front_text_list_enable")]
		public bool FrontTextListEnable { get; set; }

		/// <summary>
		///     logo的图片ID，通过接口（alipay.offline.material.image.upload）上传图片    图片说明：1M以内，格式bmp、png、jpeg、jpg、gif；  尺寸不小于500*500px的正方形；
		///     请优先使用商家LOGO；
		/// </summary>
		[JsonProperty("logo_id")]
		public string LogoId { get; set; }

		/// <summary>
		///     标语
		/// </summary>
		[JsonProperty("slogan")]
		public string Slogan { get; set; }

		/// <summary>
		///     标语图片， 通过接口（alipay.offline.material.image.upload）上传图片
		/// </summary>
		[JsonProperty("slogan_img_id")]
		public string SloganImgId { get; set; }
	}
}