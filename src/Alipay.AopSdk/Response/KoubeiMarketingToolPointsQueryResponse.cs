using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Response
{
    /// <summary>
    /// KoubeiMarketingToolPointsQueryResponse.
    /// </summary>
    public class KoubeiMarketingToolPointsQueryResponse : AopResponse
    {
        /// <summary>
        /// 可用集点
        /// </summary>
        [XmlElement("available_points")]
        public string AvailablePoints { get; set; }

        /// <summary>
        /// 冻结集点
        /// </summary>
        [XmlElement("freezed_points")]
        public string FreezedPoints { get; set; }

        /// <summary>
        /// 累计集点
        /// </summary>
        [XmlElement("total_points")]
        public string TotalPoints { get; set; }
    }
}
