using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Response
{
    /// <summary>
    /// AlipayMarketingCardBenefitCreateResponse.
    /// </summary>
    public class AlipayMarketingCardBenefitCreateResponse : AopResponse
    {
        /// <summary>
        /// 权益ID
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }
    }
}
