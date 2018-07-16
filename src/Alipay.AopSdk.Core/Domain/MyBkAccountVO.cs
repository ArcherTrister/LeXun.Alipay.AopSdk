using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     MyBkAccountVO Data Structure.
	/// </summary>
	[Serializable]
	public class MyBkAccountVO : AopObject
	{
		/// <summary>
		///     账号外标，如支付宝登录号
		/// </summary>
		[JsonProperty("account_ext_no")]
		public string AccountExtNo { get; set; }

		/// <summary>
		///     金融机构支行联行号
		/// </summary>
		[JsonProperty("account_fip_branch_code")]
		public string AccountFipBranchCode { get; set; }

		/// <summary>
		///     金融机构码
		/// </summary>
		[JsonProperty("account_fip_code")]
		public string AccountFipCode { get; set; }

		/// <summary>
		///     金融机构名称
		/// </summary>
		[JsonProperty("account_fip_name")]
		public string AccountFipName { get; set; }

		/// <summary>
		///     资金账号,支付宝2088开头或银行卡号
		/// </summary>
		[JsonProperty("account_no")]
		public string AccountNo { get; set; }

		/// <summary>
		///     账号分类，ALIPAY("ALIPAY", "Alipay", "支付宝账号", "支付宝账号"),MY_BANK("MY_BANK", "MayiBank", "网商银行账号",
		///     "网商银行账号"),OUT_BANK("OUT_BANK", "OutBank", "外部银行账号", "外部银行账号")
		/// </summary>
		[JsonProperty("account_type")]
		public string AccountType { get; set; }

		/// <summary>
		///     是否可用，Y-可用；N-不可用
		/// </summary>
		[JsonProperty("available")]
		public string Available { get; set; }

		/// <summary>
		///     账户对公对私类型,P-对私，B-对公
		/// </summary>
		[JsonProperty("bank_card_category")]
		public string BankCardCategory { get; set; }

		/// <summary>
		///     持卡人姓名
		/// </summary>
		[JsonProperty("card_holder_name")]
		public string CardHolderName { get; set; }

		/// <summary>
		///     放款来源
		/// </summary>
		[JsonProperty("grant_channel")]
		public string GrantChannel { get; set; }

		/// <summary>
		///     账户不可用原因
		/// </summary>
		[JsonProperty("refuse_code")]
		public string RefuseCode { get; set; }
	}
}