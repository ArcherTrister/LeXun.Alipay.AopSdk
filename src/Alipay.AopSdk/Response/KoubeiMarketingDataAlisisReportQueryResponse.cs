using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Alipay.AopSdk.Domain;

namespace Alipay.AopSdk.Response
{
    /// <summary>
    /// KoubeiMarketingDataAlisisReportQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataAlisisReportQueryResponse : AopResponse
    {
        /// <summary>
        /// 报表数据
        /// </summary>
        [XmlArray("report_data")]
        [XmlArrayItem("alisis_report_row")]
        public List<AlisisReportRow> ReportData { get; set; }
    }
}
