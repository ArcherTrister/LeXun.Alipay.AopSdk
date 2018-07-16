using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AntMerchantExpandIndirectModifyModel Data Structure.
	/// </summary>
	[Serializable]
	public class AntMerchantExpandIndirectModifyModel : AopObject
	{
		/// <summary>
		///     商户地址信息
		/// </summary>
		[JsonProperty("address_info")]
		
		public List<AddressInfo> AddressInfo { get; set; }

		/// <summary>
		///     商户简称
		/// </summary>
		[JsonProperty("alias_name")]
		public string AliasName { get; set; }

		/// <summary>
		///     商户对应银行所开立的结算卡信息
		/// </summary>
		[JsonProperty("bankcard_info")]
		
		public List<BankCardInfo> BankcardInfo { get; set; }

		/// <summary>
		///     商户证件编号（企业或者个体工商户提供营业执照，事业单位提供事证号）
		/// </summary>
		[JsonProperty("business_license")]
		public string BusinessLicense { get; set; }

		/// <summary>
		///     商户证件类型，取值范围：NATIONAL_LEGAL：营业执照；NATIONAL_LEGAL_MERGE:营业执照(多证合一)；INST_RGST_CTF：事业单位法人证书
		/// </summary>
		[JsonProperty("business_license_type")]
		public string BusinessLicenseType { get; set; }

		/// <summary>
		///     商户经营类目，参考文档：https://doc.open.alipay.com/doc2/detail?&docType=1&articleId=105444
		/// </summary>
		[JsonProperty("category_id")]
		public string CategoryId { get; set; }

		/// <summary>
		///     商户负责人信息
		/// </summary>
		[JsonProperty("contact_info")]
		
		public List<ContactInfo> ContactInfo { get; set; }

		/// <summary>
		///     商户编号，由机构定义，需要保证在机构下唯一，与sub_merchant_id二选一
		/// </summary>
		[JsonProperty("external_id")]
		public string ExternalId { get; set; }

		/// <summary>
		///     受理商户的支付宝账号（用于关联商户生活号、原服务窗，打通口碑营销活动）
		/// </summary>
		[JsonProperty("logon_id")]
		
		public List<string> LogonId { get; set; }

		/// <summary>
		///     商户备注信息，可填写额外信息
		/// </summary>
		[JsonProperty("memo")]
		public string Memo { get; set; }

		/// <summary>
		///     商户名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     受理商户的固定二维码链接地址（即一码多付页面地址，用于后续支付宝营销活动）  商户所属的银行或ISV 给商户的二维码url值  一码多付方案:https://doc.open.alipay.com/docs/doc.htm?
		///     &docType=1&articleId=105672
		/// </summary>
		[JsonProperty("pay_code_info")]
		
		public List<string> PayCodeInfo { get; set; }

		/// <summary>
		///     商户客服电话
		/// </summary>
		[JsonProperty("service_phone")]
		public string ServicePhone { get; set; }

		/// <summary>
		///     商户来源机构标识，填写机构在支付宝的pid
		/// </summary>
		[JsonProperty("source")]
		public string Source { get; set; }

		/// <summary>
		///     商户在支付宝入驻成功后，生成的支付宝内全局唯一的商户编号，与external_id二选一
		/// </summary>
		[JsonProperty("sub_merchant_id")]
		public string SubMerchantId { get; set; }
	}
}