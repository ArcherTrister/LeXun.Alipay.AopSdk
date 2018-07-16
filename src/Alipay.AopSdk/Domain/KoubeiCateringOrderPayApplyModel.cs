using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// KoubeiCateringOrderPayApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringOrderPayApplyModel : AopObject
    {
        /// <summary>
        /// 是否享受会员价。如果为 true,菜明细里面会按照会员 价(没有改价情况下)作为单 品价格咨询单品券优惠
        /// </summary>
        [XmlElement("member_flag")]
        public bool MemberFlag { get; set; }

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

        /// <summary>
        /// 交易超时时间  选填，默认3分钟.透传给交易，设置可支持如下格式：d:天，h:小时,m:分钟。 示例：5d,1h,3m
        /// </summary>
        [XmlElement("timeout")]
        public string Timeout { get; set; }

        /// <summary>
        /// 订单付款金额,以元为单位,精确到分
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 是否整单不可打折
        /// </summary>
        [XmlElement("undiscountable")]
        public bool Undiscountable { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
