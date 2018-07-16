using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayCommerceDataMonitordataSyncModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayCommerceDataMonitordataSyncModel : AopObject
	{
		/// <summary>
		///     传入的批量打包数据，dataEntry和dataDim的组合数据，详见dataEntry和dataDim的说明
		/// </summary>
		[JsonProperty("datas")]
		
		public List<Datas> Datas { get; set; }

		/// <summary>
		///     接口的版本，当前版本是v1.0.0
		/// </summary>
		[JsonProperty("interface_version")]
		public string InterfaceVersion { get; set; }
	}
}