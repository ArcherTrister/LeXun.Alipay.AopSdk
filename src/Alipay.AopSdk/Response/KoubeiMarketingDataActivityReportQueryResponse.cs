using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Response
{
    /// <summary>
    /// KoubeiMarketingDataActivityReportQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataActivityReportQueryResponse : AopResponse
    {
        /// <summary>
        /// 报表
        /// </summary>
        [XmlElement("report_data")]
        public string ReportData { get; set; }
    }
}
