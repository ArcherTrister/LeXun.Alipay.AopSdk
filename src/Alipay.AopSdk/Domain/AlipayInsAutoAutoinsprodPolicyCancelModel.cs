using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodPolicyCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoAutoinsprodPolicyCancelModel : AopObject
    {
        /// <summary>
        /// 车险订单号
        /// </summary>
        [XmlElement("trade_biz_id")]
        public string TradeBizId { get; set; }
    }
}
