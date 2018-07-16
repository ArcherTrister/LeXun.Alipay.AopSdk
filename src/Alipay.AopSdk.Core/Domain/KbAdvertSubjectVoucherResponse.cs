using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbAdvertSubjectVoucherResponse Data Structure.
	/// </summary>
	[Serializable]
	public class KbAdvertSubjectVoucherResponse : AopObject
	{
		/// <summary>
		///     品牌名称
		/// </summary>
		[JsonProperty("brand_name")]
		public string BrandName { get; set; }

		/// <summary>
		///     适用城市ID列表
		/// </summary>
		[JsonProperty("city_ids")]
		
		public List<string> CityIds { get; set; }

		/// <summary>
		///     背景图片
		/// </summary>
		[JsonProperty("cover")]
		public string Cover { get; set; }

		/// <summary>
		///     日库存
		/// </summary>
		[JsonProperty("daily_inventory")]
		public string DailyInventory { get; set; }

		/// <summary>
		///     结束时间
		/// </summary>
		[JsonProperty("gmt_end")]
		public string GmtEnd { get; set; }

		/// <summary>
		///     上架时间
		/// </summary>
		[JsonProperty("gmt_start")]
		public string GmtStart { get; set; }

		/// <summary>
		///     logo图片
		/// </summary>
		[JsonProperty("logo")]
		public string Logo { get; set; }

		/// <summary>
		///     使用须知
		/// </summary>
		[JsonProperty("manuals")]
		
		public List<KbadvertVoucherManual> Manuals { get; set; }

		/// <summary>
		///     商家名称
		/// </summary>
		[JsonProperty("merchant_name")]
		public string MerchantName { get; set; }

		/// <summary>
		///     商户ID
		/// </summary>
		[JsonProperty("partner_id")]
		public string PartnerId { get; set; }

		/// <summary>
		///     BUY：购买模式  OBTAIN：认领
		/// </summary>
		[JsonProperty("purchase_mode")]
		public string PurchaseMode { get; set; }

		/// <summary>
		///     门店ID列表
		/// </summary>
		[JsonProperty("shop_ids")]
		
		public List<string> ShopIds { get; set; }

		/// <summary>
		///     起步金额
		/// </summary>
		[JsonProperty("threshold_amount")]
		public string ThresholdAmount { get; set; }

		/// <summary>
		///     总库存
		/// </summary>
		[JsonProperty("total_inventory")]
		public string TotalInventory { get; set; }

		/// <summary>
		///     券ID
		/// </summary>
		[JsonProperty("voucher_id")]
		public string VoucherId { get; set; }

		/// <summary>
		///     券名称
		/// </summary>
		[JsonProperty("voucher_name")]
		public string VoucherName { get; set; }

		/// <summary>
		///     以元为单位
		/// </summary>
		[JsonProperty("voucher_org_value")]
		public string VoucherOrgValue { get; set; }

		/// <summary>
		///     券类型  LIMIT-单品券  NO_LIMIT_DISCOUNT-全场折扣券  NO_LIMIT_CASH-全场代金券
		/// </summary>
		[JsonProperty("voucher_type")]
		public string VoucherType { get; set; }

		/// <summary>
		///     券价值
		/// </summary>
		[JsonProperty("voucher_value")]
		public string VoucherValue { get; set; }
	}
}