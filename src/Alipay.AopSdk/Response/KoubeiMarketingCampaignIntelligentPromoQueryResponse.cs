using System;
using System.Xml.Serialization;
using Alipay.AopSdk.Domain;

namespace Alipay.AopSdk.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询返回的营销活动模型
        /// </summary>
        [XmlElement("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
