using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// KoubeiCateringOrderPayCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringOrderPayCancelModel : AopObject
    {
        /// <summary>
        /// 外部支付订单号,唯一标识本次支付的requestID
        /// </summary>
        [XmlElement("out_pay_no")]
        public string OutPayNo { get; set; }

        /// <summary>
        /// pos业务订单外部主键信息
        /// </summary>
        [XmlElement("pos_order_key")]
        public PosOrderKey PosOrderKey { get; set; }
    }
}
