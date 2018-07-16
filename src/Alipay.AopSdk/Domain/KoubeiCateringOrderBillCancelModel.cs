using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// KoubeiCateringOrderBillCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringOrderBillCancelModel : AopObject
    {
        /// <summary>
        /// 取消类型：RENEW-退款并重新生成新订单（反结场景），REFUND-仅退款不生成新订单（先付撤销、外卖退款场景）
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 取消时间
        /// </summary>
        [XmlElement("cancel_time")]
        public string CancelTime { get; set; }

        /// <summary>
        /// pos业务订单外部主键信息
        /// </summary>
        [XmlElement("pos_order_key")]
        public PosOrderKey PosOrderKey { get; set; }
    }
}
