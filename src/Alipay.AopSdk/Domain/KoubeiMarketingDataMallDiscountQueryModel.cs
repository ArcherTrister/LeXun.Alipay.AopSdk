using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// KoubeiMarketingDataMallDiscountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataMallDiscountQueryModel : AopObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }
    }
}
