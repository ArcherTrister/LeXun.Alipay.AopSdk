using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectActivityConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectActivityConfirmModel : AopObject
    {
        /// <summary>
        /// 活动报名id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
