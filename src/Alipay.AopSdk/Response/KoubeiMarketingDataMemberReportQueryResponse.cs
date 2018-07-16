using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Response
{
    /// <summary>
    /// KoubeiMarketingDataMemberReportQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataMemberReportQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询成功时返回json格式数据
        /// </summary>
        [XmlElement("report_data")]
        public string ReportData { get; set; }
    }
}
