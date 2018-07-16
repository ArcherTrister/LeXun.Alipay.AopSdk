using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcoEduKtStudentQueryResponse.
	/// </summary>
	public class AlipayEcoEduKtStudentQueryResponse : AopResponse
	{
		/// <summary>
		///     学生姓名
		/// </summary>
		[JsonProperty("child_name")]
		public string ChildName { get; set; }

		/// <summary>
		///     班级名字
		/// </summary>
		[JsonProperty("class_name")]
		public string ClassName { get; set; }

		/// <summary>
		///     学校名称
		/// </summary>
		[JsonProperty("school_name")]
		public string SchoolName { get; set; }

		/// <summary>
		///     学生编号
		/// </summary>
		[JsonProperty("student_code")]
		public string StudentCode { get; set; }

		/// <summary>
		///     学生身份证
		/// </summary>
		[JsonProperty("student_identify")]
		public string StudentIdentify { get; set; }

		/// <summary>
		///     家长信息
		/// </summary>
		[JsonProperty("users")]
		
		public List<UserDetails> Users { get; set; }
	}
}