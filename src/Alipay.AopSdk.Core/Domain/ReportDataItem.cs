using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ReportDataItem Data Structure.
	/// </summary>
	[Serializable]
	public class ReportDataItem : AopObject
	{
		/// <summary>
		///     表示一行数据，每个对象是一列的数据
		/// </summary>
		[JsonProperty("row_data")]
		public string RowData { get; set; }
	}
}