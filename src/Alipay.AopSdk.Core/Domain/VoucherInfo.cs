using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     VoucherInfo Data Structure.
	/// </summary>
	[Serializable]
	public class VoucherInfo : AopObject
	{
		/// <summary>
		///     是否可转赠。默认true
		/// </summary>
		[JsonProperty("can_give_friend")]
		public bool CanGiveFriend { get; set; }

		/// <summary>
		///     使用规则
		/// </summary>
		[JsonProperty("use_rule")]
		public UseRuleInfo UseRule { get; set; }

		/// <summary>
		///     有效期
		/// </summary>
		[JsonProperty("valid_date")]
		public ValidDateInfo ValidDate { get; set; }

		/// <summary>
		///     券详情描述
		/// </summary>
		[JsonProperty("voucher_desc")]
		public string VoucherDesc { get; set; }

		/// <summary>
		///     券背景图。该值调用接口:alipay.offline.material.image.upload生成
		/// </summary>
		[JsonProperty("voucher_img")]
		public string VoucherImg { get; set; }

		/// <summary>
		///     logo图片id。该值调用接口:alipay.offline.material.image.upload生成
		/// </summary>
		[JsonProperty("voucher_logo")]
		public string VoucherLogo { get; set; }

		/// <summary>
		///     券名称
		/// </summary>
		[JsonProperty("voucher_name")]
		public string VoucherName { get; set; }

		/// <summary>
		///     券上的详情描述信息
		/// </summary>
		[JsonProperty("voucher_terms")]
		
		public List<VoucherTermInfo> VoucherTerms { get; set; }

		/// <summary>
		///     券类型
		/// </summary>
		[JsonProperty("voucher_type")]
		public string VoucherType { get; set; }
	}
}