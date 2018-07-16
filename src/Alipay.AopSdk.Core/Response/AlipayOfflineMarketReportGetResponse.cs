using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOfflineMarketReportGetResponse.
	/// </summary>
	public class AlipayOfflineMarketReportGetResponse : AopResponse
	{
		/// <summary>
		///     街道
		/// </summary>
		[JsonProperty("address")]
		public string Address { get; set; }

		/// <summary>
		///     近30日交易金额
		/// </summary>
		[JsonProperty("amount_in_30_days")]
		public string AmountIn30Days { get; set; }

		/// <summary>
		///     近7日交易金额
		/// </summary>
		[JsonProperty("amount_in_7_days")]
		public string AmountIn7Days { get; set; }

		/// <summary>
		///     人均消费金额(单位:分,下同)
		/// </summary>
		[JsonProperty("amount_per_capita")]
		public string AmountPerCapita { get; set; }

		/// <summary>
		///     昨日交易金额
		/// </summary>
		[JsonProperty("amount_yesterday")]
		public string AmountYesterday { get; set; }

		/// <summary>
		///     大区
		/// </summary>
		[JsonProperty("area")]
		public string Area { get; set; }

		/// <summary>
		///     WAITING_ASSIGN(待分配)、确认中(CONFIRMING)、已分配(ASSIGNED)
		/// </summary>
		[JsonProperty("assign_status")]
		public string AssignStatus { get; set; }

		/// <summary>
		///     后台小二的UID
		/// </summary>
		[JsonProperty("bd_staff_uid")]
		public string BdStaffUid { get; set; }

		/// <summary>
		///     品牌
		/// </summary>
		[JsonProperty("brand_name")]
		public string BrandName { get; set; }

		/// <summary>
		///     城市
		/// </summary>
		[JsonProperty("city")]
		public string City { get; set; }

		/// <summary>
		///     市代码
		/// </summary>
		[JsonProperty("city_code")]
		public string CityCode { get; set; }

		/// <summary>
		///     城市经理
		/// </summary>
		[JsonProperty("city_manager_name")]
		public string CityManagerName { get; set; }

		/// <summary>
		///     城市经理uid
		/// </summary>
		[JsonProperty("city_manager_uid")]
		public string CityManagerUid { get; set; }

		/// <summary>
		///     竞对最低折扣值
		/// </summary>
		[JsonProperty("competitor_lowest_discount")]
		public string CompetitorLowestDiscount { get; set; }

		/// <summary>
		///     1：全民开店的数据开店类型显示为全民开店；0：非全民开店的数据开店类型显示为非全民开店；
		/// </summary>
		[JsonProperty("create_channel")]
		public string CreateChannel { get; set; }

		/// <summary>
		///     三级行业
		/// </summary>
		[JsonProperty("detail_category")]
		public string DetailCategory { get; set; }

		/// <summary>
		///     三级行业编号
		/// </summary>
		[JsonProperty("detail_category_code")]
		public string DetailCategoryCode { get; set; }

		/// <summary>
		///     折扣id
		/// </summary>
		[JsonProperty("discount_id")]
		public string DiscountId { get; set; }

		/// <summary>
		///     区(县)
		/// </summary>
		[JsonProperty("district")]
		public string District { get; set; }

		/// <summary>
		///     区县代码
		/// </summary>
		[JsonProperty("district_code")]
		public string DistrictCode { get; set; }

		/// <summary>
		///     当面付审核状态
		/// </summary>
		[JsonProperty("f2f_audit_status")]
		public string F2fAuditStatus { get; set; }

		/// <summary>
		///     当面付生效时间
		/// </summary>
		[JsonProperty("f2f_online")]
		public string F2fOnline { get; set; }

		/// <summary>
		///     当面付签约次数
		/// </summary>
		[JsonProperty("f2f_sign_count")]
		public string F2fSignCount { get; set; }

		/// <summary>
		///     当面付状态
		/// </summary>
		[JsonProperty("f2f_status")]
		public string F2fStatus { get; set; }

		/// <summary>
		///     当面付签约情况-版本
		/// </summary>
		[JsonProperty("f2f_version")]
		public string F2fVersion { get; set; }

		/// <summary>
		///     当面付审核状态
		/// </summary>
		[JsonProperty("ff_audit_status")]
		public string FfAuditStatus { get; set; }

		/// <summary>
		///     当面付生效时间
		/// </summary>
		[JsonProperty("ff_online")]
		public string FfOnline { get; set; }

		/// <summary>
		///     当面付签约次数
		/// </summary>
		[JsonProperty("ff_sign_count")]
		public string FfSignCount { get; set; }

		/// <summary>
		///     当面付状态
		/// </summary>
		[JsonProperty("ff_status")]
		public string FfStatus { get; set; }

		/// <summary>
		///     当面付签约情况-版本
		/// </summary>
		[JsonProperty("ff_version")]
		public string FfVersion { get; set; }

		/// <summary>
		///     门店创建时间
		/// </summary>
		[JsonProperty("gmt_create")]
		public string GmtCreate { get; set; }

		/// <summary>
		///     门店修改时间
		/// </summary>
		[JsonProperty("gmt_modified")]
		public string GmtModified { get; set; }

		/// <summary>
		///     有无折扣
		/// </summary>
		[JsonProperty("has_discount")]
		public string HasDiscount { get; set; }

		/// <summary>
		///     是否享受立减(0:否；1:是)
		/// </summary>
		[JsonProperty("has_discount_privilege")]
		public string HasDiscountPrivilege { get; set; }

		/// <summary>
		///     是否有机具
		/// </summary>
		[JsonProperty("has_equipment")]
		public string HasEquipment { get; set; }

		/// <summary>
		///     有无双证
		/// </summary>
		[JsonProperty("has_shuangzheng")]
		public string HasShuangzheng { get; set; }

		/// <summary>
		///     是否有全民折扣(0:否；1:是)
		/// </summary>
		[JsonProperty("has_whole_people_discount")]
		public string HasWholePeopleDiscount { get; set; }

		/// <summary>
		///     流水号
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		///     是否在黑名单(0:否；1:是)
		/// </summary>
		[JsonProperty("in_blacklist")]
		public string InBlacklist { get; set; }

		/// <summary>
		///     有效期30天以上折扣是否核销
		/// </summary>
		[JsonProperty("item_consumed_30")]
		public string ItemConsumed30 { get; set; }

		/// <summary>
		///     有效期30天以上折扣数
		/// </summary>
		[JsonProperty("item_count_30")]
		public string ItemCount30 { get; set; }

		/// <summary>
		///     是否ka
		/// </summary>
		[JsonProperty("ka")]
		public string Ka { get; set; }

		/// <summary>
		///     leads商户名称
		/// </summary>
		[JsonProperty("leads_name")]
		public string LeadsName { get; set; }

		/// <summary>
		///     城市经理或超级管理员确认门店分配的时间
		/// </summary>
		[JsonProperty("manual_confirm_assign_time")]
		public string ManualConfirmAssignTime { get; set; }

		/// <summary>
		///     商户名称
		/// </summary>
		[JsonProperty("merchant_name")]
		public string MerchantName { get; set; }

		/// <summary>
		///     商户pid
		/// </summary>
		[JsonProperty("merchant_pid")]
		public string MerchantPid { get; set; }

		/// <summary>
		///     电话
		/// </summary>
		[JsonProperty("mobile")]
		public string Mobile { get; set; }

		/// <summary>
		///     近30天大于2元订单量
		/// </summary>
		[JsonProperty("order_1")]
		public string Order1 { get; set; }

		/// <summary>
		///     近1天大于2元订单量
		/// </summary>
		[JsonProperty("order_in_1_day")]
		public string OrderIn1Day { get; set; }

		/// <summary>
		///     近7天内大于2元订单量
		/// </summary>
		[JsonProperty("order_in_7_days")]
		public string OrderIn7Days { get; set; }

		/// <summary>
		///     一级行业
		/// </summary>
		[JsonProperty("pri_category")]
		public string PriCategory { get; set; }

		/// <summary>
		///     一级行业编号
		/// </summary>
		[JsonProperty("pri_category_code")]
		public string PriCategoryCode { get; set; }

		/// <summary>
		///     省代码
		/// </summary>
		[JsonProperty("prov_code")]
		public string ProvCode { get; set; }

		/// <summary>
		///     服务商名称
		/// </summary>
		[JsonProperty("provider_name")]
		public string ProviderName { get; set; }

		/// <summary>
		///     服务商Pid
		/// </summary>
		[JsonProperty("provider_pid")]
		public string ProviderPid { get; set; }

		/// <summary>
		///     服务商小二
		/// </summary>
		[JsonProperty("provider_staff_name")]
		public string ProviderStaffName { get; set; }

		/// <summary>
		///     服务商小二uid
		/// </summary>
		[JsonProperty("provider_staff_uid")]
		public string ProviderStaffUid { get; set; }

		/// <summary>
		///     省
		/// </summary>
		[JsonProperty("province")]
		public string Province { get; set; }

		/// <summary>
		///     全民开店类型的推荐人,体现为归属人
		/// </summary>
		[JsonProperty("recommender")]
		public string Recommender { get; set; }

		/// <summary>
		///     推荐人类型
		/// </summary>
		[JsonProperty("recommender_type")]
		public string RecommenderType { get; set; }

		/// <summary>
		///     门店审核状态(审核中|审核通过|审核失败)
		/// </summary>
		[JsonProperty("shop_audit_status")]
		public string ShopAuditStatus { get; set; }

		/// <summary>
		///     门店编号
		/// </summary>
		[JsonProperty("shop_id")]
		public string ShopId { get; set; }

		/// <summary>
		///     店铺运营等级，0：全国KA，1：城市重点，2：中小，3：长尾
		/// </summary>
		[JsonProperty("shop_level")]
		public string ShopLevel { get; set; }

		/// <summary>
		///     店铺名称
		/// </summary>
		[JsonProperty("shop_name")]
		public string ShopName { get; set; }

		/// <summary>
		///     门店首次上架时间
		/// </summary>
		[JsonProperty("shop_online")]
		public string ShopOnline { get; set; }

		/// <summary>
		///     开店来源。有服务商开店，商家自主开店，全民个人开店等
		/// </summary>
		[JsonProperty("shop_source")]
		public string ShopSource { get; set; }

		/// <summary>
		///     门店标签,多个以逗号分隔
		/// </summary>
		[JsonProperty("shop_tag")]
		public string ShopTag { get; set; }

		/// <summary>
		///     二级行业
		/// </summary>
		[JsonProperty("sub_category")]
		public string SubCategory { get; set; }

		/// <summary>
		///     二级行业编号
		/// </summary>
		[JsonProperty("sub_category_code")]
		public string SubCategoryCode { get; set; }

		/// <summary>
		///     电话
		/// </summary>
		[JsonProperty("telephone")]
		public string Telephone { get; set; }

		/// <summary>
		///     近30天大于2元用户数
		/// </summary>
		[JsonProperty("user_1")]
		public string User1 { get; set; }

		/// <summary>
		///     user_in_1_day
		/// </summary>
		[JsonProperty("user_in_1_day")]
		public string UserIn1Day { get; set; }

		/// <summary>
		///     近7天内大于2元的用户数
		/// </summary>
		[JsonProperty("user_in_7_days")]
		public string UserIn7Days { get; set; }

		/// <summary>
		///     近1天核销笔数
		/// </summary>
		[JsonProperty("verification_in_1_day")]
		public string VerificationIn1Day { get; set; }

		/// <summary>
		///     近30天内核销笔数
		/// </summary>
		[JsonProperty("verification_in_30_days")]
		public string VerificationIn30Days { get; set; }

		/// <summary>
		///     近7天内核销笔数
		/// </summary>
		[JsonProperty("verification_in_7_days")]
		public string VerificationIn7Days { get; set; }

		/// <summary>
		///     全民最低折扣值
		/// </summary>
		[JsonProperty("whole_people_lowest_discount")]
		public string WholePeopleLowestDiscount { get; set; }
	}
}