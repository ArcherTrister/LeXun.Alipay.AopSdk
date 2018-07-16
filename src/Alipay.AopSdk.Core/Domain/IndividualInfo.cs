using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     IndividualInfo Data Structure.
	/// </summary>
	[Serializable]
	public class IndividualInfo : AopObject
	{
		/// <summary>
		///     生日
		/// </summary>
		[JsonProperty("date_of_birth")]
		public string DateOfBirth { get; set; }

		/// <summary>
		///     证件号码
		/// </summary>
		[JsonProperty("id_number")]
		public string IdNumber { get; set; }

		/// <summary>
		///     个人名字
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     国籍
		/// </summary>
		[JsonProperty("nationality")]
		public string Nationality { get; set; }

		/// <summary>
		///     个人居住地
		/// </summary>
		[JsonProperty("residential_address")]
		public string ResidentialAddress { get; set; }

		/// <summary>
		///     该个体的类型
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }
	}
}